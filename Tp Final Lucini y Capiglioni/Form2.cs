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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ConfigurarGrilla();
            CargarProductos();
        }

        // --------- Configuración de grilla ---------
        private void ConfigurarGrilla()
        {
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.Columns.Clear();

            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.MultiSelect = false;

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Codigo",
                HeaderText = "Código"
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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
                DataPropertyName = "StockTotal",
                HeaderText = "Stock total"
            });
        }

        private void CargarProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = ControladoraProductos.Instancia.ListarProductos();
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCategoria.Clear();
            nudPrecio.Value = 0;
            nudCantidad.Value = 0;
        }

        private Producto? ProductoSeleccionado =>
            dgvProductos.CurrentRow?.DataBoundItem as Producto;

        // Cuando cambia la selección, cargo los datos en los controles
        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            var prod = ProductoSeleccionado;
            if (prod == null) return;

            txtCodigo.Text = prod.Codigo.ToString();
            txtNombre.Text = prod.Nombre;
            txtDescripcion.Text = prod.Descripcion;
            txtCategoria.Text = prod.Categoria;
            nudPrecio.Value = prod.Precio;
            nudCantidad.Value = prod.StockTotal;
        }

        // --------- Botón Agregar ---------
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigo.Text);

                var mensaje = ControladoraProductos.Instancia.AgregarProducto(
                    codigo,
                    txtNombre.Text,
                    txtDescripcion.Text,
                    txtCategoria.Text,
                    nudPrecio.Value,
                    (int)nudCantidad.Value
                );

                MessageBox.Show(mensaje, "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --------- Botón Modificar ---------
        private void btnModificar_Click(object sender, EventArgs e)
        {
            var prod = ProductoSeleccionado;
            if (prod == null)
            {
                MessageBox.Show("Seleccione un producto.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int codigo = int.Parse(txtCodigo.Text);

                var mensaje = ControladoraProductos.Instancia.ModificarProducto(
                    prod.ProductoId,
                    codigo,
                    txtNombre.Text,
                    txtDescripcion.Text,
                    txtCategoria.Text,
                    nudPrecio.Value,
                    (int)nudCantidad.Value
                );

                MessageBox.Show(mensaje, "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al modificar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --------- Botón Eliminar ---------
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var prod = ProductoSeleccionado;
            if (prod == null)
            {
                MessageBox.Show("Seleccione un producto.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Seguro que desea eliminar el producto?",
                    "Confirmar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                var mensaje = ControladoraProductos.Instancia.EliminarProducto(prod.ProductoId);

                MessageBox.Show(mensaje, "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
