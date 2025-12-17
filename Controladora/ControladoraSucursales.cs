using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraSucursales
    {
        private readonly RepositorioSucursales repo = new RepositorioSucursales();
        private readonly RepositorioStockPorSucursal repoStock = new RepositorioStockPorSucursal();

        private static ControladoraSucursales instancia;
        public static ControladoraSucursales Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ControladoraSucursales();
                return instancia;
            }
        }

        private ControladoraSucursales() { }

        public List<Sucursal> Listar()
        {
            return repo.Listar();
        }

        public string Agregar(string nombreSucursal)
        {
            if (string.IsNullOrWhiteSpace(nombreSucursal))
                throw new Exception("El nombre de la sucursal es obligatorio.");

            var sucursal = new Sucursal
            {
                NombreSucursal = nombreSucursal
            };

            repo.Agregar(sucursal);
            return "Sucursal agregada.";
        }

        public string Eliminar(int sucursalId)
        {
            // Verifico si la sucursal tiene stock
            var stockDeSucursal = repoStock.ListarPorSucursal(sucursalId);

            if (stockDeSucursal.Any())
            {
                // Si tiene,no dejo eliminar
                throw new Exception("No se puede eliminar la sucursal porque tiene productos asociados en su stock.");
            }

            // Si no tiene stock, se elimina
            repo.Eliminar(sucursalId);
            return "Sucursal eliminada correctamente.";
        }
    }
}
