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
    public partial class FrmRegistroRespuestasAdmin : Form
    {
        InformesService informesService_ = new InformesService();
        RespuestasService respuestasService_ = new RespuestasService();
        private int userId = FrmLogin.idUser;
        public FrmRegistroRespuestasAdmin()
        {
            InitializeComponent();
            LlenarComboTelemarketer();
            comboBoxTelemarketers.SelectedIndex = -1;

            comboBoxTelemarketers.SelectedIndexChanged += new EventHandler(comboBoxTelemarketers_SelectedIndexChanged);
        }


        private void FrmRegistroRespuestasAdmin_Load(object sender, EventArgs e)
        {
            DataTable totalesLlamadas = null!;
            registroLlamadas.AutoGenerateColumns = false; // Deshabilitar la generación automática de columnas

            totalesLlamadas = informesService_.ListarLlamadosProspectosAdmin();

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
                DataTable dt = (DataTable)registroLlamadas.DataSource;

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

        private void pictureBoxAjustes_Click(object sender, EventArgs e)
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
