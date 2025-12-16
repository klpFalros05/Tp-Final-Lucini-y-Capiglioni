namespace Tp_Final_Lucini_y_Capiglioni
{
    partial class Form4
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
            dgvProductos = new DataGridView();
            btnRegistrarVenta = new Button();
            cmbMetodoDePago = new ComboBox();
            lblMetodoDePago = new Label();
            cmbCliente = new ComboBox();
            lblCliente = new Label();
            btnGenerarFactura = new Button();
            lblSucursal = new Label();
            lblVendedor = new Label();
            cmbVendedor = new ComboBox();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            lblCuandoPaga = new Label();
            cmbCuandoPaga = new ComboBox();
            dgvCarrito = new DataGridView();
            nudCantidad = new NumericUpDown();
            lblCantidad = new Label();
            btnAgregarAlCarrito = new Button();
            lblCarrito = new Label();
            lblSubTotal = new Label();
            lblSubT = new Label();
            btnEliminarDelCarrito = new Button();
            btnVaciarCarrito = new Button();
            lblDesc = new Label();
            lblDescuento = new Label();
            lblTot = new Label();
            lblTotal = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblPrecioUnitario = new Label();
            txtPrecioUnitario = new TextBox();
            lblProductos = new Label();
            cmbSucursal = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(40, 101);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(704, 248);
            dgvProductos.TabIndex = 0;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged_1;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Location = new Point(843, 601);
            btnRegistrarVenta.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(134, 40);
            btnRegistrarVenta.TabIndex = 2;
            btnRegistrarVenta.Text = "Registrar venta";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // cmbMetodoDePago
            // 
            cmbMetodoDePago.FormattingEnabled = true;
            cmbMetodoDePago.Location = new Point(1208, 399);
            cmbMetodoDePago.Margin = new Padding(3, 4, 3, 4);
            cmbMetodoDePago.Name = "cmbMetodoDePago";
            cmbMetodoDePago.Size = new Size(133, 28);
            cmbMetodoDePago.TabIndex = 3;
            // 
            // lblMetodoDePago
            // 
            lblMetodoDePago.AutoSize = true;
            lblMetodoDePago.Location = new Point(1208, 375);
            lblMetodoDePago.Name = "lblMetodoDePago";
            lblMetodoDePago.Size = new Size(122, 20);
            lblMetodoDePago.TabIndex = 4;
            lblMetodoDePago.Text = "Metodo de pago";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(843, 399);
            cmbCliente.Margin = new Padding(3, 4, 3, 4);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(133, 28);
            cmbCliente.TabIndex = 5;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged_1;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(843, 375);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 6;
            lblCliente.Text = "Cliente";
            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.Location = new Point(1208, 677);
            btnGenerarFactura.Margin = new Padding(3, 4, 3, 4);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new Size(134, 40);
            btnGenerarFactura.TabIndex = 7;
            btnGenerarFactura.Text = "Generar Factura";
            btnGenerarFactura.UseVisualStyleBackColor = true;
            btnGenerarFactura.Click += btnGenerarFactura_Click;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Location = new Point(152, 35);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(63, 20);
            lblSucursal.TabIndex = 10;
            lblSucursal.Text = "Sucursal";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(1027, 463);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(73, 20);
            lblVendedor.TabIndex = 12;
            lblVendedor.Text = "Vendedor";
            // 
            // cmbVendedor
            // 
            cmbVendedor.FormattingEnabled = true;
            cmbVendedor.Location = new Point(1027, 487);
            cmbVendedor.Margin = new Padding(3, 4, 3, 4);
            cmbVendedor.Name = "cmbVendedor";
            cmbVendedor.Size = new Size(133, 28);
            cmbVendedor.TabIndex = 11;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(1027, 399);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(133, 27);
            dtpFecha.TabIndex = 13;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(1027, 375);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 20);
            lblFecha.TabIndex = 14;
            lblFecha.Text = "Fecha";
            // 
            // lblCuandoPaga
            // 
            lblCuandoPaga.AutoSize = true;
            lblCuandoPaga.Location = new Point(843, 463);
            lblCuandoPaga.Name = "lblCuandoPaga";
            lblCuandoPaga.Size = new Size(96, 20);
            lblCuandoPaga.TabIndex = 16;
            lblCuandoPaga.Text = "Cuando Paga";
            // 
            // cmbCuandoPaga
            // 
            cmbCuandoPaga.FormattingEnabled = true;
            cmbCuandoPaga.Location = new Point(843, 487);
            cmbCuandoPaga.Margin = new Padding(3, 4, 3, 4);
            cmbCuandoPaga.Name = "cmbCuandoPaga";
            cmbCuandoPaga.Size = new Size(133, 28);
            cmbCuandoPaga.TabIndex = 15;
            // 
            // dgvCarrito
            // 
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(843, 101);
            dgvCarrito.Margin = new Padding(3, 4, 3, 4);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.Size = new Size(498, 248);
            dgvCarrito.TabIndex = 17;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(239, 517);
            nudCantidad.Margin = new Padding(3, 4, 3, 4);
            nudCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(134, 27);
            nudCantidad.TabIndex = 18;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(239, 493);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 19;
            lblCantidad.Text = "Cantidad";
            // 
            // btnAgregarAlCarrito
            // 
            btnAgregarAlCarrito.Location = new Point(393, 509);
            btnAgregarAlCarrito.Margin = new Padding(3, 4, 3, 4);
            btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            btnAgregarAlCarrito.Size = new Size(134, 40);
            btnAgregarAlCarrito.TabIndex = 20;
            btnAgregarAlCarrito.Text = "Agregar al carrito";
            btnAgregarAlCarrito.UseVisualStyleBackColor = true;
            btnAgregarAlCarrito.Click += btnAgregarAlCarrito_Click_1;
            // 
            // lblCarrito
            // 
            lblCarrito.AutoSize = true;
            lblCarrito.Location = new Point(843, 77);
            lblCarrito.Name = "lblCarrito";
            lblCarrito.Size = new Size(54, 20);
            lblCarrito.TabIndex = 21;
            lblCarrito.Text = "Carrito";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(1200, 475);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(70, 20);
            lblSubTotal.TabIndex = 24;
            lblSubTotal.Text = "SubTotal:";
            // 
            // lblSubT
            // 
            lblSubT.AutoSize = true;
            lblSubT.Location = new Point(1283, 475);
            lblSubT.Name = "lblSubT";
            lblSubT.Size = new Size(67, 20);
            lblSubT.TabIndex = 25;
            lblSubT.Text = "sub total";
            // 
            // btnEliminarDelCarrito
            // 
            btnEliminarDelCarrito.Location = new Point(1027, 601);
            btnEliminarDelCarrito.Margin = new Padding(3, 4, 3, 4);
            btnEliminarDelCarrito.Name = "btnEliminarDelCarrito";
            btnEliminarDelCarrito.Size = new Size(150, 40);
            btnEliminarDelCarrito.TabIndex = 26;
            btnEliminarDelCarrito.Text = "Eliminar del carrito";
            btnEliminarDelCarrito.UseVisualStyleBackColor = true;
            btnEliminarDelCarrito.Click += btnEliminarDelCarrito_Click;
            // 
            // btnVaciarCarrito
            // 
            btnVaciarCarrito.Location = new Point(1208, 601);
            btnVaciarCarrito.Margin = new Padding(3, 4, 3, 4);
            btnVaciarCarrito.Name = "btnVaciarCarrito";
            btnVaciarCarrito.Size = new Size(134, 40);
            btnVaciarCarrito.TabIndex = 27;
            btnVaciarCarrito.Text = "Vaciar carrito";
            btnVaciarCarrito.UseVisualStyleBackColor = true;
            btnVaciarCarrito.Click += btnVaciarCarrito_Click;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(1283, 509);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(77, 20);
            lblDesc.TabIndex = 29;
            lblDesc.Text = "descuento";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(1200, 509);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(82, 20);
            lblDescuento.TabIndex = 28;
            lblDescuento.Text = "Descuento:";
            // 
            // lblTot
            // 
            lblTot.AutoSize = true;
            lblTot.Location = new Point(1285, 547);
            lblTot.Name = "lblTot";
            lblTot.Size = new Size(40, 20);
            lblTot.TabIndex = 31;
            lblTot.Text = "total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1201, 547);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 20);
            lblTotal.TabIndex = 30;
            lblTotal.Text = "Total:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(243, 432);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 32;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(249, 408);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 33;
            lblNombre.Text = "Nombre";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(393, 408);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(107, 20);
            lblPrecioUnitario.TabIndex = 35;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(387, 432);
            txtPrecioUnitario.Margin = new Padding(3, 4, 3, 4);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.ReadOnly = true;
            txtPrecioUnitario.Size = new Size(114, 27);
            txtPrecioUnitario.TabIndex = 34;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Location = new Point(65, 77);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(75, 20);
            lblProductos.TabIndex = 36;
            lblProductos.Text = "Productos";
            // 
            // cmbSucursal
            // 
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(221, 31);
            cmbSucursal.Margin = new Padding(3, 4, 3, 4);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(133, 28);
            cmbSucursal.TabIndex = 9;
            cmbSucursal.SelectedIndexChanged += cmbSucursal_SelectedIndexChanged;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 733);
            Controls.Add(lblProductos);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblTot);
            Controls.Add(lblTotal);
            Controls.Add(lblDesc);
            Controls.Add(lblDescuento);
            Controls.Add(btnVaciarCarrito);
            Controls.Add(btnEliminarDelCarrito);
            Controls.Add(lblSubT);
            Controls.Add(lblSubTotal);
            Controls.Add(lblCarrito);
            Controls.Add(btnAgregarAlCarrito);
            Controls.Add(lblCantidad);
            Controls.Add(nudCantidad);
            Controls.Add(dgvCarrito);
            Controls.Add(lblCuandoPaga);
            Controls.Add(cmbCuandoPaga);
            Controls.Add(lblFecha);
            Controls.Add(dtpFecha);
            Controls.Add(lblVendedor);
            Controls.Add(cmbVendedor);
            Controls.Add(lblSucursal);
            Controls.Add(cmbSucursal);
            Controls.Add(btnGenerarFactura);
            Controls.Add(lblCliente);
            Controls.Add(cmbCliente);
            Controls.Add(lblMetodoDePago);
            Controls.Add(cmbMetodoDePago);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(dgvProductos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form4";
            Text = "Ventas";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Label lblProductos;
        private Button btnRegistrarVenta;
        private ComboBox cmbMetodoDePago;
        private Label lblMetodoDePago;
        private ComboBox cmbCliente;
        private Label lblCliente;
        private Button btnGenerarFactura;
        private Label lblSucursal;
        private Label lblVendedor;
        private ComboBox cmbVendedor;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private Label lblCuandoPaga;
        private ComboBox cmbCuandoPaga;
        private DataGridView dgvCarrito;
        private NumericUpDown nudCantidad;
        private Label lblCantidad;
        private Button btnAgregarAlCarrito;
        private Label lblCarrito;
        private Label lblSubTotal;
        private Label lblSubT;
        private Button btnEliminarDelCarrito;
        private Button btnVaciarCarrito;
        private Label lblDesc;
        private Label lblDescuento;
        private Label lblTot;
        private Label lblTotal;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblPrecioUnitario;
        private TextBox txtPrecioUnitario;
        private ComboBox cmbSucursal;
    }
}