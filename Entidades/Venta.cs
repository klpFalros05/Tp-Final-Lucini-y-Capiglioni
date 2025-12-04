using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public MetodoPago MetodoPago { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; } = null!;
        public int SucursalId { get; set; }
        public Sucursal Sucursal { get; set; } = null!;
        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; } = null!;

        public List<DetalleVenta> Detalles { get; set; } = new();
    }
    public enum MetodoPago
    {
        Efectivo = 0,
        Tarjeta = 1,
        Transferencia = 2
    }
}
