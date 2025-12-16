using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioVentas
    {
        private readonly ContextoVentas context;

        public RepositorioVentas()
        {
            context = new ContextoVentas();
        }

        /// Registra una venta con sus detalles
        public void RegistrarVenta(Venta venta)
        {
            context.Ventas.Add(venta);
            context.SaveChanges();
        }

        /// Listar ventas (sirve después para reportes)
        public List<Venta> Listar(DateTime? desde = null, DateTime? hasta = null)
        {
            var query = context.Ventas
                               .Include(v => v.Cliente)
                               .Include(v => v.Sucursal)
                               .Include(v => v.Vendedor)
                               .Include(v => v.Detalles)
                                   .ThenInclude(d => d.Producto)
                               .AsQueryable();

            if (desde.HasValue)
                query = query.Where(v => v.Fecha >= desde.Value);

            if (hasta.HasValue)
                query = query.Where(v => v.Fecha <= hasta.Value);

            return query.ToList();
        }

        public Venta? ObtenerPorId(int id)
        {
            return context.Ventas
                          .Include(v => v.Cliente)
                          .Include(v => v.Sucursal)
                          .Include(v => v.Vendedor)
                          .Include(v => v.Detalles)
                              .ThenInclude(d => d.Producto)
                          .FirstOrDefault(v => v.VentaId == id);
        }
    }
}
