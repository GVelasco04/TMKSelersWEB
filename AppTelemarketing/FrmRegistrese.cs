using AppTelemarketing.Entidades;
using AppTelemarketing.Servicios;
using System.Text.RegularExpressions;

namespace AppTelemarketing
{
    public partial class FrmRegistrarse : Form
    {
        //creo la lista de usuarios para que pueda tomarse desde el otro formulario
        List<Usuario> ListUsuarios = new List<Usuario>();
        //me crea una nueva instancia de mi servicio de correo electronico
        MailServices mailService = new MailServices(); 

        //ValidacionesService validacionesService_ = new ValidacionesService();

        UsuarioService usuarioService_ = new UsuarioService();  
        public FrmRegistrarse()
        {
            InitializeComponent();
            // Selecciona por defecto la primera opción
            CargarTipoUsuarioComboBox();
       

            comboBoxRol.SelectedIndex = 0; 
        }

        public static bool IsValidEmail(string email)
        {
            // Expresión regular para validar el formato de correo electrónico
            Regex expr = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            return expr.IsMatch(email);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmLogin frmlogin=new FrmLogin();
            frmlogin.Show();
            this.Close();
        }

        public void btnAceptar_Click(object sender, EventArgs e)
        {            // Crear un nuevo usuario


            //Usuario newUsuario = new Usuario();
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string Correo = txtCorreo.Text;
            string UserName = txtUsuario.Text;
            string Clave = new Random().Next().ToString(); // Crear clave aleatoria
            int tipo = 0;
            int aceptadoXAdmin = 0;

            if (IsValidEmail(txtCorreo.Text))
            {
            }
            else
            {
                MessageBox.Show("Ingrese un email valido");
                return;
            }

            if (txtNombre.Text == "Ingrese Nombre " || txtApellido.Text == "Ingrese Apellido" || txtCorreo.Text == "Ingrese Correo" || txtUsuario.Text == "Ingrese Usuario")
            {
                MessageBox.Show("Complete correctamente los campos.");
                return;
            }

            // Tipo de usuario segun la selección del ComboBox (TMK o Administardor)
            //int tipo = 0;
            if (comboBoxRol.SelectedIndex == 0)
            {
                tipo = 1;
                
            }
            else
            {
                tipo = 2;
            }
            //TipoUsuario.Text = tipo;

            Usuario newUsuario = new Usuario(UserName, Nombre, Apellido, Correo, Clave, tipo, aceptadoXAdmin);
            // Llamar al método para agregar el usuario
            usuarioService_.AgregarUsuario(newUsuario);

            // Añadir el usuario a la lista local
            // Enviar el correo electrónico con nombre de usuario
            if (tipo == 1)
            {
                // Enviar el correo electrónico con la clave temporal
                MailData mailDataClave = new MailData
                {
                    Mailto = txtCorreo.Text,
                    Subject = "Registro de usuarios sistema de Telemarketing",
                    Body = $"Hola, aquí está tu clave temporal: {newUsuario.Clave}"
                };
                mailService.SendMail(mailDataClave);
            }
            else if (tipo == 2)
            {
                // Enviar el correo electrónico de bienvenida solo si es telemarketer
                MailData mailDataBienvenida = new MailData
                {
                    Mailto = txtCorreo.Text,
                    Subject = "Registro de usuarios sistema de Telemarketing",
                    Body = $"Hola Telemarketer:  {newUsuario.UserName}, en breve será aceptado por el administrador y recibirá un correo con su contraseña temporal."
                };
                mailService.SendMail(mailDataBienvenida);
            }

            

            MessageBox.Show("Usuario registrado con éxito");
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }
    

        // Devuelve todos los usuarios de la lista
        public List<Usuario> ObtenerUsuario()
        {
            return ListUsuarios;
        }

        public Usuario BuscarUsuario(string username, string clave)
        {

            Usuario userFound = null;
            //busco en la lista y recorre 1x1 todos los user de la lista
            userFound = ListUsuarios.Find(usuario => usuario.UserName == username && usuario.Clave == clave);
            return userFound; //si no se cumple devuelve null
        }
        private void CargarTipoUsuarioComboBox()
        {
            comboBoxRol.DataSource = null;
            comboBoxRol.DataSource = usuarioService_.ObtenerTipoUsuarios();
            comboBoxRol.DisplayMember = "Descripcion";
            comboBoxRol.ValueMember = "IdTipoUsuario";
        }
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Ingrese Nombre")
            {
                txtNombre.Text = string.Empty;
                txtNombre.ForeColor = Color.Black;

            }

        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty)
            {
                txtNombre.Text = "Ingrese Nombre";
                txtNombre.ForeColor = Color.FromArgb(172, 166, 166);

            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Ingrese Apellido")
            {
                txtApellido.Text = string.Empty;
                txtApellido.ForeColor = Color.Black;

            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == string.Empty)
            {
                txtApellido.Text = "Ingrese Apellido";
                txtApellido.ForeColor = Color.FromArgb(172, 166, 166);

            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Ingrese Correo")
            {
                txtCorreo.Text = string.Empty;
                txtCorreo.ForeColor = Color.Black;

            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == string.Empty)
            {
                txtCorreo.Text = "Ingrese Correo";
                txtCorreo.ForeColor = Color.FromArgb(172, 166, 166);

            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingrese Usuario")
            {
                txtUsuario.Text = string.Empty;
                txtUsuario.ForeColor = Color.Black;

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
            {
                txtUsuario.Text = "Ingrese Usuario";
                txtUsuario.ForeColor = Color.FromArgb(172, 166, 166);

            }
        }
        //PAra la asignación del tipo de usuario (Usuario o ADministrador)
        private void TipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcionSeleccionada = comboBoxRol.SelectedItem.ToString();

        }

    }
}
