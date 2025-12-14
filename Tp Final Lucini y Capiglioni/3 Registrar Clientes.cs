using Controladora;
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
    public partial class Form3 : Form
    {
        private int _idSeleccionado = 0;
        private string _filtroActual = "Todos"; // Todos / Mayoristas / Minoristas

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            cbTipoDeCliente.Items.Clear();
            cbTipoDeCliente.Items.Add("Minorista");
            cbTipoDeCliente.Items.Add("Mayorista");
            cbTipoDeCliente.SelectedIndex = 0;

            nudDescuento.Minimum = 0;
            nudDescuento.Maximum = 100;
            nudDescuento.DecimalPlaces = 2;

            lblDebe.Visible = false;
            txtMontoDebe.Visible = false;
            txtMontoDebe.Text = "0";

            CargarGrillaTodos();
            LimpiarFormulario();
        }
        private void LimpiarFormulario()
        {
            _idSeleccionado = 0;

            txtNombre.Text = "";
            txtApellido.Text = "";
            nudDescuento.Value = 0;

            cbTipoDeCliente.Enabled = true;
            cbTipoDeCliente.SelectedIndex = 0;

            lblDebe.Visible = false;
            txtMontoDebe.Visible = false;
            txtMontoDebe.Text = "0";
        }
        private void RefrescarManteniendoFiltro()
        {
            if (_filtroActual == "Mayoristas") CargarGrillaMayoristas();
            else if (_filtroActual == "Minoristas") CargarGrillaMinoristas();
            else CargarGrillaTodos();
        }
        private void CargarGrilla()
        {
            dgvClientes.DataSource = null;

            if (_filtroActual == "Mayoristas")
                dgvClientes.DataSource = Controladora.ControladoraClientes.Instancia.ListarMayoristasParaGrilla();
            else if (_filtroActual == "Minoristas")
                dgvClientes.DataSource = Controladora.ControladoraClientes.Instancia.ListarMinoristasParaGrilla();
            else
                dgvClientes.DataSource = Controladora.ControladoraClientes.Instancia.ListarTodosParaGrilla();

            AjustarGrilla();
        }
        private void cbTipoDeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoDeCliente.Text == "Mayorista")
            {
                lblDebe.Visible = true;
                txtMontoDebe.Visible = true;
            }
            else
            {
                lblDebe.Visible = false;
                txtMontoDebe.Visible = false;
                txtMontoDebe.Text = "0";
            }
        }

    
        private void CargarGrillaTodos()
        {
            _filtroActual = "Todos";
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Controladora.ControladoraClientes.Instancia.ListarTodosParaGrilla();
            AjustarGrilla();
        }

        private void CargarGrillaMayoristas()
        {
            _filtroActual = "Mayoristas";
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Controladora.ControladoraClientes.Instancia.ListarMayoristasParaGrilla();
            AjustarGrilla();
        }

        private void CargarGrillaMinoristas()
        {
            _filtroActual = "Minoristas";
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Controladora.ControladoraClientes.Instancia.ListarMinoristasParaGrilla();
            AjustarGrilla();
        }

        private void AjustarGrilla()
        {
            if (dgvClientes.Columns["ClienteId"] != null)
                dgvClientes.Columns["ClienteId"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Controladora.ControladoraClientes.Instancia.Agregar(
                    cbTipoDeCliente.Text,
                    txtNombre.Text,
                    txtApellido.Text,
                    nudDescuento.Value
                );

                RefrescarManteniendoFiltro();
                LimpiarFormulario();
                MessageBox.Show("Cliente agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idSeleccionado == 0)
                {
                    MessageBox.Show("Seleccioná un cliente de la grilla para modificar.");
                    return;
                }

                Controladora.ControladoraClientes.Instancia.Modificar(
                    _idSeleccionado,
                    txtNombre.Text,
                    txtApellido.Text,
                    nudDescuento.Value
                );

                RefrescarManteniendoFiltro();
                LimpiarFormulario();
                MessageBox.Show("Cliente modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idSeleccionado == 0)
                {
                    MessageBox.Show("Seleccioná un cliente de la grilla para eliminar.");
                    return;
                }

                var r = MessageBox.Show("¿Seguro que querés eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo);
                if (r != DialogResult.Yes) return;

                Controladora.ControladoraClientes.Instancia.Eliminar(_idSeleccionado);

                RefrescarManteniendoFiltro();
                LimpiarFormulario();
                MessageBox.Show("Cliente eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTodosClientes_Click(object sender, EventArgs e)
        {
            _filtroActual = "Todos";
            CargarGrilla();
        }

        private void btnMayoristas_Click(object sender, EventArgs e)
        {
            _filtroActual = "Mayoristas";
            CargarGrilla();

        }

        private void btnMinoristas_Click(object sender, EventArgs e)
        {
            _filtroActual = "Minoristas";
            CargarGrilla();
        }

        private void dgvClientes_Click(object sender, EventArgs e)
        {
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvClientes.Rows[e.RowIndex];

            _idSeleccionado = Convert.ToInt32(fila.Cells["ClienteId"].Value);

            txtNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? "";
            txtApellido.Text = fila.Cells["Apellido"].Value?.ToString() ?? "";

            cbTipoDeCliente.Text = fila.Cells["Tipo"].Value?.ToString() ?? "Minorista";
            cbTipoDeCliente.Enabled = false;

            nudDescuento.Value = Convert.ToDecimal(fila.Cells["DescuentoPorcentaje"].Value);

            if (cbTipoDeCliente.Text == "Mayorista")
            {
                lblDebe.Visible = true;
                txtMontoDebe.Visible = true;
                txtMontoDebe.Text = fila.Cells["MontoDebe"].Value?.ToString() ?? "0";
            }
            else
            {
                lblDebe.Visible = false;
                txtMontoDebe.Visible = false;
                txtMontoDebe.Text = "0";
            }
        }
    }
}
