using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraStockPorSucursal
    {
        private readonly RepositorioStockPorSucursal repoStocks = new RepositorioStockPorSucursal();
        private readonly RepositorioProductos repoProductos = new RepositorioProductos();

        private static ControladoraStockPorSucursal instancia;
        public static ControladoraStockPorSucursal Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ControladoraStockPorSucursal();
                return instancia;
            }
        }

        private ControladoraStockPorSucursal() { }

        public List<Stock> ListarPorSucursal(int sucursalId)
            => repoStocks.ListarPorSucursal(sucursalId);

        public string AgregarStockASucursal(int sucursalId, int productoId, int cantidad)
        {
            if (cantidad <= 0)
                throw new Exception("La cantidad debe ser mayor a cero.");

            // 1) Traigo el producto desde el repositorio
            var producto = repoProductos.ObtenerPorId(productoId)
                           ?? throw new Exception("Producto no encontrado.");

            // 2) Valido stock disponible en el depósito (stock general)
            if (producto.StockTotal < cantidad)
                throw new Exception(
                    $"No hay stock suficiente en el depósito. Stock disponible: {producto.StockTotal}");

            // 3) Descuento del stock general (depósito)
            producto.StockTotal -= cantidad;
            repoProductos.ModificarProducto(producto);  // guarda el cambio en la BD

            // 4) Asigno el stock a la sucursal (crea/actualiza la fila en Stocks)
            repoStocks.AgregarOActualizar(sucursalId, productoId, cantidad);

            return "Stock asignado a la sucursal.";
        }
    }
}
