using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using AppTelemarketing;
using AppTelemarketing.Servicios;
namespace WinFormsApp2
{
    public partial class FrmRegistroRespuestas : Form
    {
        InformesService informesService_ = new InformesService();
        private int userId = FrmLogin.idUser;
        public FrmRegistroRespuestas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void FrmRegistroLlamada_Load(object sender, EventArgs e)
        {

            DataTable totalesLlamadas = null!;
            registroLlamadas.AutoGenerateColumns = false; // Deshabilitar la generación automática de columnas

            totalesLlamadas = informesService_.ListarLlamadosProspectos(userId);

            if (totalesLlamadas != null && totalesLlamadas.Rows.Count > 0)
            {
                // Asignar el DataTable como origen de datos para el DataGridView
                registroLlamadas.DataSource = totalesLlamadas;
            }
            else
            {
                MessageBox.Show("No se encontraron datos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
