using AppTelemarketing.Servicios;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FrmConsultarVentasAdmin : Form
    {
        VentasService ventasService_ = new VentasService();
        RespuestasService respuestasService_ = new RespuestasService();


        public FrmConsultarVentasAdmin()
        {
            InitializeComponent();
            LlenarComboTelemarketer();
            comboBoxTelemarketers.SelectedIndex = -1;
            comboBoxTelemarketers.SelectedIndexChanged += new EventHandler(comboBoxTelemarketers_SelectedIndexChanged);
            // Añadir y configurar el Label para mostrar la fecha actual
            Label fechaLabel = new Label
            {
                Name = "fechaLabel",
                Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), // Formato de fecha y hora
                Dock = DockStyle.Top,
                AutoSize = true
            };
            this.Controls.Add(fechaLabel);
            ListadoVentas.AutoGenerateColumns = false;//para que no se autogeneren columnas no deseadas
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
                DataTable dt = (DataTable)ListadoVentas.DataSource;

                if (dt != null)
                {
                    dt.DefaultView.RowFilter = string.Format("Convert(UserId, 'System.String') = '{0}'", seleccion);
                }
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmConsultarVentasAdmin_Load(object sender, EventArgs e)
        {
            /*DataTable ventas = ventasService_.ObtenerVentas(0)!;

            if (ventas != null && ventas.Rows.Count > 0)
            {
                // Asignar el DataTable como origen de datos para el DataGridView
                ListadoVentas.DataSource = ventas;


                // Añadir una columna personalizada para el nombre completo
                DataGridViewTextBoxColumn nombreCompleto = new DataGridViewTextBoxColumn();
                nombreCompleto.Name = "ApellidoNombre";
                nombreCompleto.HeaderText = "NOMBRE CLIENTE";


                // Manejar el evento CellFormatting para concatenar Nombre y Apellido
                ListadoVentas.CellFormatting += new DataGridViewCellFormattingEventHandler(ListadoVentas_CellFormatting);
            }
            else
            {
                MessageBox.Show("No se encontraron Ventas para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
            DataTable ventas = ventasService_.ObtenerVentasAdmin()!;

            if (ventas != null && ventas.Rows.Count > 0)
            {
                // Asignar el DataTable como origen de datos para el DataGridView
                ListadoVentas.DataSource = ventas;


                // Añadir una columna personalizada para el nombre completo
                DataGridViewTextBoxColumn nombreCompleto = new DataGridViewTextBoxColumn();
                nombreCompleto.Name = "ApellidoNombre";
                nombreCompleto.HeaderText = "NOMBRE CLIENTE";


                // Manejar el evento CellFormatting para concatenar Nombre y Apellido
                ListadoVentas.CellFormatting += new DataGridViewCellFormattingEventHandler(ListadoVentas_CellFormatting);
            }
            else
            {
                MessageBox.Show("No se encontraron Ventas para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListadoVentas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            // Formato de la columna "ApellidoNombre"
            if (sender is DataGridView dataGridView && dataGridView.Columns[e.ColumnIndex].Name == "ApellidoNombre")
            {
                if (e.RowIndex >= 0 && dataGridView.Rows[e.RowIndex].DataBoundItem != null)
                {
                    var row = ((DataRowView)dataGridView.Rows[e.RowIndex].DataBoundItem).Row;
                    string nombre = row["Nombre"].ToString();
                    string apellido = row["Apellido"].ToString();
                    e.Value = $"{nombre} {apellido}";
                }
            }
        }
    }
}
