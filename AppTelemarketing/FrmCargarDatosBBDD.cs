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
    public partial class FrmCargarDatosBBDD : Form
    {
        OpenFileDialog abrirExploradorArchivos = new OpenFileDialog();
        ProspectoService prospectoService = new ProspectoService();
        ManejoMensajesServices mensajesServices = new ManejoMensajesServices();
        FileServices fileServices = new FileServices();
        public FrmCargarDatosBBDD()
        {
            InitializeComponent();
        }

        private void btnCargarBD_Click(object sender, EventArgs e)
        {
            try
            {
                abrirExploradorArchivos.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                abrirExploradorArchivos.Title = "Seleccione un archivo";

                if (abrirExploradorArchivos.ShowDialog() == DialogResult.OK)
                {
                    string archivoSeleccionado = abrirExploradorArchivos.FileName;
                    string nombreArchivo = Path.GetFileName(archivoSeleccionado);

                    if (fileServices.ExisteArchivoBBDD(nombreArchivo))
                    {
                        MessageBox.Show("El archivo ya existe en la base de datos.", "Archivo duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var resultadoCarga = prospectoService.CargarProspectosDesdeArchivo(archivoSeleccionado);
                    var resultado = mensajesServices.ManejarResultado(true, $"Datos del archivo '{nombreArchivo}' cargados en la base de datos.");

                    bool archivoCargado = fileServices.CargarNombreArchivoBBDD(nombreArchivo);
                    if (!archivoCargado)
                    {
                        MessageBox.Show("Error al cargar el nombre del archivo en la base de datos.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    CargarArchivosEnListBox();

                    MessageBox.Show($"Resultado de la carga:\nProspectos cargados: {resultadoCarga.ContSi}\nProspectos no cargados (duplicados): {resultadoCarga.ContNo}\nTotal de registros procesados: {resultadoCarga.ContSi + resultadoCarga.ContNo}", "Resultado de Carga", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                var resultadoExcepcion = mensajesServices.ManejarExcepcion(ex);
                MessageBox.Show(resultadoExcepcion.MensajeExitoOError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCargarDatosBBDD_Load(object sender, EventArgs e)
        {
            abrirExploradorArchivos.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            abrirExploradorArchivos.Title = "Seleccione un archivo";
            CargarArchivosEnListBox();
        }
        private void CargarArchivosEnListBox()
        {
            lbArchivos.Items.Clear();
            var archivos = fileServices.ObtenerDatosArchivosBBDD();

            foreach (var archivo in archivos)
            {
                lbArchivos.Items.Add($"{archivo.NombreArchivo} - {archivo.FechaCarga}");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
