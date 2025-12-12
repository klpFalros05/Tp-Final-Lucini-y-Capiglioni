using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioStockPorSucursal
    {
        private readonly ContextoVentas context;

        public RepositorioStockPorSucursal()
        {
            context = new ContextoVentas();
        }

        // Listar stock de una sucursal
        public List<Stock> ListarPorSucursal(int sucursalId)
        {
            return context.Stocks
                           .Include(s => s.Producto)
                           .Include(s => s.Sucursal)
                           .Where(s => s.SucursalId == sucursalId)
                           .ToList();
        }

        // Obtener la fila de stock de un producto en una sucursal
        public Stock? Obtener(int sucursalId, int productoId)
        {
            return context.Stocks
                           .FirstOrDefault(s => s.SucursalId == sucursalId
                                             && s.ProductoId == productoId);
        }

        // Agregar o actualizar stock (para no duplicar filas)
        public void AgregarOActualizar(int sucursalId, int productoId, int cantidad)
        {
            var stock = Obtener(sucursalId, productoId);

            if (stock == null)
            {
                stock = new Stock
                {
                    SucursalId = sucursalId,
                    ProductoId = productoId,
                    Cantidad = cantidad
                };
                context.Stocks.Add(stock);
            }
            else
            {
                // Podés sumar o reemplazar, según la lógica que quieras
                stock.Cantidad += cantidad;
            }

            context.SaveChanges();
        }
    }
}
