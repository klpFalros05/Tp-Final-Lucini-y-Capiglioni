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
            dataGridView1 = new DataGridView();
            lblVentas = new Label();
            btnRegistrarVenta = new Button();
            comboBox1 = new ComboBox();
            lblMetodoDePago = new Label();
            comboBox2 = new ComboBox();
            lblCliente = new Label();
            btnGenerarFactura = new Button();
            numericUpDown1 = new NumericUpDown();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(72, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(282, 150);
            dataGridView1.TabIndex = 0;
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Location = new Point(72, 39);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(41, 15);
            lblVentas.TabIndex = 1;
            lblVentas.Text = "Ventas";
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Location = new Point(72, 321);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(117, 30);
            btnRegistrarVenta.TabIndex = 2;
            btnRegistrarVenta.Text = "Registrar venta";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(233, 263);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(117, 23);
            comboBox1.TabIndex = 3;
            // 
            // lblMetodoDePago
            // 
            lblMetodoDePago.AutoSize = true;
            lblMetodoDePago.Location = new Point(233, 245);
            lblMetodoDePago.Name = "lblMetodoDePago";
            lblMetodoDePago.Size = new Size(95, 15);
            lblMetodoDePago.TabIndex = 4;
            lblMetodoDePago.Text = "Metodo de pago";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(72, 263);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(117, 23);
            comboBox2.TabIndex = 5;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(72, 245);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 6;
            lblCliente.Text = "Cliente";
            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.Location = new Point(233, 321);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new Size(117, 30);
            btnGenerarFactura.TabIndex = 7;
            btnGenerarFactura.Text = "Generar Factura";
            btnGenerarFactura.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(421, 263);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(421, 66);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(240, 150);
            dataGridView2.TabIndex = 9;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(numericUpDown1);
            Controls.Add(btnGenerarFactura);
            Controls.Add(lblCliente);
            Controls.Add(comboBox2);
            Controls.Add(lblMetodoDePago);
            Controls.Add(comboBox1);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(lblVentas);
            Controls.Add(dataGridView1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblVentas;
        private Button btnRegistrarVenta;
        private ComboBox comboBox1;
        private Label lblMetodoDePago;
        private ComboBox comboBox2;
        private Label lblCliente;
        private Button btnGenerarFactura;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView2;
    }
}