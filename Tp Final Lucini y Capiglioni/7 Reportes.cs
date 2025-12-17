using Controladora;
using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tp_Final_Lucini_y_Capiglioni
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            dgvResultados.AutoGenerateColumns = true;   
            CargarCombos();
            LimpiarFiltrosUI();
        }

        private void CargarCombos()
        {
            cmbTipoReporte.Items.Clear();
            cmbTipoReporte.Items.Add("Ventas");
            cmbTipoReporte.SelectedIndex = 0;

            
            var sucursales = ControladoraSucursales.Instancia.Listar();
            cmbSucursal.DataSource = sucursales;
            cmbSucursal.DisplayMember = "NombreSucursal";
            cmbSucursal.ValueMember = "SucursalId";
            cmbSucursal.SelectedIndex = -1;

           
            var clientes = ControladoraClientes.Instancia.ListarTodosParaGrilla();
            var datosClientes = clientes
                .Select(c => new
                {
                    Id = c.ClienteId,
                    Nombre = c.Nombre + " " + c.Apellido
                })
                .ToList();

            cmbCliente.DataSource = datosClientes;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Id";
            cmbCliente.SelectedIndex = -1;
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbMetodoPago.DataSource = Enum.GetValues(typeof(MetodoPago));
            cmbMetodoPago.SelectedIndex = -1;
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbVendedor.DataSource = null;
           
            var repoProd = new RepositorioProductos();
            var productos = repoProd.Listar();

            var datosProd = productos
                .Select(p => new
                {
                    Id = p.ProductoId,
                    Nombre = p.Nombre
                })
                .ToList();

            cmbProducto.DataSource = datosProd;
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "Id";
            cmbProducto.SelectedIndex = -1;
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSucursal.SelectedValue is int sucursalId)
            {
                var vendedores = ControladoraVendedores
                                    .Instancia
                                    .ListarPorSucursalParaGrilla(sucursalId);

                var datosVend = vendedores
                    .Select(v => new
                    {
                        Id = v.VendedorId,
                        Nombre = v.Nombre + " " + v.Apellido
                    })
                    .ToList();

                cmbVendedor.DataSource = datosVend;
                cmbVendedor.DisplayMember = "Nombre";
                cmbVendedor.ValueMember = "Id";
                cmbVendedor.SelectedIndex = -1;
                cmbVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                cmbVendedor.DataSource = null;
            }
        }

        private void LimpiarFiltrosUI()
        {
            cmbTipoReporte.SelectedIndex = 0;     
            cmbSucursal.SelectedIndex = -1;
            cmbCliente.SelectedIndex = -1;
            cmbVendedor.DataSource = null;
            cmbMetodoPago.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;

            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
           
            dgvResultados.DataSource = null;
           
            txtCantVentas.Text = "0";
            txtTotalFacturado.Text = "0,00";
            txtTotalCuentaCorriente.Text = "0,00";
            txtTotalProductos.Text = "0";

            txtProductoMasVendido.Text = "";
            txtCantidadProductoMasVendido.Text = "0";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFiltrosUI();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime? desde = dtpDesde.Value.Date;
            DateTime? hasta = dtpHasta.Value.Date;

            int? sucursalId = cmbSucursal.SelectedValue is int s ? s : (int?)null;
            int? clienteId = cmbCliente.SelectedValue is int c ? c : (int?)null;
            int? vendedorId = cmbVendedor.SelectedValue is int v ? v : (int?)null;
            MetodoPago? metodo = cmbMetodoPago.SelectedItem is MetodoPago mp
                                 ? mp
                                 : (MetodoPago?)null;

            var ventas = ControladoraReportes.Instancia.ObtenerVentas(
                desde,
                hasta,
                sucursalId,
                clienteId,
                vendedorId,
                metodo
            );

            int? productoId = null;
            if (cmbProducto.SelectedValue is int p)
                productoId = p;

            if (productoId.HasValue)
            {
                ventas = ventas
                    .Where(v => v.Detalles.Any(d => d.ProductoId == productoId.Value))
                    .ToList();
            }

            var filas = ventas.Select(v => new
            {
                Fecha = v.Fecha.ToShortDateString(),
                Sucursal = v.Sucursal.NombreSucursal,
                Cliente = v.Cliente.Nombre + " " + v.Cliente.Apellido,
                Vendedor = v.Vendedor.Nombre + " " + v.Vendedor.Apellido,
                MetodoDePago = v.MetodoPago.ToString(),
                Total = v.Total,
                Productos = v.Detalles.Sum(d => d.Cantidad)
            }).ToList();

            dgvResultados.DataSource = null;
            dgvResultados.DataSource = filas;

            var tot = ControladoraReportes.Instancia.CalcularTotales(ventas);

            txtCantVentas.Text = tot.CantidadVentas.ToString();
            txtTotalFacturado.Text = tot.TotalFacturado.ToString("N2");
            txtTotalCuentaCorriente.Text = tot.TotalCuentaCorriente.ToString("N2");
            txtTotalProductos.Text = tot.TotalProductosVendidos.ToString();

            var infoProd = ControladoraReportes.Instancia.ObtenerProductoMasVendido(ventas);

            if (infoProd.Producto == null)
            {
                txtProductoMasVendido.Text = "–";
                txtCantidadProductoMasVendido.Text = "0";
            }
            else
            {
                txtProductoMasVendido.Text = infoProd.Producto.Nombre;
                txtCantidadProductoMasVendido.Text = infoProd.CantidadTotal.ToString();
            }

        }

        private void cmbSucursal_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbSucursal.SelectedIndexChanged += cmbSucursal_SelectedIndexChanged;
        }
    }



}
