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
            btnMayoristas = new Button();
            btnMinoristas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDescuento).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(41, 424);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(195, 424);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(41, 448);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(195, 448);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(114, 27);
            txtApellido.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 61);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(718, 311);
            dataGridView1.TabIndex = 4;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Location = new Point(41, 24);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(61, 20);
            lblClientes.TabIndex = 5;
            lblClientes.Text = "Clientes";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(41, 519);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 40);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(195, 519);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(114, 40);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(344, 519);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 40);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblTipoDeCliente
            // 
            lblTipoDeCliente.AutoSize = true;
            lblTipoDeCliente.Location = new Point(344, 422);
            lblTipoDeCliente.Name = "lblTipoDeCliente";
            lblTipoDeCliente.Size = new Size(108, 20);
            lblTipoDeCliente.TabIndex = 9;
            lblTipoDeCliente.Text = "Tipo de cliente";
            // 
            // cbTipoDeCliente
            // 
            cbTipoDeCliente.FormattingEnabled = true;
            cbTipoDeCliente.Location = new Point(344, 448);
            cbTipoDeCliente.Margin = new Padding(3, 4, 3, 4);
            cbTipoDeCliente.Name = "cbTipoDeCliente";
            cbTipoDeCliente.Size = new Size(114, 28);
            cbTipoDeCliente.TabIndex = 10;
            // 
            // nudDescuento
            // 
            nudDescuento.Location = new Point(499, 448);
            nudDescuento.Margin = new Padding(3, 4, 3, 4);
            nudDescuento.Name = "nudDescuento";
            nudDescuento.Size = new Size(114, 27);
            nudDescuento.TabIndex = 11;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(499, 422);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(79, 20);
            lblDescuento.TabIndex = 12;
            lblDescuento.Text = "Descuento";
            // 
            // btnMayoristas
            // 
            btnMayoristas.Location = new Point(499, 519);
            btnMayoristas.Margin = new Padding(3, 4, 3, 4);
            btnMayoristas.Name = "btnMayoristas";
            btnMayoristas.Size = new Size(114, 40);
            btnMayoristas.TabIndex = 13;
            btnMayoristas.Text = "Mayoristas";
            btnMayoristas.UseVisualStyleBackColor = true;
            // 
            // btnMinoristas
            // 
            btnMinoristas.Location = new Point(630, 519);
            btnMinoristas.Margin = new Padding(3, 4, 3, 4);
            btnMinoristas.Name = "btnMinoristas";
            btnMinoristas.Size = new Size(114, 40);
            btnMinoristas.TabIndex = 14;
            btnMinoristas.Text = "Minoristas";
            btnMinoristas.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 600);
            Controls.Add(btnMinoristas);
            Controls.Add(btnMayoristas);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnMayoristas;
        private Button btnMinoristas;
    }
}