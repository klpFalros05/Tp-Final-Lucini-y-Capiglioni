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
            cbTipoDeReporte = new ComboBox();
            dgvReportes = new DataGridView();
            lblTipoDeReporte = new Label();
            lblReportes = new Label();
            dtpDesde = new DateTimePicker();
            lblDesde = new Label();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // cbTipoDeReporte
            // 
            cbTipoDeReporte.FormattingEnabled = true;
            cbTipoDeReporte.Location = new Point(501, 119);
            cbTipoDeReporte.Margin = new Padding(3, 4, 3, 4);
            cbTipoDeReporte.Name = "cbTipoDeReporte";
            cbTipoDeReporte.Size = new Size(138, 28);
            cbTipoDeReporte.TabIndex = 0;
            // 
            // dgvReportes
            // 
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(54, 89);
            dgvReportes.Margin = new Padding(3, 4, 3, 4);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.RowHeadersWidth = 51;
            dgvReportes.Size = new Size(408, 267);
            dgvReportes.TabIndex = 1;
            // 
            // lblTipoDeReporte
            // 
            lblTipoDeReporte.AutoSize = true;
            lblTipoDeReporte.Location = new Point(501, 95);
            lblTipoDeReporte.Name = "lblTipoDeReporte";
            lblTipoDeReporte.Size = new Size(113, 20);
            lblTipoDeReporte.TabIndex = 2;
            lblTipoDeReporte.Text = "Tipo de reporte";
            // 
            // lblReportes
            // 
            lblReportes.AutoSize = true;
            lblReportes.Location = new Point(70, 51);
            lblReportes.Name = "lblReportes";
            lblReportes.Size = new Size(68, 20);
            lblReportes.TabIndex = 3;
            lblReportes.Text = "Reportes";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(502, 205);
            dtpDesde.Margin = new Padding(3, 4, 3, 4);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(138, 27);
            dtpDesde.TabIndex = 4;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(502, 181);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(51, 20);
            lblDesde.TabIndex = 5;
            lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(690, 181);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(47, 20);
            lblHasta.TabIndex = 7;
            lblHasta.Text = "Hasta";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(690, 205);
            dtpHasta.Margin = new Padding(3, 4, 3, 4);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(138, 27);
            dtpHasta.TabIndex = 6;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblHasta);
            Controls.Add(dtpHasta);
            Controls.Add(lblDesde);
            Controls.Add(dtpDesde);
            Controls.Add(lblReportes);
            Controls.Add(lblTipoDeReporte);
            Controls.Add(dgvReportes);
            Controls.Add(cbTipoDeReporte);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form7";
            Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTipoDeReporte;
        private DataGridView dgvReportes;
        private Label lblTipoDeReporte;
        private Label lblReportes;
        private DateTimePicker dtpDesde;
        private Label lblDesde;
        private Label lblHasta;
        private DateTimePicker dtpHasta;
    }
}