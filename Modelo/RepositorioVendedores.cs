using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.EntityFrameworkCore;


namespace Modelo
{
    public class RepositorioVendedores
    {
        public List<Vendedor> ListarTodos()
        {
            using var ctx = new ContextoVentas();
            return ctx.Vendedores
                      .Include(v => v.Sucursal)
                      .AsNoTracking()
                      .ToList();
        }

        public List<Vendedor> ListarPorSucursal(int sucursalId)
        {
            using var ctx = new ContextoVentas();
            return ctx.Vendedores
                      .Include(v => v.Sucursal)
                      .Where(v => v.SucursalId == sucursalId)
                      .AsNoTracking()
                      .ToList();
        }

        public List<Sucursal> ListarSucursales()
        {
            using var ctx = new ContextoVentas();
            return ctx.Sucursales
                      .AsNoTracking()
                      .ToList();
        }

        public void Agregar(string nombre, string apellido, int sucursalId)
        {
            using var ctx = new ContextoVentas();

            var sucursal = ctx.Sucursales.FirstOrDefault(s => s.SucursalId == sucursalId);
            if (sucursal == null) throw new Exception("Sucursal no encontrada.");

            var vendedor = new Vendedor
            {
                Nombre = nombre.Trim(),
                Apellido = apellido.Trim(),
                SucursalId = sucursalId
            };

            ctx.Vendedores.Add(vendedor);
            ctx.SaveChanges();
        }

        public void Modificar(int vendedorId, string nombre, string apellido, int sucursalId)
        {
            using var ctx = new ContextoVentas();

            var vendedor = ctx.Vendedores.FirstOrDefault(v => v.VendedorId == vendedorId);
            if (vendedor == null) throw new Exception("Vendedor no encontrado.");

            var sucursal = ctx.Sucursales.FirstOrDefault(s => s.SucursalId == sucursalId);
            if (sucursal == null) throw new Exception("Sucursal no encontrada.");

            vendedor.Nombre = nombre.Trim();
            vendedor.Apellido = apellido.Trim();
            vendedor.SucursalId = sucursalId;

            ctx.SaveChanges();
        }

        public void Eliminar(int vendedorId)
        {
            using var ctx = new ContextoVentas();

            var vendedor = ctx.Vendedores.FirstOrDefault(v => v.VendedorId == vendedorId);
            if (vendedor == null) return;

            ctx.Vendedores.Remove(vendedor);

            try
            {
                ctx.SaveChanges();
            }
            catch (DbUpdateException)
            {
                throw new Exception("No se puede eliminar el vendedor porque tiene ventas asociadas.");
            }
        }
    }


}   
