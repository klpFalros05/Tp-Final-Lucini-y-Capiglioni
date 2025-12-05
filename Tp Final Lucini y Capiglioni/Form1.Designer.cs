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
            lblMenuPrincipal.Location = new Point(155, 30);
            lblMenuPrincipal.Name = "lblMenuPrincipal";
            lblMenuPrincipal.Size = new Size(87, 15);
            lblMenuPrincipal.TabIndex = 0;
            lblMenuPrincipal.Text = "Menu Principal";
            // 
            // btnRegistrarProductos
            // 
            btnRegistrarProductos.Location = new Point(76, 69);
            btnRegistrarProductos.Name = "btnRegistrarProductos";
            btnRegistrarProductos.Size = new Size(121, 30);
            btnRegistrarProductos.TabIndex = 1;
            btnRegistrarProductos.Text = "Registrar Productos";
            btnRegistrarProductos.UseVisualStyleBackColor = true;
            btnRegistrarProductos.Click += btnRegistrarStock_Click;
            // 
            // btnRegistarVentas
            // 
            btnRegistarVentas.Location = new Point(76, 141);
            btnRegistarVentas.Name = "btnRegistarVentas";
            btnRegistarVentas.Size = new Size(121, 30);
            btnRegistarVentas.TabIndex = 2;
            btnRegistarVentas.Text = "Registrar Ventas";
            btnRegistarVentas.UseVisualStyleBackColor = true;
            btnRegistarVentas.Click += btnRegistarVentas_Click;
            // 
            // btnSucursalesStock
            // 
            btnSucursalesStock.Location = new Point(76, 105);
            btnSucursalesStock.Name = "btnSucursalesStock";
            btnSucursalesStock.Size = new Size(121, 30);
            btnSucursalesStock.TabIndex = 3;
            btnSucursalesStock.Text = "Sucursales/Stock";
            btnSucursalesStock.UseVisualStyleBackColor = true;
            btnSucursalesStock.Click += btnSucursalesStock_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(203, 141);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(121, 30);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnRegistrarClientes
            // 
            btnRegistrarClientes.Location = new Point(203, 69);
            btnRegistrarClientes.Name = "btnRegistrarClientes";
            btnRegistrarClientes.Size = new Size(121, 30);
            btnRegistrarClientes.TabIndex = 5;
            btnRegistrarClientes.Text = "Registrar Clientes";
            btnRegistrarClientes.UseVisualStyleBackColor = true;
            btnRegistrarClientes.Click += btnRegistrarClientes_Click;
            // 
            // btnVendedores
            // 
            btnVendedores.Location = new Point(203, 105);
            btnVendedores.Name = "btnVendedores";
            btnVendedores.Size = new Size(121, 30);
            btnVendedores.TabIndex = 6;
            btnVendedores.Text = "Vendedores";
            btnVendedores.UseVisualStyleBackColor = true;
            btnVendedores.Click += btnVendedores_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 220);
            Controls.Add(btnVendedores);
            Controls.Add(btnRegistrarClientes);
            Controls.Add(btnReportes);
            Controls.Add(btnSucursalesStock);
            Controls.Add(btnRegistarVentas);
            Controls.Add(btnRegistrarProductos);
            Controls.Add(lblMenuPrincipal);
            Name = "Form1";
            Text = "Form1";
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
