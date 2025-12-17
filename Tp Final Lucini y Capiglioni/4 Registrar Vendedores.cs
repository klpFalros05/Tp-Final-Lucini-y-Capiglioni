using Controladora;
using Controladora.Dtos;
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
    public partial class Form6 : Form
    {
        private int idSeleccionado = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            CargarCombosSucursales();
            CargarGrilla();
            LimpiarCampos();
        }
        private void CargarCombosSucursales()
        {
            var sucursales = ControladoraVendedores.Instancia.ListarSucursales();

            cbSucursal.DataSource = sucursales.ToList();
            cbSucursal.DisplayMember = "NombreSucursal";
            cbSucursal.ValueMember = "SucursalId";
            cbSucursal.SelectedIndex = sucursales.Count > 0 ? 0 : -1;

            cbSucursalesFiltro.DataSource = sucursales.ToList();
            cbSucursalesFiltro.DisplayMember = "NombreSucursal";
            cbSucursalesFiltro.ValueMember = "SucursalId";
            cbSucursalesFiltro.SelectedIndex = sucursales.Count > 0 ? 0 : -1;
        }
        private void CargarGrilla()
        {
            dgvVendedores.DataSource = null;
            dgvVendedores.DataSource = ControladoraVendedores.Instancia.ListarTodosParaGrilla();
            AjustarGrilla();
        }

        private void CargarGrillaPorSucursal(int sucursalId)
        {
            dgvVendedores.DataSource = null;
            dgvVendedores.DataSource = ControladoraVendedores.Instancia.ListarPorSucursalParaGrilla(sucursalId);
            AjustarGrilla();
        }

        private void AjustarGrilla()
        {
            if (dgvVendedores.Columns["VendedorId"] != null)
                dgvVendedores.Columns["VendedorId"].Visible = false;

            if (dgvVendedores.Columns["SucursalId"] != null)
                dgvVendedores.Columns["SucursalId"].Visible = false;

        }

        private void LimpiarCampos()
        {
            idSeleccionado = 0;
            txtNombre.Text = "";
            txtApellido.Text = "";
            if (cbSucursal.Items.Count > 0) cbSucursal.SelectedIndex = 0;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSucursal.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná una sucursal.");
                    return;
                }

                int sucursalId = Convert.ToInt32(cbSucursal.SelectedValue);

                ControladoraVendedores.Instancia.Agregar(
                    txtNombre.Text,
                    txtApellido.Text,
                    sucursalId
                );

                CargarGrilla();
                LimpiarCampos();
                MessageBox.Show("Vendedor agregado correctamente.");
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
                if (idSeleccionado == 0)
                {
                    MessageBox.Show("Seleccioná un vendedor de la grilla.");
                    return;
                }

                if (cbSucursal.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná una sucursal.");
                    return;
                }

                int sucursalId = Convert.ToInt32(cbSucursal.SelectedValue);

                ControladoraVendedores.Instancia.Modificar(
                    idSeleccionado,
                    txtNombre.Text,
                    txtApellido.Text,
                    sucursalId
                );

                CargarGrilla();
                LimpiarCampos();
                MessageBox.Show("Vendedor modificado correctamente.");
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
                if (idSeleccionado == 0)
                {
                    MessageBox.Show("Seleccioná un vendedor de la grilla.");
                    return;
                }

                var r = MessageBox.Show("¿Seguro que querés eliminar este vendedor?", "Confirmar", MessageBoxButtons.YesNo);
                if (r != DialogResult.Yes) return;

                ControladoraVendedores.Instancia.Eliminar(idSeleccionado);

                CargarGrilla();
                LimpiarCampos();
                MessageBox.Show("Vendedor eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrarVendedores_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSucursalesFiltro.SelectedValue == null)
                {
                    MessageBox.Show("Seleccioná una sucursal para filtrar.");
                    return;
                }

                int sucursalId = Convert.ToInt32(cbSucursalesFiltro.SelectedValue);
                CargarGrillaPorSucursal(sucursalId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void dgvVendedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvVendedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dto = dgvVendedores.Rows[e.RowIndex].DataBoundItem as VendedorDto;
            if (dto == null) return;

            idSeleccionado = dto.VendedorId;

            txtNombre.Text = dto.Nombre;
            txtApellido.Text = dto.Apellido;

            // carga la sucursal en la combobox
            cbSucursal.SelectedValue = dto.SucursalId;
        }
    }
}
