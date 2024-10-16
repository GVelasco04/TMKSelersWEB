using AppTelemarketing.Entidades;
using AppTelemarketing.Servicios;
using WinFormsApp2;

namespace AppTelemarketing
{
    public partial class FrmLogin : Form
    {
        public SecurityService SecurityService_ = new SecurityService();
        public UsuarioService UsuarioService_ = new UsuarioService();
        public FrmLogin()
        {
            InitializeComponent();
            CargarTipoUsuarioComboBox();
            txtClave.PasswordChar = '*';
            


        }
        // Definimos una propiedad est�tica para almacenar el nombre de usuario del usuario logueado
        public static string usuariologueado { get; set; }
        public static int idUser { get; set; }
        private void linkRegistrese_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmRegistrarse frmRegistrarse = new FrmRegistrarse();
            frmRegistrarse.Show();

        }

        public void btnIniciar_Click(object sender, EventArgs e)
        {
            // Obtener el IdTipoUsuario seleccionado del ComboBox
            if (comboBoxRol.SelectedValue != null && int.TryParse(comboBoxRol.SelectedValue.ToString(), out int idTipoUsuario))
            {
                // Se busca en la base de datos si el usuario es v�lido
                if (SecurityService_.UsuarioValido(txtUsuario.Text, txtClave.Text, idTipoUsuario))
                {
                    usuariologueado = txtUsuario.Text;
                    idUser = UsuarioService_.TraerUserId(usuariologueado);
                    RedirigirSegunRol();
                }
                else
                {
                    if (idTipoUsuario == 1)
                    {
                        MessageBox.Show("Usuario incorrecto ");
                    }
                    else
                    {

                        MessageBox.Show("Usuario incorrecto o su cuenta a�n no ha sido aprobada por el administrador");

                    }
                }
            }
        }

            private void RedirigirSegunRol()
        {
            TipoUsuarios respuestaSeleccionada = comboBoxRol.SelectedItem as TipoUsuarios;

            if (respuestaSeleccionada != null)
            {
                if (respuestaSeleccionada.Descripcion == "Administrador")
                {
                    this.Hide();
                    frmMenuAdmi FrmMenuAdmi = new frmMenuAdmi();
                    FrmMenuAdmi.Show();
                }
                else if (respuestaSeleccionada.Descripcion == "TMK")
                {
                    this.Hide();
                    FrmEmpresas frmEmpresas = new FrmEmpresas();
                    frmEmpresas.Show();
                }
                // Puedes a�adir m�s casos seg�n los roles disponibles
            }
        }

        private void CargarTipoUsuarioComboBox()
        {
            comboBoxRol.DataSource = null;
            comboBoxRol.DataSource = UsuarioService_.ObtenerTipoUsuarios();
            comboBoxRol.DisplayMember = "Descripcion";
            comboBoxRol.ValueMember = "IdTipoUsuario";
        }

        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            RedirigirSegunRol();
        }

        private void pictureOcerrado_Click(object sender, EventArgs e)
        {

            pictureOabierto.BringToFront();
            txtClave.PasswordChar = '\0'; // Mostramos la contrase�a
        }
        private void pictureOabierto_Click(object sender, EventArgs e)
        {
            pictureOcerrado.BringToFront();
            txtClave.PasswordChar = '*'; // Ocultamos la contrase�a
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
