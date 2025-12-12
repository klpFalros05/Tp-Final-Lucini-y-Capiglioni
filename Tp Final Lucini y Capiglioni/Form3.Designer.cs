namespace Tp_Final_Lucini_y_Capiglioni
{
    partial class Form3
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
            lblNombre = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            dataGridView1 = new DataGridView();
            lblClientes = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lblTipoDeCliente = new Label();
            cbTipoDeCliente = new ComboBox();
            nudDescuento = new NumericUpDown();
            lblDescuento = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDescuento).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(78, 316);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(213, 316);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(78, 334);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(213, 334);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(628, 233);
            dataGridView1.TabIndex = 4;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Location = new Point(36, 18);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(49, 15);
            lblClientes.TabIndex = 5;
            lblClientes.Text = "Clientes";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(78, 390);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(213, 390);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 30);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(343, 390);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblTipoDeCliente
            // 
            lblTipoDeCliente.AutoSize = true;
            lblTipoDeCliente.Location = new Point(343, 314);
            lblTipoDeCliente.Name = "lblTipoDeCliente";
            lblTipoDeCliente.Size = new Size(85, 15);
            lblTipoDeCliente.TabIndex = 9;
            lblTipoDeCliente.Text = "Tipo de cliente";
            // 
            // cbTipoDeCliente
            // 
            cbTipoDeCliente.FormattingEnabled = true;
            cbTipoDeCliente.Location = new Point(343, 334);
            cbTipoDeCliente.Name = "cbTipoDeCliente";
            cbTipoDeCliente.Size = new Size(100, 23);
            cbTipoDeCliente.TabIndex = 10;
            // 
            // nudDescuento
            // 
            nudDescuento.Location = new Point(479, 334);
            nudDescuento.Name = "nudDescuento";
            nudDescuento.Size = new Size(100, 23);
            nudDescuento.TabIndex = 11;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(479, 314);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(63, 15);
            lblDescuento.TabIndex = 12;
            lblDescuento.Text = "Descuento";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 450);
            Controls.Add(lblDescuento);
            Controls.Add(nudDescuento);
            Controls.Add(cbTipoDeCliente);
            Controls.Add(lblTipoDeCliente);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lblClientes);
            Controls.Add(dataGridView1);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDescuento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private DataGridView dataGridView1;
        private Label lblClientes;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label lblTipoDeCliente;
        private ComboBox cbTipoDeCliente;
        private NumericUpDown nudDescuento;
        private Label lblDescuento;
    }
}