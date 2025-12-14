using Controladora.Dtos;
using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraVendedores
    {
        private static ControladoraVendedores? _instancia;
        public static ControladoraVendedores Instancia => _instancia ??= new ControladoraVendedores();

        private readonly RepositorioVendedores repo;

        private ControladoraVendedores()
        {
            repo = new RepositorioVendedores();
        }

        public List<VendedorDto> ListarTodosParaGrilla()
            => Mapear(repo.ListarTodos());

        public List<VendedorDto> ListarPorSucursalParaGrilla(int sucursalId)
        {
            if (sucursalId <= 0) throw new Exception("Seleccioná una sucursal válida.");
            return Mapear(repo.ListarPorSucursal(sucursalId));
        }

        private List<VendedorDto> Mapear(List<Entidades.Vendedor> vendedores)
        {
            return vendedores.Select(v => new VendedorDto
            {
                VendedorId = v.VendedorId,
                Nombre = v.Nombre,
                Apellido = v.Apellido,
                SucursalId = v.SucursalId,
                Sucursal = v.Sucursal != null ? v.Sucursal.NombreSucursal : ""
            }).ToList();
        }

        public List<Entidades.Sucursal> ListarSucursales()
            => repo.ListarSucursales();

        public void Agregar(string nombre, string apellido, int sucursalId)
        {
            Validar(nombre, apellido, sucursalId);
            repo.Agregar(nombre, apellido, sucursalId);
        }

        public void Modificar(int vendedorId, string nombre, string apellido, int sucursalId)
        {
            if (vendedorId <= 0) throw new Exception("Seleccioná un vendedor.");
            Validar(nombre, apellido, sucursalId);
            repo.Modificar(vendedorId, nombre, apellido, sucursalId);
        }

        public void Eliminar(int vendedorId)
        {
            if (vendedorId <= 0) throw new Exception("Seleccioná un vendedor.");
            repo.Eliminar(vendedorId);
        }

        private void Validar(string nombre, string apellido, int sucursalId)
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre es obligatorio.");
            if (string.IsNullOrWhiteSpace(apellido)) throw new Exception("El apellido es obligatorio.");
            if (sucursalId <= 0) throw new Exception("Seleccioná una sucursal.");
        }
    }
}
