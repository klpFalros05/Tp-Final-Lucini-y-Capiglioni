using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioSucursales
    {
        private readonly ContextoVentas context;

        public RepositorioSucursales()
        {
            context = new ContextoVentas();
        }

        public List<Sucursal> Listar()
        {
            return context.Sucursales
                           //.AsNoTracking()
                           .OrderBy(s => s.NombreSucursal)
                           .ToList();
        }

        public Sucursal? ObtenerPorId(int id)
        {
            return context.Sucursales.Find(id);
        }

        public void Agregar(Sucursal sucursal)
        {
            context.Sucursales.Add(sucursal);
            context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var sucursal = context.Sucursales.Find(id);
            if (sucursal != null)
            {
                context.Sucursales.Remove(sucursal);
                context.SaveChanges();
            }
        }
    }
}
