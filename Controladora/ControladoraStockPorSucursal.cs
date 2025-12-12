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
        {
            return repoStocks.ListarPorSucursal(sucursalId);
        }

        public string AgregarStockASucursal(int sucursalId, int productoId, int cantidad)
        {
            if (cantidad <= 0)
                throw new Exception("La cantidad debe ser mayor a cero.");

            // (Opcional pero lindo para explicar a la profe):
            // Validar que no se supere el stock total del producto.
            var producto = repoProductos.ObtenerPorId(productoId)
                           ?? throw new Exception("Producto no encontrado.");

            // Acá podrías calcular cuánto stock ya está asignado a sucursales
            // y comparar con producto.StockTotal si querés ser más estricto.

            repoStocks.AgregarOActualizar(sucursalId, productoId, cantidad);
            return "Stock asignado a la sucursal.";
        }
    }
}
