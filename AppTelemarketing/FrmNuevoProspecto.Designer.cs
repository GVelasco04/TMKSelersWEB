namespace WinFormsApp2
{
    partial class FrmNuevoProspecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoProspecto));
            label1 = new Label();
            btnGuardar = new Button();
            btnVolver = new Button();
            panel1 = new Panel();
            txtNombre = new TextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            txtApellido = new TextBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel3 = new Panel();
            txtTelefono = new TextBox();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            ObservacionesPro = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(282, 30);
            label1.Name = "label1";
            label1.Size = new Size(289, 26);
            label1.TabIndex = 0;
            label1.Text = "Agregar Nuevo Prospecto";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 61, 59);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(131, 182, 181);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.ImageAlign = ContentAlignment.TopLeft;
            btnGuardar.Location = new Point(88, 485);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(298, 40);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(0, 61, 59);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(131, 182, 181);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.White;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.ImageAlign = ContentAlignment.TopLeft;
            btnVolver.Location = new Point(457, 485);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(298, 40);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(66, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 58);
            panel1.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.WhiteSmoke;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(67, 13);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(238, 27);
            txtNombre.TabIndex = 2;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(66, 88);
            label2.Name = "label2";
            label2.Size = new Size(82, 22);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(66, 183);
            label3.Name = "label3";
            label3.Size = new Size(83, 22);
            label3.TabIndex = 7;
            label3.Text = "Apellido";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtApellido);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(66, 207);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 58);
            panel2.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.WhiteSmoke;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.ForeColor = Color.Black;
            txtApellido.Location = new Point(67, 13);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(238, 27);
            txtApellido.TabIndex = 2;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(65, 286);
            label4.Name = "label4";
            label4.Size = new Size(86, 22);
            label4.TabIndex = 9;
            label4.Text = "Telefono";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtTelefono);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(65, 310);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 58);
            panel3.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.WhiteSmoke;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(67, 13);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(238, 27);
            txtTelefono.TabIndex = 2;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(457, 88);
            label5.Name = "label5";
            label5.Size = new Size(144, 22);
            label5.TabIndex = 18;
            label5.Text = "Observaciones";
            // 
            // ObservacionesPro
            // 
            ObservacionesPro.Location = new Point(457, 116);
            ObservacionesPro.Multiline = true;
            ObservacionesPro.Name = "ObservacionesPro";
            ObservacionesPro.Size = new Size(331, 137);
            ObservacionesPro.TabIndex = 17;
            // 
            // FrmNuevoProspecto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 562);
            Controls.Add(label5);
            Controls.Add(ObservacionesPro);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnVolver);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNuevoProspecto";
            Text = "FrmNuevoUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGuardar;
        private Button btnVolver;
        private Panel panel1;
        private TextBox txtNombre;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private TextBox txtApellido;
        private PictureBox pictureBox1;
        private Label label4;
        private Panel panel3;
        private TextBox txtTelefono;
        private PictureBox pictureBox3;
        private Label label5;
        private TextBox ObservacionesPro;
    }
}