using AppTelemarketing;

namespace WinFormsApp2
{
    public partial class frmMenuAdmi : Form
    {
        public frmMenuAdmi()
        {
            InitializeComponent();
            //Nombre del usuario
            string nombredeUsuario = FrmLogin.usuariologueado;
            //MessageBox.Show(nombredeUsuario);


            // Encuentra el control de etiqueta en tu formulario donde quieres mostrar el nombre
            Label txtMostrarUser = this.Controls.Find("txtMostrarUser", true).FirstOrDefault() as Label;

            // Si el control de etiqueta existe, actualiza su propiedad Text con el nombre de usuario
            if (txtMostrarUser != null)
            {
                txtMostrarUser.Text = nombredeUsuario;
            }
        }

        private void menuIcono_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 300)
            {
                MenuVertical.Width = 71;
            }
            else
            {
                MenuVertical.Width = 300;
            }
        }

        public void AbrirFormInPanel(object FormHijo)
        {

            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }


        //lo declare publico para q pueda ser accedido x otras clases
        public void AbrirFormularioEnPanel(Form formHijo)
        {
            AbrirFormInPanel(formHijo);
        }

        private void btnNuevoProspecto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmNuevoProspectoAdmi());
        }

        private void btnSolicitudTmk_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmAdministrarTmk());
        }

        private void btnRegistrosLlamadas_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmRegistroRespuestasAdmin());
        }

        private void btnConsultarLlamadas_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmConsultarLlamadaAdmin());
        }

        private void btnConsultarAgendados_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmConsultarAgendadosAdmin());
        }

        private void btnCambiarContrasena_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmCambiarContraseniaAdmin());
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void btnConsultarVentas_Click_1(object sender, EventArgs e)
        {

            AbrirFormInPanel(new FrmConsultarVentasAdmin());
        }

        private void btnCargarDatosEnBase_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmCargarDatosBBDD());
        }
    }

}
