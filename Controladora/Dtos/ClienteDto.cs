using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora.Dtos
{
    public class ClienteDto
    {
        public int ClienteId { get; set; }
        public string Tipo { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public decimal DescuentoPorcentaje { get; set; }  // 0..100
        public string EstadoCuenta { get; set; } = "";    // solo mayorista
        public decimal MontoDebe { get; set; }            // solo mayorista
    }
}
