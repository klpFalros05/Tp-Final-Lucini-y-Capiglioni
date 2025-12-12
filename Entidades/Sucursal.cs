using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        public int SucursalId { get; set; }
        public string NombreSucursal { get; set; } = string.Empty;

        /// una sucursal tiene muchos stocks
        public List<Stock> Stocks { get; set; } = new();
    }
}
