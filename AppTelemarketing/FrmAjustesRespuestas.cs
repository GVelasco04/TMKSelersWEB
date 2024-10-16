using AppTelemarketing.Entidades;
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
using WinFormsApp2;

namespace AppTelemarketing
{
    public partial class FrmAjustesRespuestas : Form
    {
        InformesService informesService_ = new InformesService();
        RespuestasService respuestasService_ = new RespuestasService();
        public FrmAjustesRespuestas()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificamos si el TextBox está vacío
            if (string.IsNullOrWhiteSpace(txtNuevaRespuesta.Text))
            {
                // Mostramos un mensaje de advertencia
                MessageBox.Show("Por favor, ingrese una respuesta.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salimos del método
            }
            Respuestas respuesta = new Respuestas(txtNuevaRespuesta.Text);

            bool exito = respuestasService_.CargarRespuestaNueva(respuesta);

            // Verificamos si la operación fue exitosa
            if (exito)
            {
                // Mostramos un mensaje de éxito
                MessageBox.Show("Tipo de Respuesta cargado con éxito.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiamos los TextBox
                LimpiarCampos();
               
            }
            else
            {
                // Mostramos un mensaje de error
                MessageBox.Show("Error al cargar el tipo de respuesta.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtNuevaRespuesta.Clear();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuAdmi menuForm = this.ParentForm as frmMenuAdmi;
            // Verificar si menuForm no es nulo
            if (menuForm != null)
            {
                menuForm.AbrirFormularioEnPanel(new FrmRegistroRespuestasAdmin());

            }

        }

        private void FrmAjustesRespuestas_Load(object sender, EventArgs e)
        {
            DataTable tipoRespuesta = null!;
            TipoRespuestas.AutoGenerateColumns = false; // Deshabilitar la generación automática de columnas

            tipoRespuesta = respuestasService_.ListarTiposRespuestas();

            if (tipoRespuesta != null && tipoRespuesta.Rows.Count > 0)
            {
                // Asignar el DataTable como origen de datos para el DataGridView
                TipoRespuestas.DataSource = tipoRespuesta;
            }
            else
            {
                MessageBox.Show("No se encontraron datos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarRespuesta_Click(object sender, EventArgs e)
        {
            Respuestas respuestaSeleccionada;
            if (TipoRespuestas.SelectedCells.Count > 0)
            {
                int datoSeleccionado = TipoRespuestas.SelectedCells[0].RowIndex;
                DataGridViewRow filaSeleccionada = TipoRespuestas.Rows[datoSeleccionado];

                //solo con el id del prospecto podemos taer los datos a pantalla
                int codRespuesta = Convert.ToInt32(filaSeleccionada.Cells["idRespuesta"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el tipo de respuesta?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                // Instancia del formulario FrmRealizarLlamada
                // en el panel de la derecha 


                if (result == DialogResult.Yes)
                {
                    // Instancia del formulario FrmRealizarLlamada en el panel de la derecha

                    // Cuando el formulario se cierra eliminamos
                    // el prospecto del DataGridView y la base de datos
                    respuestasService_.EliminarRespuesta(codRespuesta);
                    TipoRespuestas.Rows.RemoveAt(datoSeleccionado);
                    MessageBox.Show("Tipo de Respuesta borrada con éxito.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Operación cancelada por el usuario
                    MessageBox.Show("Operación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una respuesta para continuar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            frmMenuAdmi menuForm = this.ParentForm as frmMenuAdmi;
            // Verificar si menuForm no es nulo
            if (menuForm != null)
            {
                menuForm.AbrirFormularioEnPanel(new FrmAjustesRespuestas());

            }
        }
    }
}
