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
    public partial class FrmConsultarAgendadosAdmin : Form

    {
        GestionDeLlamadosService gestionDeLlamadosService_ = new GestionDeLlamadosService();
        ProspectoService prospectoService_ = new ProspectoService();
        RespuestasService respuestasService_ = new RespuestasService();

        public FrmConsultarAgendadosAdmin()
        {
            InitializeComponent();
            LlenarComboTelemarketer();
            comboBoxTelemarketers.SelectedIndex = -1;
            comboBoxTelemarketers.SelectedIndexChanged += new EventHandler(comboBoxTelemarketers_SelectedIndexChanged);
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


        private void FrmConsultarAgendadosAdmin_Load(object sender, EventArgs e)
        {
            /*DataTable agendados = null!;
            // Para que siempre se vea la fecha y hora actual 
            dateTimePicker1.Value = DateTime.Now;

            // Llamar al método ListarAgendados cuando se carga el formulario
            agendados = gestionDeLlamadosService_.ListarAgendados(0)!;

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
                ListadoAgendados.CellFormatting += new DataGridViewCellFormattingEventHandler(ListadoAgendados_CellFormatting_1);
            }
            else
            {
                MessageBox.Show("No se encontraron agendados para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
            DataTable agendados = null!;
            // Para que siempre se vea la fecha y hora actual 
            dateTimePicker1.Value = DateTime.Now;

            // Llamar al método ListarAgendados cuando se carga el formulario
            agendados = gestionDeLlamadosService_.ListarAgendadosAdmin()!;

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
                ListadoAgendados.CellFormatting += new DataGridViewCellFormattingEventHandler(ListadoAgendados_CellFormatting_1);
            }
            else
            {
                MessageBox.Show("No se encontraron agendados para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListadoAgendados_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
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
        private void LlenarComboTelemarketer()
        {
            comboBoxTelemarketers.DataSource = null;
            comboBoxTelemarketers.DataSource = respuestasService_.ObtenerTelemarketer();
            comboBoxTelemarketers.DisplayMember = "UserName";
            comboBoxTelemarketers.ValueMember = "UserId";
        }
        private void comboBoxTelemarketers_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDataGridView();
        }
       
        private void FiltrarDataGridView()
        {
            if (comboBoxTelemarketers.SelectedValue != null)
            {
                string seleccion = comboBoxTelemarketers.SelectedValue.ToString();
                DataTable dt = (DataTable)ListadoAgendados.DataSource;

                if (dt != null)
                {
                    dt.DefaultView.RowFilter = string.Format("Convert(UserId, 'System.String') = '{0}'", seleccion);
                }
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
