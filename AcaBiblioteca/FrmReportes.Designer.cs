namespace AcaBiblioteca
{
    partial class FrmReportes
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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlDatos = new Panel();
            btnGenerar = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            cmbTipoReporte = new ComboBox();
            lblTiporeporte = new Label();
            panel1 = new Panel();
            dgvReportes = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlDatos.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.RoyalBlue;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1348, 60);
            pnlTitulo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(676, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(356, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE  REPORTES";
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = SystemColors.Control;
            pnlDatos.Controls.Add(btnGenerar);
            pnlDatos.Controls.Add(btnLimpiar);
            pnlDatos.Controls.Add(cmbTipoReporte);
            pnlDatos.Controls.Add(lblTiporeporte);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 60);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1348, 376);
            pnlDatos.TabIndex = 8;
            // 
            // btnGenerar
            // 
            btnGenerar.IconChar = FontAwesome.Sharp.IconChar.Resolving;
            btnGenerar.IconColor = Color.Black;
            btnGenerar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGenerar.IconSize = 25;
            btnGenerar.Location = new Point(647, 261);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(175, 40);
            btnGenerar.TabIndex = 7;
            btnGenerar.Text = "Generar Reporte";
            btnGenerar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Circle;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 25;
            btnLimpiar.Location = new Point(897, 261);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(174, 40);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoReporte.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(647, 128);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(424, 33);
            cmbTipoReporte.TabIndex = 1;
            // 
            // lblTiporeporte
            // 
            lblTiporeporte.AutoSize = true;
            lblTiporeporte.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiporeporte.Location = new Point(367, 128);
            lblTiporeporte.Name = "lblTiporeporte";
            lblTiporeporte.Size = new Size(173, 28);
            lblTiporeporte.TabIndex = 1;
            lblTiporeporte.Text = "Tipo De Reporte:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvReportes);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 436);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 447);
            panel1.TabIndex = 9;
            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.BackgroundColor = SystemColors.Control;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Dock = DockStyle.Fill;
            dgvReportes.Location = new Point(0, 0);
            dgvReportes.MultiSelect = false;
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.RowHeadersWidth = 51;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.Size = new Size(1348, 447);
            dgvReportes.TabIndex = 0;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 883);
            Controls.Add(panel1);
            Controls.Add(pnlDatos);
            Controls.Add(pnlTitulo);
            Name = "FrmReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmReportes";
            WindowState = FormWindowState.Maximized;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlDatos;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGenerar;
        private DateTimePicker dtpFechadevolucion;
        private DateTimePicker dtpFechaprestamo;
        private Label lblFechadevolucion;
        private Label lblFechaprestamo;
        private ComboBox cmbLibro;
        private Label lblLibro;
        private ComboBox cmbTipoReporte;
        private Label lblTiporeporte;
        private Panel panel1;
        private DataGridView dgvReportes;
    }
}