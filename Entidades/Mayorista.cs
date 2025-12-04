using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mayorista : Cliente
    {
        public decimal Descuento { get; set; } = 0.10m;
        public EstadoDeCuenta EstadoCuenta { get; set; } = EstadoDeCuenta.AlDia;
    }
}
