using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Modelo;

namespace Controladora
{
    public class ControladoraReportes
    {
        private static ControladoraReportes instancia;
        public static ControladoraReportes Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ControladoraReportes();
                return instancia;
            }
        }

        private readonly RepositorioVentas repoVentas = new RepositorioVentas();
        private readonly RepositorioClientes repoClientes = new RepositorioClientes();

        private ControladoraReportes() { }

        //devuelve la lista de ventas segun los filtros que le pasemos 
        public List<Venta> ObtenerVentas(DateTime? desde,DateTime? hasta,int? sucursalId,int? clienteId,int? vendedorId,
            MetodoPago? metodoPago)
        {
            return repoVentas.ListarFiltrado(desde, hasta, sucursalId, clienteId, vendedorId, metodoPago);
        }

        public (int CantidadVentas,decimal TotalFacturado,decimal TotalCuentaCorriente,int TotalProductosVendidos)
            CalcularTotales(List<Venta> ventas)
        {
            int cantVentas = ventas.Count;

            decimal totalFacturado = ventas.Sum(v => v.Total);

            int totalProductos = ventas
                .SelectMany(v => v.Detalles)
                .Sum(d => d.Cantidad);

            decimal totalCC = repoClientes.ObtenerTotalCuentaCorriente();

            return (cantVentas, totalFacturado, totalCC, totalProductos);
        }

        public (Producto? Producto, int CantidadTotal, decimal ImporteTotal) 
            ObtenerProductoMasVendido(List<Venta> ventas)
        {
            if (ventas == null || ventas.Count == 0)
                return (null, 0, 0m);

            // agrupamos por Producto y sumamos cantidades e importes
            var dato = ventas
                .SelectMany(v => v.Detalles)              
                .GroupBy(d => d.Producto)           
                .Select(g => new
                {
                    Producto = g.Key,
                    Cantidad = g.Sum(x => x.Cantidad),
                    Importe = g.Sum(x => x.Subtotal)
                })
                .OrderByDescending(x => x.Cantidad)       // quedaria el que mas se vendio primero
                .FirstOrDefault();

            if (dato == null)
                return (null, 0, 0m);

            return (dato.Producto, dato.Cantidad, dato.Importe);
        }







    }
}
