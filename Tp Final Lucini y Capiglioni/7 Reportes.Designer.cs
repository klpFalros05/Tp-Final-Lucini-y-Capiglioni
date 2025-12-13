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
            cbTipoDeReporte.Location = new Point(438, 89);
            cbTipoDeReporte.Name = "cbTipoDeReporte";
            cbTipoDeReporte.Size = new Size(121, 23);
            cbTipoDeReporte.TabIndex = 0;
            // 
            // dgvReportes
            // 
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(47, 67);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.Size = new Size(357, 200);
            dgvReportes.TabIndex = 1;
            // 
            // lblTipoDeReporte
            // 
            lblTipoDeReporte.AutoSize = true;
            lblTipoDeReporte.Location = new Point(438, 71);
            lblTipoDeReporte.Name = "lblTipoDeReporte";
            lblTipoDeReporte.Size = new Size(88, 15);
            lblTipoDeReporte.TabIndex = 2;
            lblTipoDeReporte.Text = "Tipo de reporte";
            // 
            // lblReportes
            // 
            lblReportes.AutoSize = true;
            lblReportes.Location = new Point(61, 38);
            lblReportes.Name = "lblReportes";
            lblReportes.Size = new Size(53, 15);
            lblReportes.TabIndex = 3;
            lblReportes.Text = "Reportes";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(439, 154);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(121, 23);
            dtpDesde.TabIndex = 4;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(439, 136);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(39, 15);
            lblDesde.TabIndex = 5;
            lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(604, 136);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(37, 15);
            lblHasta.TabIndex = 7;
            lblHasta.Text = "Hasta";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(604, 154);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(121, 23);
            dtpHasta.TabIndex = 6;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHasta);
            Controls.Add(dtpHasta);
            Controls.Add(lblDesde);
            Controls.Add(dtpDesde);
            Controls.Add(lblReportes);
            Controls.Add(lblTipoDeReporte);
            Controls.Add(dgvReportes);
            Controls.Add(cbTipoDeReporte);
            Name = "Form7";
            Text = "Form7";
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