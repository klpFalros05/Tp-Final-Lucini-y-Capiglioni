using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraProductos
    {
        private readonly RepositorioProductos repositorioProductos = new RepositorioProductos();

        private static ControladoraProductos instancia;

        public static ControladoraProductos Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ControladoraProductos();

                return instancia;
            }
        }

        // ctor privado para el Singleton
        private ControladoraProductos() { }

        // ---------- Métodos que usa la Vista -----------
        public List<Producto> ListarProductos()
        {
            return repositorioProductos.Listar();
        }

        public string AgregarProducto(int codigo, string nombre, string descripcion,
                                      string categoria, decimal precio, int stockTotal)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("El nombre es obligatorio.");

            var existente = repositorioProductos.ObtenerPorCodigo(codigo);
            if (existente != null)
                throw new Exception("Ya existe un producto con ese código.");

            var producto = new Producto
            {
                Codigo = codigo,
                Nombre = nombre,
                Descripcion = descripcion,
                Categoria = categoria,
                Precio = precio,
                StockTotal = stockTotal
            };

            repositorioProductos.AgregarProducto(producto);
            return "Producto agregado";
        }

        public string ModificarProducto(int productoId, int codigo, string nombre,
                                        string descripcion, string categoria,
                                        decimal precio, int stockTotal)
        {
            var prod = repositorioProductos.ObtenerPorId(productoId)
                       ?? throw new Exception("Producto no encontrado.");

            prod.Codigo = codigo;
            prod.Nombre = nombre;
            prod.Descripcion = descripcion;
            prod.Categoria = categoria;
            prod.Precio = precio;
            prod.StockTotal = stockTotal;

            repositorioProductos.ModificarProducto(prod);
            return "Producto modificado";
        }

        public string EliminarProducto(int productoId)
        {
            repositorioProductos.EliminarProducto(productoId);
            return "Producto eliminado";
        }
    }
}
