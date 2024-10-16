namespace AppTelemarketing
{
    partial class FrmCambiarContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambiarContrasena));
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            pictureCerrado = new PictureBox();
            pictureAbierto = new PictureBox();
            txtClave = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureOcerrado = new PictureBox();
            pictureOabierto = new PictureBox();
            txtClaveNueva = new TextBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCerrado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureAbierto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureOcerrado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureOabierto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(313, 62);
            label1.Name = "label1";
            label1.Size = new Size(238, 26);
            label1.TabIndex = 26;
            label1.Text = "Cambiar Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(56, 139);
            label2.Name = "label2";
            label2.Size = new Size(243, 22);
            label2.TabIndex = 44;
            label2.Text = "Ingrese contraseña actual";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureCerrado);
            panel2.Controls.Add(pictureAbierto);
            panel2.Controls.Add(txtClave);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(56, 173);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 58);
            panel2.TabIndex = 45;
            // 
            // pictureCerrado
            // 
            pictureCerrado.Cursor = Cursors.Hand;
            pictureCerrado.Image = (Image)resources.GetObject("pictureCerrado.Image");
            pictureCerrado.Location = new Point(286, 13);
            pictureCerrado.Name = "pictureCerrado";
            pictureCerrado.Size = new Size(32, 32);
            pictureCerrado.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureCerrado.TabIndex = 51;
            pictureCerrado.TabStop = false;
            pictureCerrado.Click += pictureCerrado_Click;
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
            pictureAbierto.Click += pictureAbierto_Click_1;
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
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureOcerrado);
            panel1.Controls.Add(pictureOabierto);
            panel1.Controls.Add(txtClaveNueva);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(56, 285);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 58);
            panel1.TabIndex = 47;
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
            pictureOcerrado.Click += pictureOcerrado_Click_1;
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
            pictureOabierto.Click += pictureOabierto_Click_1;
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
            label3.Location = new Point(56, 251);
            label3.Name = "label3";
            label3.Size = new Size(247, 22);
            label3.TabIndex = 46;
            label3.Text = "Ingrese Nueva Contraseña";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(0, 61, 59);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(131, 182, 181);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Image = (Image)resources.GetObject("btnAceptar.Image");
            btnAceptar.ImageAlign = ContentAlignment.TopLeft;
            btnAceptar.Location = new Point(106, 438);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(298, 40);
            btnAceptar.TabIndex = 48;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(0, 61, 59);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(131, 182, 181);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.TopLeft;
            btnCancelar.Location = new Point(465, 438);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(298, 40);
            btnCancelar.TabIndex = 49;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmCambiarContrasena
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
            Name = "FrmCambiarContrasena";
            Text = "FrmCambiarContrasena";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCerrado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureAbierto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureOcerrado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureOabierto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel2;
        private TextBox txtClave;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox txtClaveNueva;
        private PictureBox pictureBox2;
        private Label label3;
        private Button btnAceptar;
        private Button btnCancelar;
        private PictureBox pictureOcerrado;
        private PictureBox pictureCerrado;
        private PictureBox pictureAbierto;
        private PictureBox pictureOabierto;
    }
}