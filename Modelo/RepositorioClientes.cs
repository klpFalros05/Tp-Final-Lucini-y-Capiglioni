using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioClientes
    {
        private readonly ContextoVentas context;

        public RepositorioClientes()
        {
            context = new ContextoVentas();
        }
        public List<Cliente> ListarTodos()
        {
            using var ctx = new ContextoVentas();
            return ctx.Clientes.AsNoTracking().ToList();
        }

        public List<Mayorista> ListarMayoristas()
        {
            using var ctx = new ContextoVentas();
            return ctx.Mayoristas.AsNoTracking().ToList();
        }

        public List<Minorista> ListarMinoristas()
        {
            using var ctx = new ContextoVentas();
            return ctx.Minoristas.AsNoTracking().ToList();
        }

        public void Agregar(Cliente cliente)
        {
            using var ctx = new ContextoVentas();
            ctx.Clientes.Add(cliente);
            ctx.SaveChanges();
        }
        public void Modificar(int clienteId, string nombre, string apellido, decimal descuentoDecimal)
        {
            using var ctx = new ContextoVentas();

            var cliente = ctx.Clientes.FirstOrDefault(c => c.ClienteId == clienteId);
            if (cliente == null) throw new Exception("Cliente no encontrado.");

            cliente.Nombre = nombre;
            cliente.Apellido = apellido;

            if (cliente is Mayorista may)
                may.Descuento = descuentoDecimal;
            else if (cliente is Minorista min)
                min.Descuento = descuentoDecimal;

            ctx.SaveChanges();
        }

        public void Modificar(Cliente cliente)
        {
            context.Clientes.Update(cliente);
            context.SaveChanges();
        }

        public void Eliminar(int clienteId)
        {
            using var ctx = new ContextoVentas();

            var cliente = ctx.Clientes.FirstOrDefault(c => c.ClienteId == clienteId);
            if (cliente == null) return;

            ctx.Clientes.Remove(cliente);

            try
            {
                ctx.SaveChanges();
            }
            catch (DbUpdateException)
            {
                throw new Exception("No se puede eliminar el cliente porque tiene ventas asociadas.");
            }
        }

        public Cliente? ObtenerPorId(int id)
        {
            return context.Clientes.Find(id);
        }

        public decimal ObtenerTotalCuentaCorriente()
        {
            return context.Clientes
                          .OfType<Mayorista>()   // solo mayoristas
                          .Sum(m => m.MontoDebe);
        }

    }
}
