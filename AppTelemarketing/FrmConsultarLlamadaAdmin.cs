using AppTelemarketing.Servicios;
using System.Data;

namespace AppTelemarketing
{
    public partial class FrmConsultarLlamadaAdmin : Form
    {
        GestionDeLlamadosService GestionDeLlamadosService_ = new GestionDeLlamadosService();
        RespuestasService respuestasService_ = new RespuestasService();

        public FrmConsultarLlamadaAdmin()
        {
            InitializeComponent();
            LlenarComboRespuestas();
            LlenarComboTelemarketer();

            comboBoxTelemarketers.SelectedIndex = -1;
            comboBoxRespuestas.SelectedIndex = -1;
            comboBoxRespuestas.SelectedIndexChanged += new EventHandler(comboBoxRespuesta_SelectedIndexChanged);
            comboBoxTelemarketers.SelectedIndexChanged += new EventHandler(comboBoxTelemarketers_SelectedIndexChanged);
        }




        private void LlenarComboRespuestas()
        {
            comboBoxRespuestas.DataSource = null;
            comboBoxRespuestas.DataSource = respuestasService_.ObtenerRespuestas();
            comboBoxRespuestas.DisplayMember = "Respuesta";
            comboBoxRespuestas.ValueMember = "CodRespuesta";
        }

        private void LlenarComboTelemarketer()
        {
            comboBoxTelemarketers.DataSource = null;
            comboBoxTelemarketers.DataSource = respuestasService_.ObtenerTelemarketer();
            comboBoxTelemarketers.DisplayMember = "UserName";
            comboBoxTelemarketers.ValueMember = "UserId";
        }
        private void comboBoxRespuesta_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDataGridView();
        }

        private void comboBoxTelemarketers_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDataGridView();
        }

        private void FiltrarDataGridView()
        {
            string filtro = "";

            if (comboBoxRespuestas.SelectedValue != null)
            {
                string seleccionRespuesta = comboBoxRespuestas.SelectedValue.ToString();
                filtro += $"Convert(CodRespuesta, 'System.String') = '{seleccionRespuesta}'";
            }

            if (comboBoxTelemarketers.SelectedValue != null)
            {
                string seleccionTelemarketer = comboBoxTelemarketers.SelectedValue.ToString();
                if (!string.IsNullOrEmpty(filtro))
                    filtro += " AND ";

                filtro += $"Convert(UserId, 'System.String') = '{seleccionTelemarketer}'";
            }

            DataTable dt = (DataTable)ListadoLlamados.DataSource;

            if (dt != null)
            {
                dt.DefaultView.RowFilter = filtro;
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultarLlamadaAdmin_Load_1(object sender, EventArgs e)
        {
            DataTable llamados = null!;
            llamados = GestionDeLlamadosService_.ListarLosLlamadosAdmin();
            if (llamados != null && llamados.Rows.Count > 0)
            {
                // Asignar el DataTable como origen de datos para el DataGridView
                ListadoLlamados.DataSource = llamados;

            }
            else
            {
                MessageBox.Show("No se encontraron agendados para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}