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
            dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendedores.Location = new Point(36, 75);
            dgvVendedores.Margin = new Padding(3, 4, 3, 4);
            dgvVendedores.Name = "dgvVendedores";
            dgvVendedores.RowHeadersWidth = 51;
            dgvVendedores.Size = new Size(426, 369);
            dgvVendedores.TabIndex = 0;
            dgvVendedores.CellClick += dgvVendedores_CellClick;
            dgvVendedores.CellContentClick += dgvVendedores_CellContentClick;
            // 
            // lblVendedores
            // 
            lblVendedores.AutoSize = true;
            lblVendedores.Location = new Point(36, 41);
            lblVendedores.Name = "lblVendedores";
            lblVendedores.Size = new Size(87, 20);
            lblVendedores.TabIndex = 1;
            lblVendedores.Text = "Vendedores";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(531, 69);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(531, 156);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(531, 93);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(531, 180);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(114, 27);
            txtApellido.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(723, 88);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 39);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(723, 175);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(114, 39);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(723, 259);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 39);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cbSucursal
            // 
            cbSucursal.FormattingEnabled = true;
            cbSucursal.Location = new Point(531, 267);
            cbSucursal.Margin = new Padding(3, 4, 3, 4);
            cbSucursal.Name = "cbSucursal";
            cbSucursal.Size = new Size(138, 28);
            cbSucursal.TabIndex = 9;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Location = new Point(531, 243);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(63, 20);
            lblSucursal.TabIndex = 10;
            lblSucursal.Text = "Sucursal";
            // 
            // cbSucursalesFiltro
            // 
            cbSucursalesFiltro.FormattingEnabled = true;
            cbSucursalesFiltro.Location = new Point(531, 344);
            cbSucursalesFiltro.Name = "cbSucursalesFiltro";
            cbSucursalesFiltro.Size = new Size(138, 28);
            cbSucursalesFiltro.TabIndex = 11;
            // 
            // btnMostrarXsucursal
            // 
            btnMostrarXsucursal.Location = new Point(723, 332);
            btnMostrarXsucursal.Margin = new Padding(3, 4, 3, 4);
            btnMostrarXsucursal.Name = "btnMostrarXsucursal";
            btnMostrarXsucursal.Size = new Size(114, 50);
            btnMostrarXsucursal.TabIndex = 12;
            btnMostrarXsucursal.Text = "Mostrar Por Sucursal";
            btnMostrarXsucursal.UseVisualStyleBackColor = true;
            btnMostrarXsucursal.Click += btnMostrarVendedores_Click;
            // 
            // lblFScursales
            // 
            lblFScursales.AutoSize = true;
            lblFScursales.Location = new Point(534, 321);
            lblFScursales.Name = "lblFScursales";
            lblFScursales.Size = new Size(104, 20);
            lblFScursales.TabIndex = 13;
            lblFScursales.Text = "Filtro Sucursal:";
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Location = new Point(723, 405);
            btnMostrarTodos.Margin = new Padding(3, 4, 3, 4);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(114, 39);
            btnMostrarTodos.TabIndex = 14;
            btnMostrarTodos.Text = "Mostrar todos";
            btnMostrarTodos.UseVisualStyleBackColor = true;
            btnMostrarTodos.Click += btnMostrarTodos_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 508);
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
            Margin = new Padding(3, 4, 3, 4);
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