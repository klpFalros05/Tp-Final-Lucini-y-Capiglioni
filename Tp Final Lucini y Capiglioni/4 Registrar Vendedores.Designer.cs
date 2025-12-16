namespace Tp_Final_Lucini_y_Capiglioni
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvVendedores = new DataGridView();
            lblVendedores = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            cbSucursal = new ComboBox();
            lblSucursal = new Label();
            cbSucursalesFiltro = new ComboBox();
            btnMostrarXsucursal = new Button();
            lblFScursales = new Label();
            btnMostrarTodos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).BeginInit();
            SuspendLayout();
            // 
            // dgvVendedores
            // 
            dgvVendedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendedores.Location = new Point(32, 56);
            dgvVendedores.Name = "dgvVendedores";
            dgvVendedores.RowHeadersWidth = 51;
            dgvVendedores.Size = new Size(373, 277);
            dgvVendedores.TabIndex = 0;
            dgvVendedores.CellClick += dgvVendedores_CellClick;
            dgvVendedores.CellContentClick += dgvVendedores_CellContentClick;
            // 
            // lblVendedores
            // 
            lblVendedores.AutoSize = true;
            lblVendedores.Location = new Point(32, 31);
            lblVendedores.Name = "lblVendedores";
            lblVendedores.Size = new Size(68, 15);
            lblVendedores.TabIndex = 1;
            lblVendedores.Text = "Vendedores";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(465, 52);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(465, 117);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(465, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(465, 135);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(633, 66);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 29);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(633, 131);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 29);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(633, 194);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 29);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cbSucursal
            // 
            cbSucursal.FormattingEnabled = true;
            cbSucursal.Location = new Point(465, 200);
            cbSucursal.Name = "cbSucursal";
            cbSucursal.Size = new Size(121, 23);
            cbSucursal.TabIndex = 9;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Location = new Point(465, 182);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(51, 15);
            lblSucursal.TabIndex = 10;
            lblSucursal.Text = "Sucursal";
            // 
            // cbSucursalesFiltro
            // 
            cbSucursalesFiltro.FormattingEnabled = true;
            cbSucursalesFiltro.Location = new Point(465, 258);
            cbSucursalesFiltro.Margin = new Padding(3, 2, 3, 2);
            cbSucursalesFiltro.Name = "cbSucursalesFiltro";
            cbSucursalesFiltro.Size = new Size(121, 23);
            cbSucursalesFiltro.TabIndex = 11;
            // 
            // btnMostrarXsucursal
            // 
            btnMostrarXsucursal.Location = new Point(633, 249);
            btnMostrarXsucursal.Name = "btnMostrarXsucursal";
            btnMostrarXsucursal.Size = new Size(100, 38);
            btnMostrarXsucursal.TabIndex = 12;
            btnMostrarXsucursal.Text = "Mostrar Por Sucursal";
            btnMostrarXsucursal.UseVisualStyleBackColor = true;
            btnMostrarXsucursal.Click += btnMostrarVendedores_Click;
            // 
            // lblFScursales
            // 
            lblFScursales.AutoSize = true;
            lblFScursales.Location = new Point(467, 241);
            lblFScursales.Name = "lblFScursales";
            lblFScursales.Size = new Size(84, 15);
            lblFScursales.TabIndex = 13;
            lblFScursales.Text = "Filtro Sucursal:";
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Location = new Point(633, 304);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(100, 29);
            btnMostrarTodos.TabIndex = 14;
            btnMostrarTodos.Text = "Mostrar todos";
            btnMostrarTodos.UseVisualStyleBackColor = true;
            btnMostrarTodos.Click += btnMostrarTodos_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 381);
            Controls.Add(btnMostrarTodos);
            Controls.Add(lblFScursales);
            Controls.Add(btnMostrarXsucursal);
            Controls.Add(cbSucursalesFiltro);
            Controls.Add(lblSucursal);
            Controls.Add(cbSucursal);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblVendedores);
            Controls.Add(dgvVendedores);
            Name = "Form6";
            Text = "Registrar Vendedores";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVendedores;
        private Label lblVendedores;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private ComboBox cbSucursal;
        private Label lblSucursal;
        private ComboBox cbSucursalesFiltro;
        private Button btnMostrarXsucursal;
        private Label lblFScursales;
        private Button btnMostrarTodos;
    }
}