namespace AcaBiblioteca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            Abrirformulario(new FrmInicio());
        }

        private void Abrirformulario(Form formulario)
        {
            pnlContenido.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(formulario);
            formulario.Show();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Abrirformulario(new FrmInicio());
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            Abrirformulario(new FrmLibros());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Abrirformulario(new FrmUsuarios());
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            Abrirformulario(new FrmAutores());
        }

        private void btnEditoriales_Click(object sender, EventArgs e)
        {
            Abrirformulario(new FrmEditoriales());
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            Abrirformulario(new FrmPrestamos());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Abrirformulario(new FrmPrestamos());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}