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

        public void RegistrarVenta(Venta venta)
        {
            context.Ventas.Add(venta);
            context.SaveChanges();
        }

        public List<Venta> ListarFiltrado(DateTime? desde,DateTime? hasta, int? sucursalId,int? clienteId,int? vendedorId,MetodoPago? metodoPago)
        {
            var query = context.Ventas
                               .Include(v => v.Sucursal)
                               .Include(v => v.Cliente)
                               .Include(v => v.Vendedor)
                               .Include(v => v.Detalles)
                               .ThenInclude(d => d.Producto)
                               .AsQueryable();

            if (desde.HasValue)
            {
                var inicio = desde.Value.Date;
                query = query.Where(v => v.Fecha >= inicio);
            }

            if (hasta.HasValue)
            {
                // hasta el final del día seleccionado
                var fin = hasta.Value.Date.AddDays(1).AddTicks(-1);
                query = query.Where(v => v.Fecha <= fin);
            }

            if (sucursalId.HasValue)
                query = query.Where(v => v.SucursalId == sucursalId.Value);

            if (clienteId.HasValue)
                query = query.Where(v => v.ClienteId == clienteId.Value);

            if (vendedorId.HasValue)
                query = query.Where(v => v.VendedorId == vendedorId.Value);

            if (metodoPago.HasValue)
                query = query.Where(v => v.MetodoPago == metodoPago.Value);

            return query
                    .OrderBy(v => v.Fecha)
                    .ToList();
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
