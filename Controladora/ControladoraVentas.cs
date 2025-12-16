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

        // ----------------- Cálculo de totales -----------------
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
                // Mayorista.Descuento = 0.10m, por ejemplo
                descuento = subtotal * may.Descuento;
            }
            else if (cliente is Minorista min)
            {
                // Minorista.Descuento = 0.05m, por ejemplo
                descuento = subtotal * min.Descuento;
            }

            decimal total = subtotal - descuento;
            return (subtotal, descuento, total);
        }

        // ----------------- Registrar venta -----------------
        public string RegistrarVenta(
            int sucursalId,
            int idCliente,
            int vendedorId,
            MetodoPago metodoPago,
            DateTime fecha,
            bool pagaAhora,
            List<DetalleVenta> detalles)
        {
            if (detalles == null || !detalles.Any())
                throw new Exception("El carrito está vacío.");

            // 1) Recalcular totales
            var (subtotal, descuento, total) = CalcularTotales(idCliente, detalles);

            // 2) Validar stock en la sucursal y descontarlo
            foreach (var det in detalles)
            {
                var stock = repoStock.Obtener(sucursalId, det.ProductoId)
                            ?? throw new Exception($"No hay stock del producto {det.ProductoId} en la sucursal.");

                if (det.Cantidad > stock.Cantidad)
                    throw new Exception($"No hay stock suficiente de {stock.Producto.Nombre} en la sucursal.");

                stock.Cantidad -= det.Cantidad;
                repoStock.Actualizar(stock);
            }

            // 3) Crear la Venta con sus detalles
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

            // 4) Actualizar estado de cuenta del mayorista
            var cliente = repoClientes.ObtenerPorId(idCliente);
            if (cliente is Mayorista may)
            {
                // Si compra en cuenta corriente, sumamos al monto que debe
                if (!pagaAhora)
                {
                    may.MontoDebe += total;
                }

                // Estado de cuenta según si debe algo o no
                may.EstadoCuenta = may.MontoDebe > 0
                    ? EstadoDeCuenta.Debe
                    : EstadoDeCuenta.AlDia;

                // Guardamos cambios en la BD
                repoClientes.Modificar(may);
            }
            repoVentas.RegistrarVenta(venta);

            return "Venta registrada correctamente.";
        }
    }
}
