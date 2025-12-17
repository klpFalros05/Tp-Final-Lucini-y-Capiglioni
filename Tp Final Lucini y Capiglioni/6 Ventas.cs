using Controladora;
using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tp_Final_Lucini_y_Capiglioni
{
    public partial class Form4 : Form
    {
        private readonly BindingList<DetalleVenta> carrito = new BindingList<DetalleVenta>();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CargaDGV();

            CargarSucursales();
            CargarClientes();
            CargarVendedores();
            CargarMetodosPago();

            cmbCuandoPaga.Items.Clear();
            cmbCuandoPaga.Items.Add("Paga ahora");
            cmbCuandoPaga.Items.Add("Cuenta corriente");
            cmbCuandoPaga.SelectedIndex = 0;

            dgvCarrito.DataSource = carrito;

            cmbCliente_SelectedIndexChanged_1(null, EventArgs.Empty);
        }

        private void CargaDGV()
        {
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.Columns.Clear();
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.MultiSelect = false;

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id"
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Codigo",
                HeaderText = "Código"
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre"
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descripcion",
                HeaderText = "Descripción",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Categoria",
                HeaderText = "Categoría"
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                DefaultCellStyle = { Format = "N2" }
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StockSucursal",
                HeaderText = "Stock sucursal"
            });

            dgvCarrito.AutoGenerateColumns = false;
            dgvCarrito.Columns.Clear();
            dgvCarrito.ReadOnly = true;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.MultiSelect = false;

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductoId",
                HeaderText = "Id"
            });
            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreProducto",
                HeaderText = "Producto",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad"
            });
            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Subtotal",
                HeaderText = "Subtotal",
                DefaultCellStyle = { Format = "N2" }
            });
        }

        private void CargarSucursales()
        {
            var repoSuc = new RepositorioSucursales();
            var lista = repoSuc.Listar();

            cmbSucursal.DataSource = lista;
            cmbSucursal.DisplayMember = "NombreSucursal";
            cmbSucursal.ValueMember = "SucursalId";
            cmbSucursal.SelectedIndex = -1;

            dgvProductos.DataSource = null;
        }

        private void CargarClientes()
        {
            var clientes = ControladoraClientes.Instancia.ListarTodosParaGrilla();

            var datos = clientes.Select(c => new
            {
                Id = c.ClienteId,
                Nombre = c.Nombre + " " + c.Apellido
            }).ToList();

            cmbCliente.DataSource = datos;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Id";
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarVendedores()
        {
            if (cmbSucursal.SelectedValue is not int sucursalId)
                return;

            var vendedores = ControladoraVendedores.Instancia.ListarPorSucursalParaGrilla(sucursalId);

            var datos = vendedores.Select(v => new
            {
                Id = v.VendedorId,
                Nombre = v.Nombre + " " + v.Apellido
            }).ToList();

            cmbVendedor.DataSource = datos;
            cmbVendedor.DisplayMember = "Nombre";
            cmbVendedor.ValueMember = "Id";
            cmbVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarMetodosPago()
        {
            cmbMetodoDePago.DataSource = Enum.GetValues(typeof(MetodoPago));
            cmbMetodoDePago.SelectedIndex = 0;
        }

        private void CargarProductosSucursal(int sucursalId)
        {
            var repoStock = new RepositorioStockPorSucursal();
            var listaStock = repoStock.ListarPorSucursal(sucursalId);

            var datos = listaStock.Select(s =>
            {
                int reservado = carrito
                    .Where(d => d.ProductoId == s.ProductoId)
                    .Sum(d => d.Cantidad);

                
                int disponible = s.Cantidad - reservado;
                if (disponible < 0) disponible = 0;

                return new
                {
                    
                    Id = s.ProductoId,
                    Codigo = s.Producto.Codigo,
                    Nombre = s.Producto.Nombre,
                    Descripcion = s.Producto.Descripcion,
                    Categoria = s.Producto.Categoria,
                    Precio = s.Producto.Precio,
                    StockSucursal = disponible
                };
            }).ToList();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = datos;
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSucursal.SelectedValue is int sucursalId)
            {
                CargarProductosSucursal(sucursalId);
                CargarVendedores();
            }
        }

        private dynamic? ProductoSucursalSeleccionado =>
            dgvProductos.CurrentRow?.DataBoundItem;

        private void dgvProductos_SelectionChanged_1(object sender, EventArgs e)
        {
            var item = ProductoSucursalSeleccionado;
            if (item != null)
            {
                txtNombre.Text = (string)item.Nombre;
                txtPrecioUnitario.Text = ((decimal)item.Precio).ToString("N2");
            }
        }

        private void RefrescarProductosSucursal()
        {
            if (cmbSucursal.SelectedValue is int sucursalId)
            {
                CargarProductosSucursal(sucursalId);
            }
        }

        private void btnAgregarAlCarrito_Click_1(object sender, EventArgs e)
        {
            var item = ProductoSucursalSeleccionado;
            if (item == null)
            {
                MessageBox.Show("Seleccione un producto de la sucursal.");
                return;
            }

            int cantidad = (int)nudCantidad.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.");
                return;
            }

            int stockDisponible = (int)item.StockSucursal;
            if (cantidad > stockDisponible)
            {
                MessageBox.Show("No hay stock suficiente en la sucursal.");
                return;
            }

            int productoId = (int)item.Id;
            string nombre = (string)item.Nombre;
            decimal precio = (decimal)item.Precio;
            decimal subtotal = cantidad * precio;

            var existente = carrito.FirstOrDefault(d => d.ProductoId == productoId);
            if (existente != null)
            {
                existente.Cantidad += cantidad;
                existente.Subtotal += subtotal;
            }
            else
            {
                carrito.Add(new DetalleVenta
                {
                    ProductoId = productoId,
                    Producto = new Producto { ProductoId = productoId, Nombre = nombre, Precio = precio },
                    Cantidad = cantidad,
                    Subtotal = subtotal
                });
            }

            ActualizarTotales();
            RefrescarProductosSucursal();
        }

        private void btnEliminarDelCarrito_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow?.DataBoundItem is DetalleVenta det)
            {
                carrito.Remove(det);
                ActualizarTotales();
                RefrescarProductosSucursal();
            }
        }

        private void btnVaciarCarrito_Click(object sender, EventArgs e)
        {
            carrito.Clear();
            ActualizarTotales();
            RefrescarProductosSucursal();
        }

        private void ActualizarTotales()
        {
            if (cmbCliente.SelectedValue is not int idCliente)
            {
                lblSubTotal.Text = "0";
                lblDescuento.Text = "0";
                lblTotal.Text = "0";
                return;
            }

            var datos = ControladoraVentas.Instancia
                          .CalcularTotales(idCliente, carrito.ToList());

            lblSubTotal.Text = datos.Subtotal.ToString("N2");
            lblDescuento.Text = datos.Descuento.ToString("N2");
            lblTotal.Text = datos.Total.ToString("N2");
        }

        private void cmbCliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ActualizarTotales();

            if (cmbCuandoPaga.Items.Count == 0)
                return;

            if (cmbCliente.SelectedValue is int idCliente)
            {
                var cliente = ControladoraClientes.Instancia.ObtenerPorId(idCliente);

                if (cliente is Mayorista)
                {
                    // Mayorista: puede elegir cómo paga
                    cmbCuandoPaga.Enabled = true;
                }
                else
                {
                    // Minorista: siempre paga ahora
                    if (cmbCuandoPaga.Items.Count > 0)
                        cmbCuandoPaga.SelectedIndex = 0;

                    cmbCuandoPaga.Enabled = false;
                }
            }
            else
            {
                if (cmbCuandoPaga.Items.Count > 0)
                    cmbCuandoPaga.SelectedIndex = 0;

                cmbCuandoPaga.Enabled = false;
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                return;
            }

            if (cmbSucursal.SelectedValue is not int sucursalId ||
                cmbCliente.SelectedValue is not int idCliente ||
                cmbVendedor.SelectedValue is not int vendedorId ||
                cmbMetodoDePago.SelectedItem == null ||
                cmbCuandoPaga.SelectedItem == null)
            {
                MessageBox.Show("Complete todos los datos de la venta.");
                return;
            }

            var metodoPago = (MetodoPago)cmbMetodoDePago.SelectedItem;
            bool pagaAhora;

            var cliente = ControladoraClientes.Instancia.ObtenerPorId(idCliente);

            if (cliente is Mayorista)
            {
                pagaAhora = (cmbCuandoPaga.SelectedIndex == 0);
            }
            else
            {
                pagaAhora = true;
            }

            try
            {
                var msg = ControladoraVentas.Instancia.RegistrarVenta(
                    sucursalId,
                    idCliente,
                    vendedorId,
                    metodoPago,
                    dtpFecha.Value,
                    pagaAhora,
                    carrito.ToList()
                );

                MessageBox.Show(msg, "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                carrito.Clear();
                ActualizarTotales();
                CargarProductosSucursal(sucursalId); 
            }
            catch (Exception ex)
            {
                string mensaje = ex.InnerException?.Message ?? ex.Message;

                MessageBox.Show(mensaje,
                    "Error al registrar venta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito para generar la factura.",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (cmbSucursal.SelectedItem == null ||
                cmbCliente.SelectedValue == null ||
                cmbVendedor.SelectedValue == null ||
                cmbMetodoDePago.SelectedItem == null)
            {
                MessageBox.Show("Complete los datos de la venta antes de generar la factura.",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var sucursal = (Sucursal)cmbSucursal.SelectedItem;
            string nombreSucursal = sucursal.NombreSucursal;

            string nombreCliente = cmbCliente.Text;    
            string nombreVendedor = cmbVendedor.Text;  
            var metodoPago = (MetodoPago)cmbMetodoDePago.SelectedItem;
            DateTime fecha = dtpFecha.Value;

            int idCliente = (int)cmbCliente.SelectedValue;

           
            var totales = ControladoraVentas.Instancia
                            .CalcularTotales(idCliente, carrito.ToList());

            
            decimal porcentajeDesc = 0m;
            if (totales.Subtotal > 0)
                porcentajeDesc = (totales.Descuento / totales.Subtotal) * 100m;

           
            var sb = new StringBuilder();

            sb.AppendLine("************* FACTURA *************");
            sb.AppendLine($"Fecha:    {fecha:dd/MM/yyyy HH:mm}");
            sb.AppendLine($"Sucursal: {nombreSucursal}");
            sb.AppendLine($"Cliente:  {nombreCliente}");
            sb.AppendLine($"Vendedor: {nombreVendedor}");
            sb.AppendLine($"Pago:     {metodoPago}");
            sb.AppendLine("-----------------------------------");
            sb.AppendLine("Cant  Producto           P.Unit  Subtotal");

            foreach (var det in carrito)
            {
                string nom = det.Producto?.Nombre ?? "";
                decimal precioUnit = det.Producto?.Precio ?? 0m;

                sb.AppendLine(
                    $"{det.Cantidad,4}  " +
                    $"{nom,-15} " +
                    $"{precioUnit,7:N2}  " +
                    $"{det.Subtotal,8:N2}"
                );
            }

            sb.AppendLine("-----------------------------------");
            sb.AppendLine($"Subtotal:       {totales.Subtotal:N2}");
            sb.AppendLine($"Descuento ({porcentajeDesc:N0}%): {totales.Descuento:N2}");
            sb.AppendLine($"TOTAL:          {totales.Total:N2}");
            sb.AppendLine("***********************************");

            string textoFactura = sb.ToString();

            
            MessageBox.Show(sb.ToString(),
                            "Factura",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            var respuesta = MessageBox.Show("¿Desea guardar la factura como archivo de texto?",
                                   "Guardar factura",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                using (var dialog = new SaveFileDialog())
                {
                    dialog.Title = "Guardar factura";
                    dialog.Filter = "Archivo de texto (*.txt)|*.txt";
                    dialog.FileName = $"Factura_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                    dialog.InitialDirectory = Environment.GetFolderPath(
                                                Environment.SpecialFolder.MyDocuments);

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(dialog.FileName, textoFactura, Encoding.UTF8);

                        MessageBox.Show("Factura guardada en:\n" + dialog.FileName,
                                        "Factura guardada",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }

                }
            }
        }
    }
}