using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioProductos
    {
        private readonly ContextoVentas context;
        
        public RepositorioProductos()
        {
            context = new ContextoVentas();
        }

        public List<Producto> Listar()
        {
            return context.Productos
                          .AsNoTracking()
                          .OrderBy(p => p.Nombre)
                          .ToList();
        }

        public Producto? ObtenerPorId(int id)
        {
            return context.Productos.Find(id);
        }

        public Producto? ObtenerPorCodigo(int codigo)
        {
            return context.Productos
                          .FirstOrDefault(p => p.Codigo == codigo);
        }

        public void AgregarProducto(Producto producto)
        {
            context.Productos.Add(producto);
            context.SaveChanges();
        }

        public void ModificarProducto(Producto producto)
        {
            context.Productos.Update(producto);
            context.SaveChanges();
        }

        public void EliminarProducto(int id)
        {
            var prod = context.Productos.Find(id);
            if (prod != null)
            {
                context.Productos.Remove(prod);
                context.SaveChanges();
            }
        }
    }
}
