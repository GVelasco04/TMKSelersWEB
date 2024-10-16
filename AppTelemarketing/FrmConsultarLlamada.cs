using AppTelemarketing.Servicios;
using System.Data;

namespace AppTelemarketing
{
    public partial class FrmConsultarLlamada : Form
    {
        GestionDeLlamadosService GestionDeLlamadosService_ = new GestionDeLlamadosService();
        RespuestasService respuestasService_ = new RespuestasService();
        private int userId = FrmLogin.idUser;

        public FrmConsultarLlamada()
        {
            InitializeComponent();
            LlenarComboRespuestas();
            //LlenarComboTelemarketer();

            comboBoxRespuesta.SelectedIndex = -1;
            comboBoxRespuesta.SelectedIndexChanged += new EventHandler(comboBoxRespuesta_SelectedIndexChanged);


        }
      

        private void FrmConsultarLlamada_Load(object sender, EventArgs e)
        {
            DataTable llamados = null!;
            llamados = GestionDeLlamadosService_.ListarLosLlamados(userId);
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
        


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LlenarComboRespuestas()
        {
            comboBoxRespuesta.DataSource = null;
            comboBoxRespuesta.DataSource = respuestasService_.ObtenerRespuestas();
            comboBoxRespuesta.DisplayMember = "Respuesta";
            comboBoxRespuesta.ValueMember = "CodRespuesta";
        }

        
        private void comboBoxRespuesta_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDataGridView();
        }

        private void FiltrarDataGridView()
        {
            if (comboBoxRespuesta.SelectedValue != null)
            {
                string seleccion = comboBoxRespuesta.SelectedValue.ToString();
                DataTable dt = (DataTable)ListadoLlamados.DataSource;

                if (dt != null)
                {
                    dt.DefaultView.RowFilter = string.Format("Convert(CodRespuesta, 'System.String') = '{0}'", seleccion);
                }
            }
        }
    }
}
