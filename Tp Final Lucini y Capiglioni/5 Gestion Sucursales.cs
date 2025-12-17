using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_Final_Lucini_y_Capiglioni
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load_1(object sender, EventArgs e)
        {
            ConfigurarGrillas();
            CargarSucursales();
            CargarProductos();
            CargarCombosSucursales();
        }

        // Cargas iniciales
        private void ConfigurarGrillas()
        {
            // Grilla de productos (stock general)
            dgvProductosStock.AutoGenerateColumns = false;
            dgvProductosStock.Columns.Clear();

            dgvProductosStock.ReadOnly = true;
            dgvProductosStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductosStock.MultiSelect = false;

            dgvProductosStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Codigo",
                HeaderText = "Código"
            });
            dgvProductosStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvProductosStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Categoria",
                HeaderText = "Categoría"
            });
            dgvProductosStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                DefaultCellStyle = { Format = "N2" }
            });
            dgvProductosStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StockTotal",
                HeaderText = "Stock total"
            });

            // Grilla de stock por sucursal
            dgvStockPorSucursal.AutoGenerateColumns = false;
            dgvStockPorSucursal.Columns.Clear();

            dgvStockPorSucursal.ReadOnly = true;
            dgvStockPorSucursal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStockPorSucursal.MultiSelect = false;

            dgvStockPorSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Sucursal",
                HeaderText = "Sucursal"
            });
            dgvStockPorSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Producto",
                HeaderText = "Producto",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvStockPorSucursal.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad"
            });
        }

        private void CargarSucursales()
        {
            var lista = ControladoraSucursales.Instancia.Listar();

            dgvSucursales.DataSource = null;
            dgvSucursales.DataSource = lista;
        }

        private void CargarProductos()
        {
            dgvProductosStock.DataSource = null;
            dgvProductosStock.DataSource = ControladoraProductos.Instancia.ListarProductos();
        }

        private void CargarCombosSucursales()
        {
            var lista = ControladoraSucursales.Instancia.Listar();

            // Para asignar stock
            cmbSucursalAsignar.DataSource = lista.ToList();
            cmbSucursalAsignar.DisplayMember = "NombreSucursal";
            cmbSucursalAsignar.ValueMember = "SucursalId";

            // Para ver stock por sucursal
            cmbSucursalVer.DataSource = lista.ToList();
            cmbSucursalVer.DisplayMember = "NombreSucursal";
            cmbSucursalVer.ValueMember = "SucursalId";
        }

        // Sucursales
        private Sucursal? SucursalSeleccionada =>
            dgvSucursales.CurrentRow?.DataBoundItem as Sucursal;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreSucursal.Text.Trim();

                var msg = ControladoraSucursales.Instancia.Agregar(nombre);
                MessageBox.Show(msg, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombreSucursal.Clear();
                CargarSucursales();
                CargarCombosSucursales();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar sucursal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var suc = SucursalSeleccionada;
            if (suc == null)
            {
                MessageBox.Show("Seleccione una sucursal.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Seguro que desea eliminar la sucursal?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                var msg = ControladoraSucursales.Instancia.Eliminar(suc.SucursalId);
                MessageBox.Show(msg, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarSucursales();
                CargarCombosSucursales();
                dgvStockPorSucursal.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar sucursal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Stock por sucursales
        private Producto? ProductoSeleccionado =>
            dgvProductosStock.CurrentRow?.DataBoundItem as Producto;

        private void btnAgregarStockSucursal_Click_2(object sender, EventArgs e)
        {
            var prod = ProductoSeleccionado;
            if (prod == null)
            {
                MessageBox.Show("Seleccione un producto.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSucursalAsignar.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una sucursal.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int sucursalId = (int)cmbSucursalAsignar.SelectedValue;
            int cantidad = (int)nudCantidadAsignar.Value;

            try
            {
                var msg = ControladoraStockPorSucursal.Instancia.AgregarStockASucursal(
                    sucursalId,
                    prod.ProductoId,
                    cantidad
                );

                MessageBox.Show(msg, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarStockPorSucursal(sucursalId); // grilla inferior
                CargarProductos();                  // grilla de stock general
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al asignar stock",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProductosPorSucursal_Click_1(object sender, EventArgs e)
        {
            if (cmbSucursalVer.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una sucursal.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int sucursalId = (int)cmbSucursalVer.SelectedValue;
            CargarStockPorSucursal(sucursalId);
        }

        private void CargarStockPorSucursal(int sucursalId)
        {
            var listaStock = ControladoraStockPorSucursal.Instancia.ListarPorSucursal(sucursalId);

            // Proyectamos a un tipo anónimo para mostrar nombres bonitos en la grilla
            var datos = listaStock.Select(s => new
            {
                Sucursal = s.Sucursal.NombreSucursal,
                Producto = s.Producto.Nombre,
                s.Cantidad
            }).ToList();

            dgvStockPorSucursal.DataSource = null;
            dgvStockPorSucursal.DataSource = datos;
        }

        private void cmbSucursalVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSucursalVer.SelectedValue is int sucursalId)
            {
                CargarStockPorSucursal(sucursalId);
            }
        }

    }
}
