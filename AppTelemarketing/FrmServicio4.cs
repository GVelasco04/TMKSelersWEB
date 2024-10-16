using AppTelemarketing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FrmServicio4 : Form
    {
        public FrmServicio4()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmMenu menuForm = this.ParentForm as frmMenu;

            // Abrir el formulario de venta en el panel contenedor
            if (menuForm != null)
            {
                menuForm.AbrirFormularioEnPanel(new frmVenta("", "", "", 0));
            }
        }*/
    }
}
