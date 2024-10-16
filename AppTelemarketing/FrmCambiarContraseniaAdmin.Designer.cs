namespace AppTelemarketing
{
    partial class FrmCambiarContraseniaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambiarContraseniaAdmin));
            btnCancelar = new Button();
            btnAceptar = new Button();
            panel1 = new Panel();
            pictureOcerrado = new PictureBox();
            pictureOabierto = new PictureBox();
            txtClaveNueva = new TextBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            pictureCerrado = new PictureBox();
            pictureAbierto = new PictureBox();
            txtClave = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureOcerrado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureOabierto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCerrado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureAbierto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(10, 68, 101);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 165, 215);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.TopLeft;
            btnCancelar.Location = new Point(481, 447);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(298, 40);
            btnCancelar.TabIndex = 63;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(10, 68, 101);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 165, 215);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Image = (Image)resources.GetObject("btnAceptar.Image");
            btnAceptar.ImageAlign = ContentAlignment.TopLeft;
            btnAceptar.Location = new Point(122, 447);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(298, 40);
            btnAceptar.TabIndex = 62;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureOcerrado);
            panel1.Controls.Add(pictureOabierto);
            panel1.Controls.Add(txtClaveNueva);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(72, 294);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 58);
            panel1.TabIndex = 61;
            // 
            // pictureOcerrado
            // 
            pictureOcerrado.Cursor = Cursors.Hand;
            pictureOcerrado.Image = (Image)resources.GetObject("pictureOcerrado.Image");
            pictureOcerrado.Location = new Point(286, 13);
            pictureOcerrado.Name = "pictureOcerrado";
            pictureOcerrado.Size = new Size(32, 32);
            pictureOcerrado.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureOcerrado.TabIndex = 50;
            pictureOcerrado.TabStop = false;
            pictureOcerrado.Click += pictureOcerrado_Click;
            // 
            // pictureOabierto
            // 
            pictureOabierto.Cursor = Cursors.Hand;
            pictureOabierto.Image = (Image)resources.GetObject("pictureOabierto.Image");
            pictureOabierto.Location = new Point(286, 13);
            pictureOabierto.Name = "pictureOabierto";
            pictureOabierto.Size = new Size(32, 32);
            pictureOabierto.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureOabierto.TabIndex = 51;
            pictureOabierto.TabStop = false;
            pictureOabierto.Click += pictureOabierto_Click;
            // 
            // txtClaveNueva
            // 
            txtClaveNueva.BackColor = Color.WhiteSmoke;
            txtClaveNueva.BorderStyle = BorderStyle.None;
            txtClaveNueva.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtClaveNueva.ForeColor = Color.Black;
            txtClaveNueva.Location = new Point(67, 13);
            txtClaveNueva.Name = "txtClaveNueva";
            txtClaveNueva.Size = new Size(217, 27);
            txtClaveNueva.TabIndex = 2;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(72, 260);
            label3.Name = "label3";
            label3.Size = new Size(247, 22);
            label3.TabIndex = 60;
            label3.Text = "Ingrese Nueva Contraseña";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureCerrado);
            panel2.Controls.Add(pictureAbierto);
            panel2.Controls.Add(txtClave);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(72, 182);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 58);
            panel2.TabIndex = 59;
            // 
            // pictureCerrado
            // 
            pictureCerrado.Cursor = Cursors.Hand;
            pictureCerrado.Image = (Image)resources.GetObject("pictureCerrado.Image");
            pictureCerrado.Location = new Point(286, 13);
            pictureCerrado.Name = "pictureCerrado";
            pictureCerrado.Size = new Size(32, 32);
            pictureCerrado.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureCerrado.TabIndex = 51;
            pictureCerrado.TabStop = false;
            pictureCerrado.Click += pictureCerrado_Click_1;
            // 
            // pictureAbierto
            // 
            pictureAbierto.Cursor = Cursors.Hand;
            pictureAbierto.Image = (Image)resources.GetObject("pictureAbierto.Image");
            pictureAbierto.Location = new Point(286, 13);
            pictureAbierto.Name = "pictureAbierto";
            pictureAbierto.Size = new Size(32, 32);
            pictureAbierto.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureAbierto.TabIndex = 52;
            pictureAbierto.TabStop = false;
            pictureAbierto.Click += pictureAbierto_Click;
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.WhiteSmoke;
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.ForeColor = Color.Black;
            txtClave.Location = new Point(67, 13);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(217, 27);
            txtClave.TabIndex = 2;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 148);
            label2.Name = "label2";
            label2.Size = new Size(243, 22);
            label2.TabIndex = 58;
            label2.Text = "Ingrese contraseña actual";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(322, 75);
            label1.Name = "label1";
            label1.Size = new Size(238, 26);
            label1.TabIndex = 57;
            label1.Text = "Cambiar Contraseña";
            // 
            // FrmCambiarContraseniaAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 562);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCambiarContraseniaAdmin";
            Text = "FrmCambiarContraseniaAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureOcerrado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureOabierto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCerrado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureAbierto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private Panel panel1;
        private PictureBox pictureOcerrado;
        private PictureBox pictureOabierto;
        private TextBox txtClaveNueva;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel panel2;
        private PictureBox pictureCerrado;
        private PictureBox pictureAbierto;
        private TextBox txtClave;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
    }
}