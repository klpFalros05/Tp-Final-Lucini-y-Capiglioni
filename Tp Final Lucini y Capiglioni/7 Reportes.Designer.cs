namespace Tp_Final_Lucini_y_Capiglioni
{
    partial class Form7
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
            cmbTipoReporte = new ComboBox();
            dgvResultados = new DataGridView();
            lblTipoDeReporte = new Label();
            dtpDesde = new DateTimePicker();
            lblDesde = new Label();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            cmbSucursal = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbVendedor = new ComboBox();
            label3 = new Label();
            cmbCliente = new ComboBox();
            label4 = new Label();
            cmbMetodoPago = new ComboBox();
            btnGenerar = new Button();
            btnLimpiar = new Button();
            gpbTotales = new GroupBox();
            label10 = new Label();
            txtCantidadProductoMasVendido = new TextBox();
            txtProductoMasVendido = new TextBox();
            label7 = new Label();
            txtTotalProductos = new TextBox();
            txtTotalCuentaCorriente = new TextBox();
            txtTotalFacturado = new TextBox();
            txtCantVentas = new TextBox();
            label5 = new Label();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            cmbProducto = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            gpbTotales.SuspendLayout();
            SuspendLayout();
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(145, 39);
            cmbTipoReporte.Margin = new Padding(3, 4, 3, 4);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(138, 28);
            cmbTipoReporte.TabIndex = 0;
            // 
            // dgvResultados
            // 
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(26, 205);
            dgvResultados.Margin = new Padding(3, 4, 3, 4);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(704, 267);
            dgvResultados.TabIndex = 1;
            // 
            // lblTipoDeReporte
            // 
            lblTipoDeReporte.AutoSize = true;
            lblTipoDeReporte.Location = new Point(26, 47);
            lblTipoDeReporte.Name = "lblTipoDeReporte";
            lblTipoDeReporte.Size = new Size(113, 20);
            lblTipoDeReporte.TabIndex = 2;
            lblTipoDeReporte.Text = "Tipo de reporte";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(26, 102);
            dtpDesde.Margin = new Padding(3, 4, 3, 4);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(216, 27);
            dtpDesde.TabIndex = 4;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(26, 78);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(51, 20);
            lblDesde.TabIndex = 5;
            lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(291, 78);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(47, 20);
            lblHasta.TabIndex = 7;
            lblHasta.Text = "Hasta";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(291, 107);
            dtpHasta.Margin = new Padding(3, 4, 3, 4);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(211, 27);
            dtpHasta.TabIndex = 6;
            // 
            // cmbSucursal
            // 
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(363, 39);
            cmbSucursal.Margin = new Padding(3, 4, 3, 4);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(161, 28);
            cmbSucursal.TabIndex = 8;
            cmbSucursal.SelectedIndexChanged += cmbSucursal_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 47);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 9;
            label1.Text = "Sucursal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(528, 112);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 11;
            label2.Text = "Vendedor:";
            // 
            // cmbVendedor
            // 
            cmbVendedor.FormattingEnabled = true;
            cmbVendedor.Location = new Point(627, 109);
            cmbVendedor.Margin = new Padding(3, 4, 3, 4);
            cmbVendedor.Name = "cmbVendedor";
            cmbVendedor.Size = new Size(186, 28);
            cmbVendedor.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 163);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 13;
            label3.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(90, 156);
            cmbCliente.Margin = new Padding(3, 4, 3, 4);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(175, 28);
            cmbCliente.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 163);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 15;
            label4.Text = "Metodo de pago:";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Location = new Point(415, 156);
            cmbMetodoPago.Margin = new Padding(3, 4, 3, 4);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(138, 28);
            cmbMetodoPago.TabIndex = 14;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(585, 156);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(145, 29);
            btnGenerar.TabIndex = 16;
            btnGenerar.Text = "Generar Reporte";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(746, 156);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(145, 29);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar Filtros";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // gpbTotales
            // 
            gpbTotales.Controls.Add(label10);
            gpbTotales.Controls.Add(txtCantidadProductoMasVendido);
            gpbTotales.Controls.Add(txtProductoMasVendido);
            gpbTotales.Controls.Add(label7);
            gpbTotales.Controls.Add(txtTotalProductos);
            gpbTotales.Controls.Add(txtTotalCuentaCorriente);
            gpbTotales.Controls.Add(txtTotalFacturado);
            gpbTotales.Controls.Add(txtCantVentas);
            gpbTotales.Controls.Add(label5);
            gpbTotales.Controls.Add(label11);
            gpbTotales.Controls.Add(label9);
            gpbTotales.Controls.Add(label8);
            gpbTotales.Location = new Point(800, 205);
            gpbTotales.Name = "gpbTotales";
            gpbTotales.Size = new Size(405, 312);
            gpbTotales.TabIndex = 18;
            gpbTotales.TabStop = false;
            gpbTotales.Text = "Totales";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 261);
            label10.Name = "label10";
            label10.Size = new Size(195, 20);
            label10.TabIndex = 23;
            label10.Text = "Cant. Producto Mas vendido";
            // 
            // txtCantidadProductoMasVendido
            // 
            txtCantidadProductoMasVendido.Location = new Point(236, 258);
            txtCantidadProductoMasVendido.Name = "txtCantidadProductoMasVendido";
            txtCantidadProductoMasVendido.ReadOnly = true;
            txtCantidadProductoMasVendido.Size = new Size(125, 27);
            txtCantidadProductoMasVendido.TabIndex = 22;
            txtCantidadProductoMasVendido.TextAlign = HorizontalAlignment.Right;
            // 
            // txtProductoMasVendido
            // 
            txtProductoMasVendido.Location = new Point(235, 212);
            txtProductoMasVendido.Name = "txtProductoMasVendido";
            txtProductoMasVendido.ReadOnly = true;
            txtProductoMasVendido.Size = new Size(125, 27);
            txtProductoMasVendido.TabIndex = 21;
            txtProductoMasVendido.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 215);
            label7.Name = "label7";
            label7.Size = new Size(161, 20);
            label7.TabIndex = 20;
            label7.Text = "Producto mas vendido:";
            // 
            // txtTotalProductos
            // 
            txtTotalProductos.Location = new Point(235, 167);
            txtTotalProductos.Name = "txtTotalProductos";
            txtTotalProductos.ReadOnly = true;
            txtTotalProductos.Size = new Size(125, 27);
            txtTotalProductos.TabIndex = 12;
            txtTotalProductos.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotalCuentaCorriente
            // 
            txtTotalCuentaCorriente.Location = new Point(235, 128);
            txtTotalCuentaCorriente.Name = "txtTotalCuentaCorriente";
            txtTotalCuentaCorriente.ReadOnly = true;
            txtTotalCuentaCorriente.Size = new Size(125, 27);
            txtTotalCuentaCorriente.TabIndex = 11;
            txtTotalCuentaCorriente.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotalFacturado
            // 
            txtTotalFacturado.Location = new Point(236, 81);
            txtTotalFacturado.Name = "txtTotalFacturado";
            txtTotalFacturado.ReadOnly = true;
            txtTotalFacturado.Size = new Size(125, 27);
            txtTotalFacturado.TabIndex = 10;
            txtTotalFacturado.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCantVentas
            // 
            txtCantVentas.Location = new Point(236, 43);
            txtCantVentas.Name = "txtCantVentas";
            txtCantVentas.ReadOnly = true;
            txtCantVentas.Size = new Size(125, 27);
            txtCantVentas.TabIndex = 9;
            txtCantVentas.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 166);
            label5.Name = "label5";
            label5.Size = new Size(143, 20);
            label5.TabIndex = 8;
            label5.Text = "Productos Vendidos:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 124);
            label11.Name = "label11";
            label11.Size = new Size(160, 20);
            label11.TabIndex = 7;
            label11.Text = "Total Cuenta Corriente:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 84);
            label9.Name = "label9";
            label9.Size = new Size(114, 20);
            label9.TabIndex = 5;
            label9.Text = "Total Facturado:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 46);
            label8.Name = "label8";
            label8.Size = new Size(140, 20);
            label8.TabIndex = 4;
            label8.Text = "Cantidad de Ventas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(545, 47);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 19;
            label6.Text = "Producto:";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(627, 44);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(151, 28);
            cmbProducto.TabIndex = 20;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 547);
            Controls.Add(cmbProducto);
            Controls.Add(label6);
            Controls.Add(gpbTotales);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGenerar);
            Controls.Add(label4);
            Controls.Add(cmbMetodoPago);
            Controls.Add(label3);
            Controls.Add(cmbCliente);
            Controls.Add(label2);
            Controls.Add(cmbVendedor);
            Controls.Add(label1);
            Controls.Add(cmbSucursal);
            Controls.Add(lblHasta);
            Controls.Add(dtpHasta);
            Controls.Add(lblDesde);
            Controls.Add(dtpDesde);
            Controls.Add(lblTipoDeReporte);
            Controls.Add(dgvResultados);
            Controls.Add(cmbTipoReporte);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form7";
            Text = "Reportes";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            gpbTotales.ResumeLayout(false);
            gpbTotales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoReporte;
        private DataGridView dgvResultados;
        private Label lblTipoDeReporte;
        private DateTimePicker dtpDesde;
        private Label lblDesde;
        private Label lblHasta;
        private DateTimePicker dtpHasta;
        private ComboBox cmbSucursal;
        private Label label1;
        private Label label2;
        private ComboBox cmbVendedor;
        private Label label3;
        private ComboBox cmbCliente;
        private Label label4;
        private ComboBox cmbMetodoPago;
        private Button btnGenerar;
        private Button btnLimpiar;
        private GroupBox gpbTotales;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label5;
        private TextBox txtTotalProductos;
        private TextBox txtTotalCuentaCorriente;
        private TextBox txtTotalFacturado;
        private TextBox txtCantVentas;
        private Label label10;
        private TextBox txtCantidadProductoMasVendido;
        private TextBox txtProductoMasVendido;
        private Label label7;
        private Label label6;
        private ComboBox cmbProducto;
    }
}