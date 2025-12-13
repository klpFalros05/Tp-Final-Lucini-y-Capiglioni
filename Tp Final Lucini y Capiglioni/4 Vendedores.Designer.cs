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
            dataGridView1 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 277);
            dataGridView1.TabIndex = 0;
            // 
            // lblVendedores
            // 
            lblVendedores.AutoSize = true;
            lblVendedores.Location = new Point(52, 30);
            lblVendedores.Name = "lblVendedores";
            lblVendedores.Size = new Size(68, 15);
            lblVendedores.TabIndex = 1;
            lblVendedores.Text = "Vendedores";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(327, 100);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(327, 165);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(327, 118);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(327, 183);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(495, 114);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 29);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(495, 179);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 29);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(495, 242);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 29);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // cbSucursal
            // 
            cbSucursal.FormattingEnabled = true;
            cbSucursal.Location = new Point(327, 248);
            cbSucursal.Name = "cbSucursal";
            cbSucursal.Size = new Size(121, 23);
            cbSucursal.TabIndex = 9;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Location = new Point(327, 230);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(51, 15);
            lblSucursal.TabIndex = 10;
            lblSucursal.Text = "Sucursal";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 381);
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
            Controls.Add(dataGridView1);
            Name = "Form6";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
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
    }
}