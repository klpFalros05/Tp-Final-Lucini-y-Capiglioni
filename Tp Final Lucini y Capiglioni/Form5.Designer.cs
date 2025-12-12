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
            dataGridView1 = new DataGridView();
            lblSucursales = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            dataGridView2 = new DataGridView();
            lblStockDeProductos = new Label();
            dataGridView3 = new DataGridView();
            comboBox1 = new ComboBox();
            lblStockPorSucursal = new Label();
            numericUpDown1 = new NumericUpDown();
            lblSucursal = new Label();
            lblCantidad = new Label();
            btnAgregarStockSucursal = new Button();
            comboBox2 = new ComboBox();
            lblSucursalConStock = new Label();
            btnProductosPorSucursal = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(157, 174);
            dataGridView1.TabIndex = 0;
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
            // txtNombre
            // 
            txtNombre.Location = new Point(197, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(197, 55);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(197, 115);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 26);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(197, 157);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 26);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(388, 49);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(533, 174);
            dataGridView2.TabIndex = 6;
            // 
            // lblStockDeProductos
            // 
            lblStockDeProductos.AutoSize = true;
            lblStockDeProductos.Location = new Point(401, 20);
            lblStockDeProductos.Name = "lblStockDeProductos";
            lblStockDeProductos.Size = new Size(112, 15);
            lblStockDeProductos.TabIndex = 7;
            lblStockDeProductos.Text = " Stock de productos";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(23, 293);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(761, 181);
            dataGridView3.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(950, 67);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(951, 132);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 11;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Location = new Point(950, 49);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(51, 15);
            lblSucursal.TabIndex = 12;
            lblSucursal.Text = "Sucursal";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(951, 111);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 13;
            lblCantidad.Text = "Cantidad";
            // 
            // btnAgregarStockSucursal
            // 
            btnAgregarStockSucursal.Location = new Point(965, 176);
            btnAgregarStockSucursal.Name = "btnAgregarStockSucursal";
            btnAgregarStockSucursal.Size = new Size(91, 50);
            btnAgregarStockSucursal.TabIndex = 14;
            btnAgregarStockSucursal.Text = "Agregar stock a la sucursal";
            btnAgregarStockSucursal.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(816, 342);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(140, 23);
            comboBox2.TabIndex = 15;
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
            btnProductosPorSucursal.Location = new Point(816, 395);
            btnProductosPorSucursal.Name = "btnProductosPorSucursal";
            btnProductosPorSucursal.Size = new Size(140, 32);
            btnProductosPorSucursal.TabIndex = 17;
            btnProductosPorSucursal.Text = "Productos Por Sucursal";
            btnProductosPorSucursal.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 496);
            Controls.Add(btnProductosPorSucursal);
            Controls.Add(lblSucursalConStock);
            Controls.Add(comboBox2);
            Controls.Add(btnAgregarStockSucursal);
            Controls.Add(lblCantidad);
            Controls.Add(lblSucursal);
            Controls.Add(numericUpDown1);
            Controls.Add(lblStockPorSucursal);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView3);
            Controls.Add(lblStockDeProductos);
            Controls.Add(dataGridView2);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblSucursales);
            Controls.Add(dataGridView1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblSucursales;
        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnAgregar;
        private Button btnEliminar;
        private DataGridView dataGridView2;
        private Label lblStockDeProductos;
        private DataGridView dataGridView3;
        private ComboBox comboBox1;
        private Label lblStockPorSucursal;
        private NumericUpDown numericUpDown1;
        private Label lblSucursal;
        private Label lblCantidad;
        private Button btnAgregarStockSucursal;
        private ComboBox comboBox2;
        private Label lblSucursalConStock;
        private Button btnProductosPorSucursal;
    }
}