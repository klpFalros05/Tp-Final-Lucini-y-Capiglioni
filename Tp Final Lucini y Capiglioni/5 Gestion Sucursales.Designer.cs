namespace Tp_Final_Lucini_y_Capiglioni
{
    partial class Form5
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
            dgvSucursales = new DataGridView();
            lblSucursales = new Label();
            txtNombreSucursal = new TextBox();
            lblNombre = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            dgvProductosStock = new DataGridView();
            lblStockDeProductos = new Label();
            dgvStockPorSucursal = new DataGridView();
            cmbSucursalAsignar = new ComboBox();
            lblStockPorSucursal = new Label();
            nudCantidadAsignar = new NumericUpDown();
            lblSucursal = new Label();
            lblCantidad = new Label();
            btnAgregarStockSucursal = new Button();
            cmbSucursalVer = new ComboBox();
            lblSucursalConStock = new Label();
            btnProductosPorSucursal = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockPorSucursal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadAsignar).BeginInit();
            SuspendLayout();
            // 
            // dgvSucursales
            // 
            dgvSucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSucursales.Location = new Point(23, 49);
            dgvSucursales.Name = "dgvSucursales";
            dgvSucursales.RowHeadersWidth = 51;
            dgvSucursales.Size = new Size(263, 174);
            dgvSucursales.TabIndex = 0;
            // 
            // lblSucursales
            // 
            lblSucursales.AutoSize = true;
            lblSucursales.Location = new Point(43, 20);
            lblSucursales.Name = "lblSucursales";
            lblSucursales.Size = new Size(62, 15);
            lblSucursales.TabIndex = 1;
            lblSucursales.Text = "Sucursales";
            // 
            // txtNombreSucursal
            // 
            txtNombreSucursal.Location = new Point(344, 85);
            txtNombreSucursal.Name = "txtNombreSucursal";
            txtNombreSucursal.Size = new Size(100, 23);
            txtNombreSucursal.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(344, 67);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(344, 127);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 26);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(344, 169);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 26);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvProductosStock
            // 
            dgvProductosStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductosStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosStock.Location = new Point(508, 49);
            dgvProductosStock.Name = "dgvProductosStock";
            dgvProductosStock.RowHeadersWidth = 51;
            dgvProductosStock.Size = new Size(533, 174);
            dgvProductosStock.TabIndex = 6;
            // 
            // lblStockDeProductos
            // 
            lblStockDeProductos.AutoSize = true;
            lblStockDeProductos.Location = new Point(521, 20);
            lblStockDeProductos.Name = "lblStockDeProductos";
            lblStockDeProductos.Size = new Size(112, 15);
            lblStockDeProductos.TabIndex = 7;
            lblStockDeProductos.Text = " Stock de productos";
            // 
            // dgvStockPorSucursal
            // 
            dgvStockPorSucursal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStockPorSucursal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockPorSucursal.Location = new Point(23, 293);
            dgvStockPorSucursal.Name = "dgvStockPorSucursal";
            dgvStockPorSucursal.RowHeadersWidth = 51;
            dgvStockPorSucursal.Size = new Size(761, 181);
            dgvStockPorSucursal.TabIndex = 8;
            // 
            // cmbSucursalAsignar
            // 
            cmbSucursalAsignar.FormattingEnabled = true;
            cmbSucursalAsignar.Location = new Point(1069, 67);
            cmbSucursalAsignar.Name = "cmbSucursalAsignar";
            cmbSucursalAsignar.Size = new Size(136, 23);
            cmbSucursalAsignar.TabIndex = 9;
            // 
            // lblStockPorSucursal
            // 
            lblStockPorSucursal.AutoSize = true;
            lblStockPorSucursal.Location = new Point(43, 263);
            lblStockPorSucursal.Name = "lblStockPorSucursal";
            lblStockPorSucursal.Size = new Size(104, 15);
            lblStockPorSucursal.TabIndex = 10;
            lblStockPorSucursal.Text = "Stock Por Sucursal";
            // 
            // nudCantidadAsignar
            // 
            nudCantidadAsignar.Location = new Point(1070, 132);
            nudCantidadAsignar.Name = "nudCantidadAsignar";
            nudCantidadAsignar.Size = new Size(135, 23);
            nudCantidadAsignar.TabIndex = 11;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Location = new Point(1069, 49);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(51, 15);
            lblSucursal.TabIndex = 12;
            lblSucursal.Text = "Sucursal";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(1070, 111);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 13;
            lblCantidad.Text = "Cantidad";
            // 
            // btnAgregarStockSucursal
            // 
            btnAgregarStockSucursal.Location = new Point(1069, 169);
            btnAgregarStockSucursal.Name = "btnAgregarStockSucursal";
            btnAgregarStockSucursal.Size = new Size(136, 54);
            btnAgregarStockSucursal.TabIndex = 14;
            btnAgregarStockSucursal.Text = "Agregar stock a la sucursal";
            btnAgregarStockSucursal.UseVisualStyleBackColor = true;
            btnAgregarStockSucursal.Click += btnAgregarStockSucursal_Click_2;
            // 
            // cmbSucursalVer
            // 
            cmbSucursalVer.FormattingEnabled = true;
            cmbSucursalVer.Location = new Point(816, 342);
            cmbSucursalVer.Name = "cmbSucursalVer";
            cmbSucursalVer.Size = new Size(140, 23);
            cmbSucursalVer.TabIndex = 15;
            // 
            // lblSucursalConStock
            // 
            lblSucursalConStock.AutoSize = true;
            lblSucursalConStock.Location = new Point(816, 321);
            lblSucursalConStock.Name = "lblSucursalConStock";
            lblSucursalConStock.Size = new Size(51, 15);
            lblSucursalConStock.TabIndex = 16;
            lblSucursalConStock.Text = "Sucursal";
            // 
            // btnProductosPorSucursal
            // 
            btnProductosPorSucursal.Location = new Point(816, 378);
            btnProductosPorSucursal.Name = "btnProductosPorSucursal";
            btnProductosPorSucursal.Size = new Size(140, 44);
            btnProductosPorSucursal.TabIndex = 17;
            btnProductosPorSucursal.Text = "Productos Por Sucursal";
            btnProductosPorSucursal.UseVisualStyleBackColor = true;
            btnProductosPorSucursal.Click += btnProductosPorSucursal_Click_1;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 496);
            Controls.Add(btnProductosPorSucursal);
            Controls.Add(lblSucursalConStock);
            Controls.Add(cmbSucursalVer);
            Controls.Add(btnAgregarStockSucursal);
            Controls.Add(lblCantidad);
            Controls.Add(lblSucursal);
            Controls.Add(nudCantidadAsignar);
            Controls.Add(lblStockPorSucursal);
            Controls.Add(cmbSucursalAsignar);
            Controls.Add(dgvStockPorSucursal);
            Controls.Add(lblStockDeProductos);
            Controls.Add(dgvProductosStock);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lblNombre);
            Controls.Add(txtNombreSucursal);
            Controls.Add(lblSucursales);
            Controls.Add(dgvSucursales);
            Name = "Form5";
            Text = "Gestion Sucursales";
            Load += Form5_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockPorSucursal).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadAsignar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSucursales;
        private Label lblSucursales;
        private TextBox txtNombreSucursal;
        private Label lblNombre;
        private Button btnAgregar;
        private Button btnEliminar;
        private DataGridView dgvProductosStock;
        private Label lblStockDeProductos;
        private DataGridView dgvStockPorSucursal;
        private ComboBox cmbSucursalAsignar;
        private Label lblStockPorSucursal;
        private NumericUpDown nudCantidadAsignar;
        private Label lblSucursal;
        private Label lblCantidad;
        private Button btnAgregarStockSucursal;
        private ComboBox cmbSucursalVer;
        private Label lblSucursalConStock;
        private Button btnProductosPorSucursal;
    }
}