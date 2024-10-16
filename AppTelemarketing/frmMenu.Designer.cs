namespace WinFormsApp2
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            MenuVertical = new Panel();
            btnConsultarAgendados = new Button();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            txtMostrarUser = new Label();
            pictureBox1 = new PictureBox();
            btnConsultarLlamadas = new Button();
            btnCambiarContrasena = new Button();
            btnSalir = new Button();
            btnConsultarVentas = new Button();
            btnRegistrosRespuestas = new Button();
            btnRealizarLlamados = new Button();
            btnNuevoUsuario = new Button();
            pictureBox2 = new PictureBox();
            BarraTitulo = new Panel();
            menuIcono = new PictureBox();
            panelContenedor = new Panel();
            MenuVertical.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuIcono).BeginInit();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(0, 61, 59);
            MenuVertical.Controls.Add(btnConsultarAgendados);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Controls.Add(btnConsultarLlamadas);
            MenuVertical.Controls.Add(btnCambiarContrasena);
            MenuVertical.Controls.Add(btnSalir);
            MenuVertical.Controls.Add(btnConsultarVentas);
            MenuVertical.Controls.Add(btnRegistrosRespuestas);
            MenuVertical.Controls.Add(btnRealizarLlamados);
            MenuVertical.Controls.Add(btnNuevoUsuario);
            MenuVertical.Controls.Add(pictureBox2);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(300, 612);
            MenuVertical.TabIndex = 1;
            // 
            // btnConsultarAgendados
            // 
            btnConsultarAgendados.FlatAppearance.BorderSize = 0;
            btnConsultarAgendados.FlatAppearance.MouseOverBackColor = Color.FromArgb(131, 182, 181);
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
            btnConsultarAgendados.Click += btnConsultarAgendados_Click;
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
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // txtMostrarUser
            // 
            txtMostrarUser.AutoSize = true;
            txtMostrarUser.BackColor = Color.FromArgb(0, 61, 59);
            txtMostrarUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtMostrarUser.ForeColor = Color.White;
            txtMostrarUser.Location = new Point(39, 6);
            txtMostrarUser.Name = "txtMostrarUser";
            txtMostrarUser.Size = new Size(20, 28);
            txtMostrarUser.TabIndex = 9;
            txtMostrarUser.Text = "-";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(208, 571);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnConsultarLlamadas
            // 
            btnConsultarLlamadas.FlatAppearance.BorderSize = 0;
            btnConsultarLlamadas.FlatAppearance.MouseOverBackColor = Color.FromArgb(131, 182, 181);
            btnConsultarLlamadas.FlatStyle = FlatStyle.Flat;
            btnConsultarLlamadas.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultarLlamadas.ForeColor = Color.White;
            btnConsultarLlamadas.Image = (Image)resources.GetObject("btnConsultarLlamadas.Image");
            btnConsultarLlamadas.ImageAlign = ContentAlignment.TopLeft;
            btnConsultarLlamadas.Location = new Point(0, 368);
            btnConsultarLlamadas.Name = "btnConsultarLlamadas";
            btnConsultarLlamadas.Size = new Size(298, 40);
            btnConsultarLlamadas.TabIndex = 7;
            btnConsultarLlamadas.Text = " Consultar LLamadas";
            btnConsultarLlamadas.UseVisualStyleBackColor = true;
            btnConsultarLlamadas.Click += btnConsultarLlamadas_Click;
            // 
            // btnCambiarContrasena
            // 
            btnCambiarContrasena.FlatAppearance.BorderSize = 0;
            btnCambiarContrasena.FlatAppearance.MouseOverBackColor = Color.FromArgb(131, 182, 181);
            btnCambiarContrasena.FlatStyle = FlatStyle.Flat;
            btnCambiarContrasena.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCambiarContrasena.ForeColor = Color.White;
            btnCambiarContrasena.Image = (Image)resources.GetObject("btnCambiarContrasena.Image");
            btnCambiarContrasena.ImageAlign = ContentAlignment.TopLeft;
            btnCambiarContrasena.Location = new Point(-2, 459);
            btnCambiarContrasena.Name = "btnCambiarContrasena";
            btnCambiarContrasena.Size = new Size(298, 40);
            btnCambiarContrasena.TabIndex = 6;
            btnCambiarContrasena.Text = "   Cambiar Contraseña";
            btnCambiarContrasena.UseVisualStyleBackColor = true;
            btnCambiarContrasena.Click += btnCambiarContrasena_Click;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(131, 182, 181);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.TopLeft;
            btnSalir.Location = new Point(5, 507);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(298, 40);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConsultarVentas
            // 
            btnConsultarVentas.FlatAppearance.BorderSize = 0;
            btnConsultarVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(131, 182, 181);
            btnConsultarVentas.FlatStyle = FlatStyle.Flat;
            btnConsultarVentas.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultarVentas.ForeColor = Color.White;
            btnConsultarVentas.Image = (Image)resources.GetObject("btnConsultarVentas.Image");
            btnConsultarVentas.ImageAlign = ContentAlignment.TopLeft;
            btnConsultarVentas.Location = new Point(0, 322);
            btnConsultarVentas.Name = "btnConsultarVentas";
            btnConsultarVentas.Size = new Size(298, 40);
            btnConsultarVentas.TabIndex = 4;
            btnConsultarVentas.Text = "Consultar Ventas";
            btnConsultarVentas.UseVisualStyleBackColor = true;
            btnConsultarVentas.Click += btnConsultarVentas_Click;
            // 
            // btnRegistrosRespuestas
            // 
            btnRegistrosRespuestas.FlatAppearance.BorderSize = 0;
            btnRegistrosRespuestas.FlatAppearance.MouseOverBackColor = Color.FromArgb(131, 182, 181);
            btnRegistrosRespuestas.FlatStyle = FlatStyle.Flat;
            btnRegistrosRespuestas.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrosRespuestas.ForeColor = Color.White;
            btnRegistrosRespuestas.Image = (Image)resources.GetObject("btnRegistrosRespuestas.Image");
            btnRegistrosRespuestas.ImageAlign = ContentAlignment.TopLeft;
            btnRegistrosRespuestas.Location = new Point(0, 276);
            btnRegistrosRespuestas.Name = "btnRegistrosRespuestas";
            btnRegistrosRespuestas.Size = new Size(298, 40);
            btnRegistrosRespuestas.TabIndex = 3;
            btnRegistrosRespuestas.Text = "    Registros de Respuestas\r\n";
            btnRegistrosRespuestas.UseVisualStyleBackColor = true;
            btnRegistrosRespuestas.Click += btnRegistrosLlamadas_Click;
            // 
            // btnRealizarLlamados
            // 
            btnRealizarLlamados.FlatAppearance.BorderSize = 0;
            btnRealizarLlamados.FlatAppearance.MouseOverBackColor = Color.FromArgb(131, 182, 181);
            btnRealizarLlamados.FlatStyle = FlatStyle.Flat;
            btnRealizarLlamados.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRealizarLlamados.ForeColor = Color.White;
            btnRealizarLlamados.Image = (Image)resources.GetObject("btnRealizarLlamados.Image");
            btnRealizarLlamados.ImageAlign = ContentAlignment.TopLeft;
            btnRealizarLlamados.Location = new Point(0, 230);
            btnRealizarLlamados.Name = "btnRealizarLlamados";
            btnRealizarLlamados.Size = new Size(298, 40);
            btnRealizarLlamados.TabIndex = 2;
            btnRealizarLlamados.Text = "  Realizar Llamados";
            btnRealizarLlamados.UseVisualStyleBackColor = true;
            btnRealizarLlamados.Click += btnRealizarLlamados_Click;
            // 
            // btnNuevoUsuario
            // 
            btnNuevoUsuario.FlatAppearance.BorderSize = 0;
            btnNuevoUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(131, 182, 181);
            btnNuevoUsuario.FlatStyle = FlatStyle.Flat;
            btnNuevoUsuario.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoUsuario.ForeColor = Color.White;
            btnNuevoUsuario.Image = (Image)resources.GetObject("btnNuevoUsuario.Image");
            btnNuevoUsuario.ImageAlign = ContentAlignment.TopLeft;
            btnNuevoUsuario.Location = new Point(0, 184);
            btnNuevoUsuario.Name = "btnNuevoUsuario";
            btnNuevoUsuario.Size = new Size(298, 40);
            btnNuevoUsuario.TabIndex = 1;
            btnNuevoUsuario.Text = "  Nuevo Prospecto";
            btnNuevoUsuario.UseVisualStyleBackColor = true;
            btnNuevoUsuario.Click += btnNuevoUsuario_Click;
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
            BarraTitulo.BackColor = Color.FromArgb(7, 130, 126);
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
            panelContenedor.BackColor = Color.FromArgb(1, 107, 104);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(300, 50);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(850, 562);
            panelContenedor.TabIndex = 3;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 612);
            Controls.Add(panelContenedor);
            Controls.Add(BarraTitulo);
            Controls.Add(MenuVertical);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            MenuVertical.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button btnNuevoUsuario;
        private Button btnSalir;
        private Button btnConsultarVentas;
        private Button btnRegistrosRespuestas;
        private Button btnRealizarLlamados;
        private Button btnConsultarLlamadas;
        private Button btnCambiarContrasena;
        private PictureBox pictureBox1;
        private Label txtMostrarUser;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Button btnConsultarAgendados;
    }
}
