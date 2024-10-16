using AppTelemarketing.Entidades;
using AppTelemarketing.Servicios;
using System.Data;
using WinFormsApp2;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppTelemarketing
{
    public partial class FrmConsultarAgendados : Form
    {
        GestionDeLlamadosService gestionDeLlamadosService_ = new GestionDeLlamadosService();
        ProspectoService prospectoService_ = new ProspectoService();
        public int userId = FrmLogin.idUser;
        public FrmConsultarAgendados()
        {
            InitializeComponent();
        }
        private void InicializeComponent()
        {
            // Inicializar y configurar el DateTimePicker
            dateTimePicker1 = new DateTimePicker
            {
                Name = "dateTimePicker1",
                Dock = DockStyle.Top,
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "yyyy-MM-dd HH:mm:ss"
            };
            this.Controls.Add(dateTimePicker1);
        }


        private void FrmConsultarAgendados_Load(object sender, EventArgs e)
        {

            DataTable agendados = null!;
            // Para que siempre se vea la fecha y hora actual 
            dateTimePicker1.Value = DateTime.Now;

            // Llamar al método ListarAgendados cuando se carga el formulario
            agendados = gestionDeLlamadosService_.ListarAgendados(userId)!;

            if (agendados != null && agendados.Rows.Count > 0)
            {
                // Asignar el DataTable como origen de datos para el DataGridView
                ListadoAgendados.DataSource = agendados;

                // Añadir una columna personalizada para el nombre completo
                DataGridViewTextBoxColumn nombreCompletoColumn = new DataGridViewTextBoxColumn();
                nombreCompletoColumn.Name = "NombreCompleto";
                nombreCompletoColumn.HeaderText = "NOMBRE Y APELLIDO";
                ListadoAgendados.Columns.Add(nombreCompletoColumn);

                // Manejar el evento CellFormatting para concatenar Nombre y Apellido
                ListadoAgendados.CellFormatting += new DataGridViewCellFormattingEventHandler(ListadoAgendados_CellFormatting);
            }
            else
            {
                MessageBox.Show("No se encontraron agendados para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        //Formato de celdas del DatagridViewer
        private void ListadoAgendados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Formato de la columna "NombreCompleto"
            if (sender is DataGridView dataGridView && dataGridView.Columns[e.ColumnIndex].Name == "NombreCompleto")
            {
                if (e.RowIndex >= 0 && dataGridView.Rows[e.RowIndex].DataBoundItem != null)
                {
                    var row = ((DataRowView)dataGridView.Rows[e.RowIndex].DataBoundItem).Row;
                    string nombre = row["Nombre"].ToString();
                    string apellido = row["Apellido"].ToString();
                    e.Value = $"{nombre} {apellido}";
                }
            }

            // Cambiar el color de fondo de la fila seleccionada
            if (e.RowIndex >= 0 && ListadoAgendados.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.BackColor = Color.LightBlue;
                e.CellStyle.ForeColor = Color.Black;
            }
            else
            {
                e.CellStyle.BackColor = ListadoAgendados.DefaultCellStyle.BackColor;
                e.CellStyle.ForeColor = ListadoAgendados.DefaultCellStyle.ForeColor;
            }
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVolverLlamado_Click(object sender, EventArgs e)
        {
            Prospecto prospectoSeleccionado;
            if (ListadoAgendados.SelectedCells.Count > 0)
            {
                int datoSeleccionado = ListadoAgendados.SelectedCells[0].RowIndex;
                DataGridViewRow filaSeleccionada = ListadoAgendados.Rows[datoSeleccionado];

                //solo con el id del prospecto podemos taer los datos a pantalla
                int idProspecto = Convert.ToInt32(filaSeleccionada.Cells["IdProspecto"].Value);
                

                // Instancia del formulario FrmRealizarLlamada
                // en el panel de la derecha 
                
                frmMenu menuForm = this.ParentForm as frmMenu;
                if (menuForm != null)
                {
                    menuForm.AbrirFormInPanel(new FrmRealizarLlamada(idProspecto));
                }
                else
                {
                    MessageBox.Show("No se puede abrir Formulario", "Información", MessageBoxButtons.OK);
                }
                
                // cuando el formulario se cierra eliminamos
                // el prospecto del DataGridView y la base de datos
                gestionDeLlamadosService_.EliminarAgendado(idProspecto);
                ListadoAgendados.Rows.RemoveAt(datoSeleccionado);
            }
            else
            {
                MessageBox.Show("Seleccione un prospecto para continuar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

