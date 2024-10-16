namespace AppTelemarketing
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            txtUsuario = new TextBox();
            panel2 = new Panel();
            txtClave = new TextBox();
            pictureBox3 = new PictureBox();
            pictureOcerrado = new PictureBox();
            pictureOabierto = new PictureBox();
            btnIniciar = new Button();
            linkRegistrese = new LinkLabel();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            comboBoxRol = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureOcerrado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureOabierto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(7, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(89, 288);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 58);
            panel1.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.WhiteSmoke;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(67, 13);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(238, 27);
            txtUsuario.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtClave);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureOcerrado);
            panel2.Controls.Add(pictureOabierto);
            panel2.Location = new Point(89, 374);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 58);
            panel2.TabIndex = 3;
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.WhiteSmoke;
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.ForeColor = Color.Black;
            txtClave.Location = new Point(67, 13);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(209, 27);
            txtClave.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(7, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureOcerrado
            // 
            pictureOcerrado.Cursor = Cursors.Hand;
            pictureOcerrado.Image = (Image)resources.GetObject("pictureOcerrado.Image");
            pictureOcerrado.Location = new Point(282, 13);
            pictureOcerrado.Name = "pictureOcerrado";
            pictureOcerrado.Size = new Size(32, 32);
            pictureOcerrado.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureOcerrado.TabIndex = 11;
            pictureOcerrado.TabStop = false;
            pictureOcerrado.Click += pictureOcerrado_Click;
            // 
            // pictureOabierto
            // 
            pictureOabierto.Cursor = Cursors.Hand;
            pictureOabierto.Image = (Image)resources.GetObject("pictureOabierto.Image");
            pictureOabierto.Location = new Point(282, 13);
            pictureOabierto.Name = "pictureOabierto";
            pictureOabierto.Size = new Size(32, 32);
            pictureOabierto.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureOabierto.TabIndex = 10;
            pictureOabierto.TabStop = false;
            pictureOabierto.Click += pictureOabierto_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.FlatAppearance.BorderColor = Color.White;
            btnIniciar.FlatAppearance.MouseOverBackColor = Color.FromArgb(181, 181, 181);
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(89, 471);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(323, 51);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar Sesión";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // linkRegistrese
            // 
            linkRegistrese.ActiveLinkColor = Color.FromArgb(255, 205, 60);
            linkRegistrese.AutoSize = true;
            linkRegistrese.BackColor = Color.Transparent;
            linkRegistrese.ForeColor = Color.White;
            linkRegistrese.LinkColor = Color.FromArgb(255, 205, 60);
            linkRegistrese.Location = new Point(302, 553);
            linkRegistrese.Name = "linkRegistrese";
            linkRegistrese.Size = new Size(92, 25);
            linkRegistrese.TabIndex = 5;
            linkRegistrese.TabStop = true;
            linkRegistrese.Text = "Registrese";
            linkRegistrese.VisitedLinkColor = Color.Gray;
            linkRegistrese.LinkClicked += linkRegistrese_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(111, 553);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 6;
            label1.Text = "¿No tienes una cuenta?";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(157, 91);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(184, 157);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(87, 349);
            label3.Name = "label3";
            label3.Size = new Size(113, 22);
            label3.TabIndex = 9;
            label3.Text = "Contraseña";
            // 
            // comboBoxRol
            // 
            comboBoxRol.BackColor = Color.Gray;
            comboBoxRol.FlatStyle = FlatStyle.Flat;
            comboBoxRol.ForeColor = Color.White;
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Items.AddRange(new object[] { "1. Admi.", "2. Tmk." });
            comboBoxRol.Location = new Point(405, 8);
            comboBoxRol.Margin = new Padding(4, 5, 4, 5);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(77, 33);
            comboBoxRol.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(407, 12);
            label4.Name = "label4";
            label4.Size = new Size(46, 23);
            label4.TabIndex = 11;
            label4.Text = "Rol ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(88, 263);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 8;
            label2.Text = "Usuario";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(485, 639);
            Controls.Add(label4);
            Controls.Add(comboBoxRol);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(linkRegistrese);
            Controls.Add(btnIniciar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureOcerrado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureOabierto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private TextBox textBox1;
        private Panel panel2;
        private TextBox textBox2;
        private PictureBox pictureBox3;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label1;
        private TextBox txtClave;
        private Button btnIniciar;
        private LinkLabel linkRegistrese;
        private PictureBox pictureBox4;
        private PictureBox pictureOcerrado;
        private TextBox txtUsuario;
        private PictureBox pictureOabierto;
        private Label label3;
        private ComboBox comboBoxRol;
        private Label label4;
        private Label label2;
    }
}
