using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora.Dtos
{
    public class VendedorDto
    {
        public int VendedorId { get; set; }
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public int SucursalId { get; set; }
        public string Sucursal { get; set; } = "";
    }
}
