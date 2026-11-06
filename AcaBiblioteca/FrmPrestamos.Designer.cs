namespace AcaBiblioteca
{
    partial class FrmPrestamos
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
            pnlBotones = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dtpFechadevolucion = new DateTimePicker();
            dtpFechaprestamo = new DateTimePicker();
            lblFechadevolucion = new Label();
            lblFechaprestamo = new Label();
            cmbLibro = new ComboBox();
            lblLibro = new Label();
            cmbUsuario = new ComboBox();
            lblUsuario = new Label();
            pnlLista = new Panel();
            dgvPrestamos = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlBotones.SuspendLayout();
            pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
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
            pnlTitulo.TabIndex = 4;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(681, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(378, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE PRESTAMOS";
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = SystemColors.Control;
            pnlDatos.Controls.Add(pnlBotones);
            pnlDatos.Controls.Add(dtpFechadevolucion);
            pnlDatos.Controls.Add(dtpFechaprestamo);
            pnlDatos.Controls.Add(lblFechadevolucion);
            pnlDatos.Controls.Add(lblFechaprestamo);
            pnlDatos.Controls.Add(cmbLibro);
            pnlDatos.Controls.Add(lblLibro);
            pnlDatos.Controls.Add(cmbUsuario);
            pnlDatos.Controls.Add(lblUsuario);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 60);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1348, 377);
            pnlDatos.TabIndex = 7;
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnNuevo);
            pnlBotones.Location = new Point(439, 311);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(814, 60);
            pnlBotones.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 25;
            btnCancelar.Location = new Point(646, 10);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(149, 40);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Baseball;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 25;
            btnEliminar.Location = new Point(490, 10);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(149, 40);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnEditar.IconSize = 25;
            btnEditar.Location = new Point(335, 10);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(149, 40);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 25;
            btnGuardar.Location = new Point(180, 10);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(149, 40);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnNuevo.IconSize = 25;
            btnNuevo.Location = new Point(12, 10);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(149, 40);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dtpFechadevolucion
            // 
            dtpFechadevolucion.Format = DateTimePickerFormat.Short;
            dtpFechadevolucion.Location = new Point(718, 233);
            dtpFechadevolucion.Name = "dtpFechadevolucion";
            dtpFechadevolucion.Size = new Size(250, 27);
            dtpFechadevolucion.TabIndex = 21;
            dtpFechadevolucion.Value = new DateTime(2026, 11, 5, 0, 0, 0, 0);
            // 
            // dtpFechaprestamo
            // 
            dtpFechaprestamo.Format = DateTimePickerFormat.Short;
            dtpFechaprestamo.Location = new Point(718, 172);
            dtpFechaprestamo.Name = "dtpFechaprestamo";
            dtpFechaprestamo.Size = new Size(250, 27);
            dtpFechaprestamo.TabIndex = 20;
            // 
            // lblFechadevolucion
            // 
            lblFechadevolucion.AutoSize = true;
            lblFechadevolucion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechadevolucion.Location = new Point(543, 240);
            lblFechadevolucion.Name = "lblFechadevolucion";
            lblFechadevolucion.Size = new Size(135, 20);
            lblFechadevolucion.TabIndex = 19;
            lblFechadevolucion.Text = "Fecha Devolución:";
            // 
            // lblFechaprestamo
            // 
            lblFechaprestamo.AutoSize = true;
            lblFechaprestamo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaprestamo.Location = new Point(543, 179);
            lblFechaprestamo.Name = "lblFechaprestamo";
            lblFechaprestamo.Size = new Size(124, 20);
            lblFechaprestamo.TabIndex = 18;
            lblFechaprestamo.Text = "Fecha préstamo:";
            // 
            // cmbLibro
            // 
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(718, 106);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(250, 28);
            cmbLibro.TabIndex = 17;
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLibro.Location = new Point(543, 114);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(49, 20);
            lblLibro.TabIndex = 16;
            lblLibro.Text = "Libro:";
            // 
            // cmbUsuario
            // 
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(718, 45);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(250, 28);
            cmbUsuario.TabIndex = 15;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(543, 53);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(67, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // pnlLista
            // 
            pnlLista.BackColor = Color.White;
            pnlLista.Controls.Add(dgvPrestamos);
            pnlLista.Dock = DockStyle.Fill;
            pnlLista.Location = new Point(0, 437);
            pnlLista.Name = "pnlLista";
            pnlLista.Size = new Size(1348, 446);
            pnlLista.TabIndex = 9;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.BackgroundColor = Color.Gainsboro;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Dock = DockStyle.Fill;
            dgvPrestamos.Location = new Point(0, 0);
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.RowHeadersWidth = 51;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(1348, 446);
            dgvPrestamos.TabIndex = 9;
            dgvPrestamos.CellDoubleClick += dgvPrestamos_CellDoubleClick_1;
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 883);
            Controls.Add(pnlLista);
            Controls.Add(pnlDatos);
            Controls.Add(pnlTitulo);
            Name = "FrmPrestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrestamos";
            WindowState = FormWindowState.Maximized;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlBotones.ResumeLayout(false);
            pnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlDatos;
        private Label lblUsuario;
        private Panel pnlLista;
        private ComboBox cmbUsuario;
        private ComboBox cmbLibro;
        private Label lblLibro;
        private Label lblFechaprestamo;
        private DateTimePicker dtpFechadevolucion;
        private DateTimePicker dtpFechaprestamo;
        private Label lblFechadevolucion;
        private Panel pnlBotones;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private DataGridView dgvPrestamos;
    }
}