using AppTelemarketing;

namespace WinFormsApp2
{
    public partial class frmMenu : Form
    {
      
        public frmMenu()
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

        //funcion para que se minimize la pantalla en el menu
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
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            //enviamos por paramentro el formulario que seamos abrir en el form menu
            AbrirFormInPanel(new FrmNuevoProspecto());
        }

        private FrmRealizarLlamada frmRealizarLlamada;
        private int idProspectoActual;
        private void btnRealizarLlamados_Click(object sender, EventArgs e)
        {
            if (frmRealizarLlamada == null || frmRealizarLlamada.IsDisposed)
            {
                frmRealizarLlamada = new FrmRealizarLlamada(idProspectoActual);
            }
            AbrirFormInPanel(frmRealizarLlamada);
        }
        private void btnRegistrosLlamadas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmRegistroRespuestas());
        }

        private void btnConsultarVentas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmConsultarVentas());
        }

        //lo declare publico para q pueda ser accedido x otras clases
        public void AbrirFormularioEnPanel(Form formHijo)
        {
            AbrirFormInPanel(formHijo);
        }

        private void btnConsultarLlamadas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmConsultarLlamada());
        }

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmCambiarContrasena());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void btnConsultarAgendados_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmConsultarAgendados());
        }
    }

}
