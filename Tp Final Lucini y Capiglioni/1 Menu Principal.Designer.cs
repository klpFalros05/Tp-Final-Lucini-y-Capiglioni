namespace Tp_Final_Lucini_y_Capiglioni
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMenuPrincipal = new Label();
            btnRegistrarProductos = new Button();
            btnRegistarVentas = new Button();
            btnSucursalesStock = new Button();
            btnReportes = new Button();
            btnRegistrarClientes = new Button();
            btnVendedores = new Button();
            SuspendLayout();
            // 
            // lblMenuPrincipal
            // 
            lblMenuPrincipal.AutoSize = true;
            lblMenuPrincipal.Location = new Point(192, 57);
            lblMenuPrincipal.Name = "lblMenuPrincipal";
            lblMenuPrincipal.Size = new Size(91, 20);
            lblMenuPrincipal.TabIndex = 0;
            lblMenuPrincipal.Text = "Bienvenido!!";
            // 
            // btnRegistrarProductos
            // 
            btnRegistrarProductos.Location = new Point(70, 90);
            btnRegistrarProductos.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarProductos.Name = "btnRegistrarProductos";
            btnRegistrarProductos.Size = new Size(161, 40);
            btnRegistrarProductos.TabIndex = 1;
            btnRegistrarProductos.Text = "Registrar Productos";
            btnRegistrarProductos.UseVisualStyleBackColor = true;
            btnRegistrarProductos.Click += btnRegistrarStock_Click;
            // 
            // btnRegistarVentas
            // 
            btnRegistarVentas.Location = new Point(70, 186);
            btnRegistarVentas.Margin = new Padding(3, 4, 3, 4);
            btnRegistarVentas.Name = "btnRegistarVentas";
            btnRegistarVentas.Size = new Size(161, 40);
            btnRegistarVentas.TabIndex = 2;
            btnRegistarVentas.Text = "Registrar Ventas";
            btnRegistarVentas.UseVisualStyleBackColor = true;
            btnRegistarVentas.Click += btnRegistarVentas_Click;
            // 
            // btnSucursalesStock
            // 
            btnSucursalesStock.Location = new Point(237, 90);
            btnSucursalesStock.Margin = new Padding(3, 4, 3, 4);
            btnSucursalesStock.Name = "btnSucursalesStock";
            btnSucursalesStock.Size = new Size(161, 40);
            btnSucursalesStock.TabIndex = 3;
            btnSucursalesStock.Text = "Sucursales/Stock";
            btnSucursalesStock.UseVisualStyleBackColor = true;
            btnSucursalesStock.Click += btnSucursalesStock_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(237, 186);
            btnReportes.Margin = new Padding(3, 4, 3, 4);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(161, 40);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnRegistrarClientes
            // 
            btnRegistrarClientes.Location = new Point(70, 138);
            btnRegistrarClientes.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarClientes.Name = "btnRegistrarClientes";
            btnRegistrarClientes.Size = new Size(161, 40);
            btnRegistrarClientes.TabIndex = 5;
            btnRegistrarClientes.Text = "Registrar Clientes";
            btnRegistrarClientes.UseVisualStyleBackColor = true;
            btnRegistrarClientes.Click += btnRegistrarClientes_Click;
            // 
            // btnVendedores
            // 
            btnVendedores.Location = new Point(237, 138);
            btnVendedores.Margin = new Padding(3, 4, 3, 4);
            btnVendedores.Name = "btnVendedores";
            btnVendedores.Size = new Size(161, 40);
            btnVendedores.TabIndex = 6;
            btnVendedores.Text = "Registrar Vendedores";
            btnVendedores.UseVisualStyleBackColor = true;
            btnVendedores.Click += btnVendedores_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 293);
            Controls.Add(btnVendedores);
            Controls.Add(btnRegistrarClientes);
            Controls.Add(btnReportes);
            Controls.Add(btnSucursalesStock);
            Controls.Add(btnRegistarVentas);
            Controls.Add(btnRegistrarProductos);
            Controls.Add(lblMenuPrincipal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Menu Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenuPrincipal;
        private Button btnRegistrarProductos;
        private Button btnRegistarVentas;
        private Button btnSucursalesStock;
        private Button btnReportes;
        private Button btnRegistrarClientes;
        private Button btnVendedores;
    }
}
