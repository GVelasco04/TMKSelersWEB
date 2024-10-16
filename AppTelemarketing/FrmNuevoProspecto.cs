using AppTelemarketing.Entidades;
using AppTelemarketing.Servicios;

namespace WinFormsApp2
{
    public partial class FrmNuevoProspecto : Form
    {
        // Variables miembro del formulario
        Prospecto prospecto;
        ProspectoService prospectoService = new ProspectoService();
        ManejoMensajesServices servicioMensaje = new ManejoMensajesServices();
        ValidacionesService validaciones = new ValidacionesService();

        public FrmNuevoProspecto()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            Prospecto prospectoCargado;
            string mensaje = "";
            long telefonoConvertido;

            bool esValido = validaciones.EsTelefonoValido(txtTelefono.Text, out mensaje, out telefonoConvertido);

            if (esValido)
            {
                // La conversión fue exitosa, asignamos el valor al prospecto
                prospecto = new Prospecto(txtNombre.Text, txtApellido.Text, telefonoConvertido);

                // Llamar al servicio para cargar el prospecto y obtener el resultado
                bool exito = prospectoService.CargarProspectoNuevo(prospecto);

                // Verificamos si la operación fue exitosa
                if (exito)
                {
                    // Mostrar mensaje de confirmación
                    DialogResult resultado = MessageBox.Show("¿Quiere llamar a este prospecto ahora?\n\nSI = Debe registrarle una respuesta.\n\nNO = El prospecto se guarda en la base para ser llamado algún día.",
                                                            "Confirmación de Llamada", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        // Traer el prospecto a pantalla en el frmRealizarLlamada
                        prospectoCargado = prospectoService.TraerIdProspecto(telefonoConvertido);
                        frmMenu menuForm = this.ParentForm as frmMenu;
                        if (menuForm != null)
                        {
                            menuForm.AbrirFormInPanel(new FrmRealizarLlamada(prospectoCargado.IdProspecto));
                        }
                        else
                        {
                            MessageBox.Show("No se puede abrir Formulario", "Información", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        // Limpiar los campos de texto
                        LimpiarCampos();
                    }
                }
                else
                {
                    // Mostramos un mensaje de error
                    MessageBox.Show("Error al cargar el prospecto\n\nó\n\nTeléfono repetido en base.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // La conversión del teléfono falló o la validación del teléfono falló
                MessageBox.Show(mensaje, "Error en formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
        }
    }
}


