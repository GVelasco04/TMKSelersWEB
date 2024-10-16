using WinFormsApp2;

namespace AppTelemarketing
{
    public partial class FrmEmpresas : Form
    {
        public FrmEmpresas()
        {
            InitializeComponent();
        }

        private void btnFlow_Click(object sender, EventArgs e)
        {
            this.Close();
            // Crear una instancia de frmMenu
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void btnMovistar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Servicio de movistar en mantenimiento", "Movistar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTelecentro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Servicio de Telecentro en mantenimiento", "Telecentro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
