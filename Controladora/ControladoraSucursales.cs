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
            // acá podrías validar si tiene stock/ventas, etc.
            repo.Eliminar(sucursalId);
            return "Sucursal eliminada.";
        }
    }
}
