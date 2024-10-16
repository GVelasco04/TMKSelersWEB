using AppTelemarketing.Servicios;
namespace AppTelemarketing
{
    public partial class FrmCambiarContrasena : Form
    {
        public ValidacionesService validacionesService_ = new ValidacionesService();
        public FrmCambiarContrasena()
        {
            InitializeComponent();
            txtClave.PasswordChar = '*';
            txtClaveNueva.PasswordChar = '*';
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombredeUsuario = FrmLogin.usuariologueado;
            string contraseñaActual = txtClave.Text;
            string nuevaContraseña = txtClaveNueva.Text;
            FrmLogin frmLogin = new FrmLogin();

            if (frmLogin.SecurityService_.UsuarioValido(nombredeUsuario, contraseñaActual))
            {
                validacionesService_.ActualizarContraseña(nombredeUsuario, nuevaContraseña);
                MessageBox.Show("Contraseña cambiada con exito");
                LimpiarCampos();

            }
            else
            {
                MessageBox.Show("La contraseña actual es incorrecta.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureCerrado_Click(object sender, EventArgs e)
        {
            pictureAbierto.BringToFront();
            txtClave.PasswordChar = '\0'; // Mostramos la contraseña
        }

        private void pictureAbierto_Click_1(object sender, EventArgs e)
        {
            pictureCerrado.BringToFront();
            txtClave.PasswordChar = '*'; // Ocultamos la contraseña
        }

        private void pictureOcerrado_Click_1(object sender, EventArgs e)
        {
            pictureOabierto.BringToFront();
            txtClaveNueva.PasswordChar = '\0'; // Mostramos la contraseña
        }

        private void pictureOabierto_Click_1(object sender, EventArgs e)
        {
            pictureOcerrado.BringToFront();
            txtClaveNueva.PasswordChar = '*'; // Ocultamos la contraseña
        }
        private void LimpiarCampos()
        {
            txtClave.Clear();
            txtClaveNueva.Clear();
        }
    }
}
