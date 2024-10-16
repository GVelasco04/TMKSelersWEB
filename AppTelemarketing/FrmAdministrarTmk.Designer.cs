namespace AppTelemarketing
{
    partial class FrmAdministrarTmk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrarTmk));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            btnVolver = new Button();
            SolicitudTkm = new DataGridView();
            ColUserId = new DataGridViewTextBoxColumn();
            ColUser = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColApellido = new DataGridViewTextBoxColumn();
            ColCorreo = new DataGridViewTextBoxColumn();
            ColClave = new DataGridViewTextBoxColumn();
            ColTip = new DataGridViewTextBoxColumn();
            ColEstado = new DataGridViewTextBoxColumn();
            BtnAceptarSoli = new Button();
            BtnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)SolicitudTkm).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(292, 55);
            label1.Name = "label1";
            label1.Size = new Size(289, 26);
            label1.TabIndex = 50;
            label1.Text = "Administrar Telemarketers";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(10, 68, 101);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 165, 215);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.White;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.ImageAlign = ContentAlignment.TopLeft;
            btnVolver.Location = new Point(622, 519);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(225, 40);
            btnVolver.TabIndex = 58;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // SolicitudTkm
            // 
            SolicitudTkm.AllowUserToAddRows = false;
            SolicitudTkm.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.PowderBlue;
            SolicitudTkm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            SolicitudTkm.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(10, 68, 101);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(10, 68, 101);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            SolicitudTkm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            SolicitudTkm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SolicitudTkm.Columns.AddRange(new DataGridViewColumn[] { ColUserId, ColUser, ColNombre, ColApellido, ColCorreo, ColClave, ColTip, ColEstado });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.SteelBlue;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.PowderBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            SolicitudTkm.DefaultCellStyle = dataGridViewCellStyle6;
            SolicitudTkm.EnableHeadersVisualStyles = false;
            SolicitudTkm.GridColor = SystemColors.Control;
            SolicitudTkm.Location = new Point(2, 89);
            SolicitudTkm.Margin = new Padding(4);
            SolicitudTkm.Name = "SolicitudTkm";
            SolicitudTkm.ReadOnly = true;
            SolicitudTkm.RowHeadersVisible = false;
            SolicitudTkm.RowHeadersWidth = 51;
            SolicitudTkm.RowTemplate.Height = 29;
            SolicitudTkm.Size = new Size(845, 343);
            SolicitudTkm.TabIndex = 61;
            // 
            // ColUserId
            // 
            ColUserId.DataPropertyName = "UserId";
            ColUserId.HeaderText = "ID";
            ColUserId.MinimumWidth = 6;
            ColUserId.Name = "ColUserId";
            ColUserId.ReadOnly = true;
            ColUserId.Width = 125;
            // 
            // ColUser
            // 
            ColUser.DataPropertyName = "UserName";
            ColUser.HeaderText = "USERNAME";
            ColUser.MinimumWidth = 6;
            ColUser.Name = "ColUser";
            ColUser.ReadOnly = true;
            ColUser.Width = 125;
            // 
            // ColNombre
            // 
            ColNombre.DataPropertyName = "Nombre";
            ColNombre.HeaderText = "NOMBRE";
            ColNombre.MinimumWidth = 6;
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            ColNombre.Width = 125;
            // 
            // ColApellido
            // 
            ColApellido.DataPropertyName = "Apellido";
            ColApellido.HeaderText = "APELLIDO";
            ColApellido.MinimumWidth = 6;
            ColApellido.Name = "ColApellido";
            ColApellido.ReadOnly = true;
            ColApellido.Width = 125;
            // 
            // ColCorreo
            // 
            ColCorreo.DataPropertyName = "Correo";
            ColCorreo.HeaderText = "CORREO";
            ColCorreo.MinimumWidth = 6;
            ColCorreo.Name = "ColCorreo";
            ColCorreo.ReadOnly = true;
            ColCorreo.Width = 125;
            // 
            // ColClave
            // 
            ColClave.DataPropertyName = "Clave";
            ColClave.HeaderText = "CLAVE";
            ColClave.MinimumWidth = 6;
            ColClave.Name = "ColClave";
            ColClave.ReadOnly = true;
            ColClave.Width = 125;
            // 
            // ColTip
            // 
            ColTip.DataPropertyName = "TipoUsuario";
            ColTip.HeaderText = "TIPO DE USUARIO";
            ColTip.MinimumWidth = 6;
            ColTip.Name = "ColTip";
            ColTip.ReadOnly = true;
            ColTip.Width = 125;
            // 
            // ColEstado
            // 
            ColEstado.DataPropertyName = "AceptadoXAdmin";
            ColEstado.HeaderText = "ESTADO DE APROBACION";
            ColEstado.MinimumWidth = 6;
            ColEstado.Name = "ColEstado";
            ColEstado.ReadOnly = true;
            ColEstado.Width = 125;
            // 
            // BtnAceptarSoli
            // 
            BtnAceptarSoli.BackColor = Color.FromArgb(10, 68, 101);
            BtnAceptarSoli.FlatAppearance.BorderSize = 0;
            BtnAceptarSoli.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 165, 215);
            BtnAceptarSoli.FlatStyle = FlatStyle.Flat;
            BtnAceptarSoli.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAceptarSoli.ForeColor = Color.White;
            BtnAceptarSoli.Image = (Image)resources.GetObject("BtnAceptarSoli.Image");
            BtnAceptarSoli.ImageAlign = ContentAlignment.TopLeft;
            BtnAceptarSoli.Location = new Point(2, 437);
            BtnAceptarSoli.Margin = new Padding(2);
            BtnAceptarSoli.Name = "BtnAceptarSoli";
            BtnAceptarSoli.Size = new Size(197, 40);
            BtnAceptarSoli.TabIndex = 62;
            BtnAceptarSoli.Text = "Aceptar Solicitud TMK";
            BtnAceptarSoli.UseVisualStyleBackColor = false;
            BtnAceptarSoli.Click += BtnAceptarSoli_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.FromArgb(10, 68, 101);
            BtnEliminar.FlatAppearance.BorderSize = 0;
            BtnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 165, 215);
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEliminar.ForeColor = Color.White;
            BtnEliminar.Image = (Image)resources.GetObject("BtnEliminar.Image");
            BtnEliminar.ImageAlign = ContentAlignment.TopLeft;
            BtnEliminar.Location = new Point(203, 437);
            BtnEliminar.Margin = new Padding(2);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(197, 40);
            BtnEliminar.TabIndex = 63;
            BtnEliminar.Text = "Eliminar TMK";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // FrmAdministrarTmk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 562);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnAceptarSoli);
            Controls.Add(SolicitudTkm);
            Controls.Add(btnVolver);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAdministrarTmk";
            Text = "FrmSolicitudTmk";
            ((System.ComponentModel.ISupportInitialize)SolicitudTkm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnVolver;
        private DataGridView SolicitudTkm;
        private DataGridViewTextBoxColumn ColUserId;
        private DataGridViewTextBoxColumn ColUser;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColApellido;
        private DataGridViewTextBoxColumn ColCorreo;
        private DataGridViewTextBoxColumn ColClave;
        private DataGridViewTextBoxColumn ColTip;
        private DataGridViewTextBoxColumn ColEstado;
        private Button BtnAceptarSoli;
        private Button BtnEliminar;
    }
}