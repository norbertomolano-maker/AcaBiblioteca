namespace AcaBiblioteca
{
    partial class FrmLibros
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
            pnlBusqueda = new Panel();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            pnlDatos = new Panel();
            lblISBN = new Label();
            lblTituloLib = new Label();
            lblAutor = new Label();
            lblEditorial = new Label();
            lblCategoria = new Label();
            lblAño = new Label();
            lblExistencias = new Label();
            txtISBN = new TextBox();
            txtTitulo = new TextBox();
            txtCategoria = new TextBox();
            txtAño = new TextBox();
            txtExistencias = new TextBox();
            cmbAutor = new ComboBox();
            cmbEditorial = new ComboBox();
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.RoyalBlue;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1234, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(271, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(305, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE LIBROS";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.WhiteSmoke;
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Controls.Add(lblBuscar);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1234, 55);
            pnlBusqueda.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(224, 23);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(44, 20);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "ISBN";
            lblBuscar.Click += label1_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(341, 22);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(180, 27);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(553, 23);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 32);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(cmbEditorial);
            pnlDatos.Controls.Add(cmbAutor);
            pnlDatos.Controls.Add(txtExistencias);
            pnlDatos.Controls.Add(txtAño);
            pnlDatos.Controls.Add(txtCategoria);
            pnlDatos.Controls.Add(txtTitulo);
            pnlDatos.Controls.Add(txtISBN);
            pnlDatos.Controls.Add(lblExistencias);
            pnlDatos.Controls.Add(lblAño);
            pnlDatos.Controls.Add(lblCategoria);
            pnlDatos.Controls.Add(lblEditorial);
            pnlDatos.Controls.Add(lblAutor);
            pnlDatos.Controls.Add(lblTituloLib);
            pnlDatos.Controls.Add(lblISBN);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 115);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1234, 397);
            pnlDatos.TabIndex = 3;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(224, 37);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(48, 20);
            lblISBN.TabIndex = 1;
            lblISBN.Text = "ISBN:";
            // 
            // lblTituloLib
            // 
            lblTituloLib.AutoSize = true;
            lblTituloLib.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLib.Location = new Point(224, 89);
            lblTituloLib.Name = "lblTituloLib";
            lblTituloLib.Size = new Size(54, 20);
            lblTituloLib.TabIndex = 2;
            lblTituloLib.Text = "Titulo:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(224, 130);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(55, 20);
            lblAutor.TabIndex = 3;
            lblAutor.Text = "Autor:";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditorial.Location = new Point(224, 178);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(71, 20);
            lblEditorial.TabIndex = 4;
            lblEditorial.Text = "Editorial:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(224, 219);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(80, 20);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria:";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAño.Location = new Point(224, 257);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(42, 20);
            lblAño.TabIndex = 6;
            lblAño.Text = "Año:";
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistencias.Location = new Point(224, 299);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(89, 20);
            lblExistencias.TabIndex = 7;
            lblExistencias.Text = "Existencias:";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(341, 30);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(180, 27);
            txtISBN.TabIndex = 8;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(341, 86);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(180, 27);
            txtTitulo.TabIndex = 9;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(341, 212);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(180, 27);
            txtCategoria.TabIndex = 10;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(341, 250);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(180, 27);
            txtAño.TabIndex = 11;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(341, 292);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(180, 27);
            txtExistencias.TabIndex = 12;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(341, 122);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(180, 28);
            cmbAutor.TabIndex = 14;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(341, 170);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(180, 28);
            cmbEditorial.TabIndex = 15;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 763);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrmLibros";
            Text = "L";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlBusqueda;
        private Label lblBuscar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Panel pnlDatos;
        private Label lblISBN;
        private Label lblAutor;
        private Label lblTituloLib;
        private Label lblAño;
        private Label lblCategoria;
        private Label lblEditorial;
        private TextBox txtTitulo;
        private TextBox txtISBN;
        private Label lblExistencias;
        private ComboBox cmbAutor;
        private TextBox txtExistencias;
        private TextBox txtAño;
        private TextBox txtCategoria;
        private ComboBox cmbEditorial;
    }
}