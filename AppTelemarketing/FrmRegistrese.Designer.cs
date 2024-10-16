namespace AppTelemarketing
{
    partial class FrmRegistrarse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarse));
            panel1 = new Panel();
            txtNombre = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            txtApellido = new TextBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            txtCorreo = new TextBox();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            txtUsuario = new TextBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            pictureBox5 = new PictureBox();
            panel5 = new Panel();
            comboBoxRol = new ComboBox();
            pictureBox6 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(83, 192);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 59);
            panel1.TabIndex = 1;
            panel1.TabStop = true;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.WhiteSmoke;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.FromArgb(172, 166, 166);
            txtNombre.Location = new Point(67, 13);
            txtNombre.Name = "txtNombre";
            txtNombre.ShortcutsEnabled = false;
            txtNombre.Size = new Size(239, 27);
            txtNombre.TabIndex = 2;
            txtNombre.Text = "Ingrese Nombre";
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(7, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtApellido);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(83, 272);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 59);
            panel2.TabIndex = 2;
            panel2.TabStop = true;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.WhiteSmoke;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.ForeColor = Color.FromArgb(172, 166, 166);
            txtApellido.Location = new Point(67, 13);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(239, 27);
            txtApellido.TabIndex = 3;
            txtApellido.Text = "Ingrese Apellido";
            txtApellido.Enter += txtApellido_Enter;
            txtApellido.Leave += txtApellido_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtCorreo);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(83, 348);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 59);
            panel3.TabIndex = 3;
            panel3.TabStop = true;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.WhiteSmoke;
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.ForeColor = Color.FromArgb(172, 166, 166);
            txtCorreo.Location = new Point(67, 13);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(239, 27);
            txtCorreo.TabIndex = 4;
            txtCorreo.Text = "Ingrese Correo";
            txtCorreo.Enter += txtCorreo_Enter;
            txtCorreo.Leave += txtCorreo_Leave;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(7, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtUsuario);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(83, 427);
            panel4.Name = "panel4";
            panel4.Size = new Size(323, 59);
            panel4.TabIndex = 4;
            panel4.TabStop = true;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.WhiteSmoke;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.FromArgb(172, 166, 166);
            txtUsuario.Location = new Point(67, 13);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(239, 27);
            txtUsuario.TabIndex = 5;
            txtUsuario.Text = "Ingrese Usuario";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(7, 8);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 103);
            label1.Name = "label1";
            label1.Size = new Size(215, 28);
            label1.TabIndex = 4;
            label1.Text = "Crear una nueva cuenta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 205, 60);
            label3.Location = new Point(31, 132);
            label3.Name = "label3";
            label3.Size = new Size(159, 38);
            label3.TabIndex = 6;
            label3.Text = "Registrese!";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.DarkSlateGray;
            btnAceptar.FlatAppearance.BorderColor = Color.White;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(181, 181, 181);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(54, 620);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(141, 42);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSlateGray;
            btnCancelar.FlatAppearance.BorderColor = Color.White;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(181, 181, 181);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(283, 620);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(141, 42);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImageLayout = ImageLayout.Center;
            pictureBox5.ErrorImage = null;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.InitialImage = (Image)resources.GetObject("pictureBox5.InitialImage");
            pictureBox5.Location = new Point(11, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(147, 62);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(comboBoxRol);
            panel5.Controls.Add(pictureBox6);
            panel5.Location = new Point(83, 512);
            panel5.Name = "panel5";
            panel5.Size = new Size(323, 59);
            panel5.TabIndex = 8;
            panel5.TabStop = true;
            // 
            // comboBoxRol
            // 
            comboBoxRol.ForeColor = Color.FromArgb(172, 166, 166);
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Items.AddRange(new object[] { "1. Administrador", "2. Usuario (Telemarketer)" });
            comboBoxRol.Location = new Point(67, 10);
            comboBoxRol.Margin = new Padding(4, 5, 4, 5);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(237, 33);
            comboBoxRol.TabIndex = 2;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(7, 8);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(40, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // FrmRegistrarse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(470, 722);
            Controls.Add(panel5);
            Controls.Add(pictureBox5);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRegistrarse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegistrese";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtNombre;
        private PictureBox pictureBox2;
        private Panel panel2;
        private TextBox txtApellido;
        private PictureBox pictureBox1;
        private Panel panel3;
        private TextBox txtCorreo;
        private PictureBox pictureBox3;
        private Panel panel4;
        private TextBox txtUsuario;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label3;
        private Button btnAceptar;
        private Button btnCancelar;
        private PictureBox pictureBox5;
        private Panel panel5;
        private ComboBox comboBoxRol;
        private PictureBox pictureBox6;
    }
}