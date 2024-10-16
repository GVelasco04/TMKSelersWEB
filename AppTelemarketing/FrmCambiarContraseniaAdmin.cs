using AppTelemarketing.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTelemarketing
{
    public partial class FrmCambiarContraseniaAdmin : Form
    {
        public ValidacionesService validacionesService_ = new ValidacionesService();
        public FrmCambiarContraseniaAdmin()
        {
            InitializeComponent();
            txtClave.PasswordChar = '*';
            txtClaveNueva.PasswordChar = '*';
        }

        
        private void LimpiarCampos()
        {
            txtClave.Clear();
            txtClaveNueva.Clear();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureCerrado_Click_1(object sender, EventArgs e)
        {
            pictureAbierto.BringToFront();
            txtClave.PasswordChar = '\0'; // Mostramos la contraseña
        }

        private void pictureAbierto_Click(object sender, EventArgs e)
        {
            pictureCerrado.BringToFront();
            txtClave.PasswordChar = '*'; // Ocultamos la contraseña
        }

        private void pictureOcerrado_Click(object sender, EventArgs e)
        {
            pictureOabierto.BringToFront();
            txtClaveNueva.PasswordChar = '\0'; // Mostramos la contraseña
        }

        private void pictureOabierto_Click(object sender, EventArgs e)
        {
            pictureOcerrado.BringToFront();
            txtClaveNueva.PasswordChar = '*'; // Ocultamos la contraseña
        }
    }
}

