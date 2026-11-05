using AcaBiblioteca.Datos;

namespace AcaBiblioteca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
            try
            {
                using (var conn = conexion.EstablecerConexion())
                {
                    conn.Open();
                    // La conexión se ha establecido correctamente
                    MessageBox.Show("Conexión a la base de datos establecida correctamente.",
                        "AcaBiblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Ocurrió un error al intentar establecer la conexión
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message,
                    "AcaBiblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

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

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}