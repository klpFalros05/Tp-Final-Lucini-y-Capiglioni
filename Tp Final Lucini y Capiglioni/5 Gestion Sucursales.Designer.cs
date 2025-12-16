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
            dgvSucursales.Location = new Point(26, 65);
            dgvSucursales.Margin = new Padding(3, 4, 3, 4);
            dgvSucursales.Name = "dgvSucursales";
            dgvSucursales.RowHeadersWidth = 51;
            dgvSucursales.Size = new Size(301, 232);
            dgvSucursales.TabIndex = 0;
            // 
            // lblSucursales
            // 
            lblSucursales.AutoSize = true;
            lblSucursales.Location = new Point(49, 27);
            lblSucursales.Name = "lblSucursales";
            lblSucursales.Size = new Size(77, 20);
            lblSucursales.TabIndex = 1;
            lblSucursales.Text = "Sucursales";
            // 
            // txtNombreSucursal
            // 
            txtNombreSucursal.Location = new Point(393, 113);
            txtNombreSucursal.Margin = new Padding(3, 4, 3, 4);
            txtNombreSucursal.Name = "txtNombreSucursal";
            txtNombreSucursal.Size = new Size(114, 27);
            txtNombreSucursal.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(393, 89);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(393, 169);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 35);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(393, 225);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 35);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvProductosStock
            // 
            dgvProductosStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductosStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosStock.Location = new Point(581, 65);
            dgvProductosStock.Margin = new Padding(3, 4, 3, 4);
            dgvProductosStock.Name = "dgvProductosStock";
            dgvProductosStock.RowHeadersWidth = 51;
            dgvProductosStock.Size = new Size(609, 232);
            dgvProductosStock.TabIndex = 6;
            // 
            // lblStockDeProductos
            // 
            lblStockDeProductos.AutoSize = true;
            lblStockDeProductos.Location = new Point(595, 27);
            lblStockDeProductos.Name = "lblStockDeProductos";
            lblStockDeProductos.Size = new Size(141, 20);
            lblStockDeProductos.TabIndex = 7;
            lblStockDeProductos.Text = " Stock de productos";
            // 
            // dgvStockPorSucursal
            // 
            dgvStockPorSucursal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStockPorSucursal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockPorSucursal.Location = new Point(26, 391);
            dgvStockPorSucursal.Margin = new Padding(3, 4, 3, 4);
            dgvStockPorSucursal.Name = "dgvStockPorSucursal";
            dgvStockPorSucursal.RowHeadersWidth = 51;
            dgvStockPorSucursal.Size = new Size(870, 241);
            dgvStockPorSucursal.TabIndex = 8;
            // 
            // cmbSucursalAsignar
            // 
            cmbSucursalAsignar.FormattingEnabled = true;
            cmbSucursalAsignar.Location = new Point(1222, 89);
            cmbSucursalAsignar.Margin = new Padding(3, 4, 3, 4);
            cmbSucursalAsignar.Name = "cmbSucursalAsignar";
            cmbSucursalAsignar.Size = new Size(155, 28);
            cmbSucursalAsignar.TabIndex = 9;
            // 
            // lblStockPorSucursal
            // 
            lblStockPorSucursal.AutoSize = true;
            lblStockPorSucursal.Location = new Point(49, 351);
            lblStockPorSucursal.Name = "lblStockPorSucursal";
            lblStockPorSucursal.Size = new Size(128, 20);
            lblStockPorSucursal.TabIndex = 10;
            lblStockPorSucursal.Text = "Stock Por Sucursal";
            // 
            // nudCantidadAsignar
            // 
            nudCantidadAsignar.Location = new Point(1223, 176);
            nudCantidadAsignar.Margin = new Padding(3, 4, 3, 4);
            nudCantidadAsignar.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudCantidadAsignar.Name = "nudCantidadAsignar";
            nudCantidadAsignar.Size = new Size(154, 27);
            nudCantidadAsignar.TabIndex = 11;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Location = new Point(1222, 65);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(63, 20);
            lblSucursal.TabIndex = 12;
            lblSucursal.Text = "Sucursal";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(1223, 148);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 13;
            lblCantidad.Text = "Cantidad";
            // 
            // btnAgregarStockSucursal
            // 
            btnAgregarStockSucursal.Location = new Point(1222, 225);
            btnAgregarStockSucursal.Margin = new Padding(3, 4, 3, 4);
            btnAgregarStockSucursal.Name = "btnAgregarStockSucursal";
            btnAgregarStockSucursal.Size = new Size(155, 72);
            btnAgregarStockSucursal.TabIndex = 14;
            btnAgregarStockSucursal.Text = "Agregar stock a la sucursal";
            btnAgregarStockSucursal.UseVisualStyleBackColor = true;
            btnAgregarStockSucursal.Click += btnAgregarStockSucursal_Click_2;
            // 
            // cmbSucursalVer
            // 
            cmbSucursalVer.FormattingEnabled = true;
            cmbSucursalVer.Location = new Point(933, 456);
            cmbSucursalVer.Margin = new Padding(3, 4, 3, 4);
            cmbSucursalVer.Name = "cmbSucursalVer";
            cmbSucursalVer.Size = new Size(159, 28);
            cmbSucursalVer.TabIndex = 15;
            // 
            // lblSucursalConStock
            // 
            lblSucursalConStock.AutoSize = true;
            lblSucursalConStock.Location = new Point(933, 428);
            lblSucursalConStock.Name = "lblSucursalConStock";
            lblSucursalConStock.Size = new Size(63, 20);
            lblSucursalConStock.TabIndex = 16;
            lblSucursalConStock.Text = "Sucursal";
            // 
            // btnProductosPorSucursal
            // 
            btnProductosPorSucursal.Location = new Point(933, 504);
            btnProductosPorSucursal.Margin = new Padding(3, 4, 3, 4);
            btnProductosPorSucursal.Name = "btnProductosPorSucursal";
            btnProductosPorSucursal.Size = new Size(160, 59);
            btnProductosPorSucursal.TabIndex = 17;
            btnProductosPorSucursal.Text = "Productos Por Sucursal";
            btnProductosPorSucursal.UseVisualStyleBackColor = true;
            btnProductosPorSucursal.Click += btnProductosPorSucursal_Click_1;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 661);
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
            Margin = new Padding(3, 4, 3, 4);
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