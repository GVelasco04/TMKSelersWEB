namespace WinFormsApp2
{
    partial class frmMenuAdmi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAdmi));
            MenuVertical = new Panel();
            btnCargarDatosEnBase = new Button();
            btnConsultarAgendados = new Button();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            txtMostrarUser = new Label();
            btnConsultarLlamadas = new Button();
            btnCambiarContrasena = new Button();
            btnSalir = new Button();
            btnConsultarVentas = new Button();
            btnRegistrosLlamadas = new Button();
            btnNuevoProspecto = new Button();
            btnSolicitudTmk = new Button();
            pictureBox2 = new PictureBox();
            BarraTitulo = new Panel();
            menuIcono = new PictureBox();
            panelContenedor = new Panel();
            MenuVertical.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuIcono).BeginInit();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(10, 68, 101);
            MenuVertical.Controls.Add(btnCargarDatosEnBase);
            MenuVertical.Controls.Add(btnConsultarAgendados);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(btnConsultarLlamadas);
            MenuVertical.Controls.Add(btnCambiarContrasena);
            MenuVertical.Controls.Add(btnSalir);
            MenuVertical.Controls.Add(btnConsultarVentas);
            MenuVertical.Controls.Add(btnRegistrosLlamadas);
            MenuVertical.Controls.Add(btnNuevoProspecto);
            MenuVertical.Controls.Add(btnSolicitudTmk);
            MenuVertical.Controls.Add(pictureBox2);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(300, 612);
            MenuVertical.TabIndex = 1;
            // 
            // btnCargarDatosEnBase
            // 
            btnCargarDatosEnBase.FlatAppearance.BorderSize = 0;
            btnCargarDatosEnBase.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 165, 215);
            btnCargarDatosEnBase.FlatStyle = FlatStyle.Flat;
            btnCargarDatosEnBase.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCargarDatosEnBase.ForeColor = Color.White;
            btnCargarDatosEnBase.Image = (Image)resources.GetObject("btnCargarDatosEnBase.Image");
            btnCargarDatosEnBase.ImageAlign = ContentAlignment.TopLeft;
            btnCargarDatosEnBase.Location = new Point(3, 460);
            btnCargarDatosEnBase.Name = "btnCargarDatosEnBase";
            btnCargarDatosEnBase.Size = new Size(298, 40);
            btnCargarDatosEnBase.TabIndex = 12;
            btnCargarDatosEnBase.Text = "   Cargar Datos en BBDD";
            btnCargarDatosEnBase.UseVisualStyleBackColor = true;
            btnCargarDatosEnBase.Click += btnCargarDatosEnBase_Click;
            // 
            // btnConsultarAgendados
            // 
            btnConsultarAgendados.FlatAppearance.BorderSize = 0;
            btnConsultarAgendados.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 165, 215);
            btnConsultarAgendados.FlatStyle = FlatStyle.Flat;
            btnConsultarAgendados.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultarAgendados.ForeColor = Color.White;
            btnConsultarAgendados.Image = (Image)resources.GetObject("btnConsultarAgendados.Image");
            btnConsultarAgendados.ImageAlign = ContentAlignment.TopLeft;
            btnConsultarAgendados.Location = new Point(1, 414);
            btnConsultarAgendados.Name = "btnConsultarAgendados";
            btnConsultarAgendados.Size = new Size(298, 40);
            btnConsultarAgendados.TabIndex = 11;
            btnConsultarAgendados.Text = "  Consultar Agendados";
            btnConsultarAgendados.UseVisualStyleBackColor = true;
            btnConsultarAgendados.Click += btnConsultarAgendados_Click_1;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(txtMostrarUser);
            panel1.Location = new Point(-1, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 38);
            panel1.TabIndex = 10;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(8, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // txtMostrarUser
            // 
            txtMostrarUser.AutoSize = true;
            txtMostrarUser.BackColor = Color.FromArgb(10, 68, 101);
            txtMostrarUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtMostrarUser.ForeColor = Color.White;
            txtMostrarUser.Location = new Point(39, 6);
            txtMostrarUser.Name = "txtMostrarUser";
            txtMostrarUser.Size = new Size(20, 28);
            txtMostrarUser.TabIndex = 9;
            txtMostrarUser.Text = "-";
            // 
            // btnConsultarLlamadas
            // 
            btnConsultarLlamadas.FlatAppearance.BorderSize = 0;
            btnConsultarLlamadas.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 165, 215);
            btnConsultarLlamadas.FlatStyle = FlatStyle.Flat;
            btnConsultarLlamadas.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultarLlamadas.ForeColor = Color.White;
            btnConsultarLlamadas.Image = (Image)resources.GetObject("btnConsultarLlamadas.Image");
            btnConsultarLlamadas.ImageAlign = ContentAlignment.TopLeft;
            btnConsultarLlamadas.Location = new Point(1, 368);
            btnConsultarLlamadas.Name = "btnConsultarLlamadas";
            btnConsultarLlamadas.Size = new Size(298, 40);
            btnConsultarLlamadas.TabIndex = 7;
            btnConsultarLlamadas.Text = " Consultar LLamadas";
            btnConsultarLlamadas.UseVisualStyleBackColor = true;
            btnConsultarLlamadas.Click += btnConsultarLlamadas_Click_1;
            // 
            // btnCambiarContrasena
            // 
            btnCambiarContrasena.FlatAppearance.BorderSize = 0;
            btnCambiarContrasena.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 165, 215);
            btnCambiarContrasena.FlatStyle = FlatStyle.Flat;
            btnCambiarContrasena.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCambiarContrasena.ForeColor = Color.White;
            btnCambiarContrasena.Image = (Image)resources.GetObject("btnCambiarContrasena.Image");
            btnCambiarContrasena.ImageAlign = ContentAlignment.TopLeft;
            btnCambiarContrasena.Location = new Point(-1, 504);
            btnCambiarContrasena.Name = "btnCambiarContrasena";
            btnCambiarContrasena.Size = new Size(298, 40);
            btnCambiarContrasena.TabIndex = 6;
            btnCambiarContrasena.Text = "   Cambiar Contraseña";
            btnCambiarContrasena.UseVisualStyleBackColor = true;
            btnCambiarContrasena.Click += btnCambiarContrasena_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 165, 215);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.TopLeft;
            btnSalir.Location = new Point(5, 550);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(298, 40);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnConsultarVentas
            // 
            btnConsultarVentas.FlatAppearance.BorderSize = 0;
            btnConsultarVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 165, 215);
            btnConsultarVentas.FlatStyle = FlatStyle.Flat;
            btnConsultarVentas.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultarVentas.ForeColor = Color.White;
            btnConsultarVentas.Image = (Image)resources.GetObject("btnConsultarVentas.Image");
            btnConsultarVentas.ImageAlign = ContentAlignment.TopLeft;
            btnConsultarVentas.Location = new Point(1, 322);
            btnConsultarVentas.Name = "btnConsultarVentas";
            btnConsultarVentas.Size = new Size(298, 40);
            btnConsultarVentas.TabIndex = 4;
            btnConsultarVentas.Text = "Consultar Ventas";
            btnConsultarVentas.UseVisualStyleBackColor = true;
            btnConsultarVentas.Click += btnConsultarVentas_Click_1;
            // 
            // btnRegistrosLlamadas
            // 
            btnRegistrosLlamadas.FlatAppearance.BorderSize = 0;
            btnRegistrosLlamadas.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 165, 215);
            btnRegistrosLlamadas.FlatStyle = FlatStyle.Flat;
            btnRegistrosLlamadas.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrosLlamadas.ForeColor = Color.White;
            btnRegistrosLlamadas.Image = (Image)resources.GetObject("btnRegistrosLlamadas.Image");
            btnRegistrosLlamadas.ImageAlign = ContentAlignment.TopLeft;
            btnRegistrosLlamadas.Location = new Point(0, 276);
            btnRegistrosLlamadas.Name = "btnRegistrosLlamadas";
            btnRegistrosLlamadas.Size = new Size(298, 40);
            btnRegistrosLlamadas.TabIndex = 3;
            btnRegistrosLlamadas.Text = "    Registros de Respuestas";
            btnRegistrosLlamadas.UseVisualStyleBackColor = true;
            btnRegistrosLlamadas.Click += btnRegistrosLlamadas_Click_1;
            // 
            // btnNuevoProspecto
            // 
            btnNuevoProspecto.FlatAppearance.BorderSize = 0;
            btnNuevoProspecto.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 165, 215);
            btnNuevoProspecto.FlatStyle = FlatStyle.Flat;
            btnNuevoProspecto.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoProspecto.ForeColor = Color.White;
            btnNuevoProspecto.Image = (Image)resources.GetObject("btnNuevoProspecto.Image");
            btnNuevoProspecto.ImageAlign = ContentAlignment.TopLeft;
            btnNuevoProspecto.Location = new Point(-1, 230);
            btnNuevoProspecto.Name = "btnNuevoProspecto";
            btnNuevoProspecto.Size = new Size(298, 40);
            btnNuevoProspecto.TabIndex = 2;
            btnNuevoProspecto.Text = "  Nuevo Prospecto";
            btnNuevoProspecto.UseVisualStyleBackColor = true;
            btnNuevoProspecto.Click += btnNuevoProspecto_Click;
            // 
            // btnSolicitudTmk
            // 
            btnSolicitudTmk.FlatAppearance.BorderSize = 0;
            btnSolicitudTmk.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 165, 215);
            btnSolicitudTmk.FlatStyle = FlatStyle.Flat;
            btnSolicitudTmk.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSolicitudTmk.ForeColor = Color.White;
            btnSolicitudTmk.Image = (Image)resources.GetObject("btnSolicitudTmk.Image");
            btnSolicitudTmk.ImageAlign = ContentAlignment.TopLeft;
            btnSolicitudTmk.Location = new Point(4, 186);
            btnSolicitudTmk.Name = "btnSolicitudTmk";
            btnSolicitudTmk.Size = new Size(298, 40);
            btnSolicitudTmk.TabIndex = 1;
            btnSolicitudTmk.Text = "   Administrar Telemarketer";
            btnSolicitudTmk.UseVisualStyleBackColor = true;
            btnSolicitudTmk.Click += btnSolicitudTmk_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(280, 137);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(29, 138, 199);
            BarraTitulo.Controls.Add(menuIcono);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(300, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(850, 50);
            BarraTitulo.TabIndex = 2;
            // 
            // menuIcono
            // 
            menuIcono.Image = (Image)resources.GetObject("menuIcono.Image");
            menuIcono.Location = new Point(6, 9);
            menuIcono.Name = "menuIcono";
            menuIcono.Size = new Size(35, 35);
            menuIcono.SizeMode = PictureBoxSizeMode.Zoom;
            menuIcono.TabIndex = 0;
            menuIcono.TabStop = false;
            menuIcono.Click += menuIcono_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(17, 106, 156);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(300, 50);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(850, 562);
            panelContenedor.TabIndex = 3;
            // 
            // frmMenuAdmi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 612);
            Controls.Add(panelContenedor);
            Controls.Add(BarraTitulo);
            Controls.Add(MenuVertical);
            Name = "frmMenuAdmi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuAdmin";
            MenuVertical.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuIcono).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private Panel MenuVertical;
        private PictureBox pictureBox2;
        private PictureBox menuIcono;
        private Panel panelContenedor;
        private Button btnSolicitudTmk;
        private Button btnSalir;
        private Button btnConsultarVentas;
        private Button btnRegistrosLlamadas;
        private Button btnNuevoProspecto;
        private Button btnConsultarLlamadas;
        private Button btnCambiarContrasena;
        private Label txtMostrarUser;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Button btnConsultarAgendados;
        private Button btnCargarDatosEnBase;
    }
}
