using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraVentas
    {
        private readonly RepositorioVentas repoVentas = new RepositorioVentas();
        private readonly RepositorioStockPorSucursal repoStock = new RepositorioStockPorSucursal();
        private readonly RepositorioProductos repoProductos = new RepositorioProductos();
        private readonly RepositorioClientes repoClientes = new RepositorioClientes();

        private static ControladoraVentas instancia;
        public static ControladoraVentas Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ControladoraVentas();
                return instancia;
            }
        }

        private ControladoraVentas() { }

        public (decimal Subtotal, decimal Descuento, decimal Total)
            CalcularTotales(int idCliente, List<DetalleVenta> detalles)
        {
            if (detalles == null || !detalles.Any())
                return (0, 0, 0);

            decimal subtotal = detalles.Sum(d => d.Subtotal);
            decimal descuento = 0;

            var cliente = repoClientes.ObtenerPorId(idCliente);
            if (cliente is Mayorista may)
            {
                //Descuento Mayorista
                descuento = subtotal * may.Descuento;
            }
            else if (cliente is Minorista min)
            {
                // Descuento Minorista
                descuento = subtotal * min.Descuento;
            }

            decimal total = subtotal - descuento;
            return (subtotal, descuento, total);
        }

        public string RegistrarVenta(int sucursalId,int idCliente,int vendedorId,MetodoPago metodoPago,DateTime fecha,bool pagaAhora,
            List<DetalleVenta> detalles)
        {
            if (detalles == null || !detalles.Any())
                throw new Exception("El carrito está vacío.");

            var (subtotal, descuento, total) = CalcularTotales(idCliente, detalles);
            foreach (var det in detalles)
            {
                var stock = repoStock.Obtener(sucursalId, det.ProductoId)
                            ?? throw new Exception($"No hay stock del producto {det.ProductoId} en la sucursal.");

                if (det.Cantidad > stock.Cantidad)
                    throw new Exception($"No hay stock suficiente de {stock.Producto.Nombre} en la sucursal.");
                
                //Se resta el stock y se actualiza
                stock.Cantidad -= det.Cantidad;
                repoStock.Actualizar(stock);
            }

            var venta = new Venta
            {
                Fecha = fecha,
                MetodoPago = metodoPago,
                ClienteId = idCliente,
                SucursalId = sucursalId,
                VendedorId = vendedorId,
                Total = total,
                Detalles = detalles.Select(d => new DetalleVenta
                {
                    ProductoId = d.ProductoId,
                    Cantidad = d.Cantidad,
                    Subtotal = d.Subtotal
                }).ToList()
            };

            //Actualiza estado cuenta mayorista
            var cliente = repoClientes.ObtenerPorId(idCliente);
            if (cliente is Mayorista may)
            {
                // Si se paga en cuenta corriente se le suma el monto que debe
                if (!pagaAhora)
                {
                    may.MontoDebe += total;
                }

                // Estado de cuenta (si debe o no)
                may.EstadoCuenta = may.MontoDebe > 0
                    ? EstadoDeCuenta.Debe
                    : EstadoDeCuenta.AlDia;

                repoClientes.Modificar(may);
            }
            repoVentas.RegistrarVenta(venta);

            return "Venta registrada correctamente.";
        }
    }
}
