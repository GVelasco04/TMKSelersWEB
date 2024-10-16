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
    public partial class FrmAdministrarTmk : Form
    {
        UsuarioService usuarioService = new UsuarioService();
        RespuestasService respuestasService = new RespuestasService();
        public FrmAdministrarTmk()
        {
            InitializeComponent();
            LlenarGridUsuarios();
            //LlenarComboAprobacion();
            //comboBoxAprobacion.SelectedIndexChanged += new EventHandler(comboBoxAprobacion_SelectedIndexChanged);

        }

        private void LlenarGridUsuarios()
        {
            var usuarios = usuarioService.MostrarUsuarios();

            if (usuarios == null || usuarios.Count == 0)
            {
                MessageBox.Show("No se encontraron usuarios.");
            }
            else
            {
                SolicitudTkm.DataSource = null; // Opcional, para limpiar el DataSource anterior
                SolicitudTkm.DataSource = usuarios;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptarSoli_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una celda
            if (SolicitudTkm.SelectedCells.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = SolicitudTkm.Rows[SolicitudTkm.SelectedCells[0].RowIndex];

                // Obtener el UserId del usuario seleccionado utilizando el índice de la columna correspondiente
                int userIdSeleccionado = Convert.ToInt32(selectedRow.Cells["ColUserId"].Value);

                // Llamar al método para aprobar al usuario
                Usuario usuarioAprobado = usuarioService.AprobarUsuario(userIdSeleccionado);

                if (usuarioAprobado != null)
                {
                    // Enviar correo electrónico con la clave temporal
                    MailData mailData = new MailData
                    {
                        Mailto = usuarioAprobado.Correo,
                        Subject = "Registro de usuarios sistema de Telemarketing",
                        Body = $"Hola {usuarioAprobado.UserName},\n\nTu solicitud ha sido aprobada. Aquí está tu clave temporal: {usuarioAprobado.Clave}\n\nSaludos,\nEl equipo de Telemarketing"
                    };

                    MailServices mailService = new MailServices();
                    mailService.SendMail(mailData);

                    // Actualizar la vista
                    frmMenuAdmi frmMenuAdmi = this.ParentForm as frmMenuAdmi;
                    if (frmMenuAdmi != null)
                    {
                        frmMenuAdmi.AbrirFormularioEnPanel(new FrmAdministrarTmk());
                    }

                    MessageBox.Show("Usuario aprobado correctamente y notificado por correo.");
                }
                else
                {
                    MessageBox.Show("No se pudo aprobar al usuario.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario.");
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una celda
            if (SolicitudTkm.SelectedCells.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = SolicitudTkm.Rows[SolicitudTkm.SelectedCells[0].RowIndex];

                // Obtener el UserId del usuario seleccionado utilizando el índice de la columna correspondiente
                int userIdSeleccionado = Convert.ToInt32(selectedRow.Cells[0].Value); // Asumiendo que la columna UserId tiene el nombre ColUserId

                // Mostrar mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar al usuario?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Llamar al método para dar de baja al usuario
                    if (usuarioService.EliminarUsuario(userIdSeleccionado))
                    {
                        frmMenuAdmi frmMenuAdmi = this.ParentForm as frmMenuAdmi; //permite refrescar
                        if (frmMenuAdmi != null)
                        {
                            frmMenuAdmi.AbrirFormularioEnPanel(new FrmAdministrarTmk());
                        }

                        MessageBox.Show("Usuario eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar al usuario.");

                    }
                }
            }
        }
        
        /*private void LlenarComboAprobacion()
        {
            

            comboBoxAprobacion.DataSource = null;
            comboBoxAprobacion.DataSource = respuestasService.ObtenerAprobacion();
            comboBoxAprobacion.DisplayMember = "AceptadoXAdmin";
            //comboBoxAprobacion.ValueMember= "AceptadoXAdmin";



        }

        /*private void FiltrarDataGridView()
        {
            if (comboBoxAprobacion.SelectedValue != null)
            {
                // Convierte el valor seleccionado a short si la columna es de tipo short
                if (short.TryParse(comboBoxAprobacion.SelectedValue.ToString(), out short seleccion))
                {
                    DataTable dt = (DataTable)SolicitudTkm.DataSource;

                    if (dt != null)
                    {
                        // Usa la conversión adecuada para el tipo de datos
                        dt.DefaultView.RowFilter = string.Format("AceptadoXAdmin = {0}", seleccion);
                    }
                }
            }
        }*/




        private void comboBoxAprobacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FiltrarDataGridView();
        }
    }
}
