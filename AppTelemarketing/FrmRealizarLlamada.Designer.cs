namespace WinFormsApp2
{
    partial class FrmRealizarLlamada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRealizarLlamada));
            btnAceptar = new Button();
            label2 = new Label();
            panel1 = new Panel();
            txtNombrePro = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            txtApePro = new TextBox();
            textBox2 = new TextBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            comboBoxRespuesta = new ComboBox();
            ObservacionesPro = new TextBox();
            label5 = new Label();
            fecha = new DateTimePicker();
            hora = new DateTimePicker();
            label6 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            txtTelefPro = new TextBox();
            pictureBox4 = new PictureBox();
            textBox5 = new TextBox();
            pictureBox5 = new PictureBox();
            comboBoxProductos = new ComboBox();
            linkGuia = new LinkLabel();
            pictureBox6 = new PictureBox();
            label7 = new Label();
            tiempoDeLlamado = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
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
            btnAceptar.Location = new Point(474, 452);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(299, 40);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Guardar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnVolver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(71, 88);
            label2.Name = "label2";
            label2.Size = new Size(82, 22);
            label2.TabIndex = 7;
            label2.Text = "Nombre";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtNombrePro);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(71, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 59);
            panel1.TabIndex = 6;
            // 
            // txtNombrePro
            // 
            txtNombrePro.BackColor = Color.WhiteSmoke;
            txtNombrePro.BorderStyle = BorderStyle.None;
            txtNombrePro.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombrePro.ForeColor = Color.Black;
            txtNombrePro.Location = new Point(67, 13);
            txtNombrePro.Name = "txtNombrePro";
            txtNombrePro.Size = new Size(239, 27);
            txtNombrePro.TabIndex = 2;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(71, 183);
            label4.Name = "label4";
            label4.Size = new Size(83, 22);
            label4.TabIndex = 11;
            label4.Text = "Apellido";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(71, 208);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 59);
            panel3.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(txtApePro);
            panel2.Location = new Point(-1, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 59);
            panel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtApePro
            // 
            txtApePro.BackColor = Color.WhiteSmoke;
            txtApePro.BorderStyle = BorderStyle.None;
            txtApePro.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApePro.ForeColor = Color.Black;
            txtApePro.Location = new Point(67, 13);
            txtApePro.Name = "txtApePro";
            txtApePro.Size = new Size(239, 27);
            txtApePro.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(67, 13);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 27);
            textBox2.TabIndex = 2;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(305, 23);
            label1.Name = "label1";
            label1.Size = new Size(207, 26);
            label1.TabIndex = 12;
            label1.Text = "Realizar Llamados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(462, 88);
            label3.Name = "label3";
            label3.Size = new Size(100, 22);
            label3.TabIndex = 13;
            label3.Text = "Respuesta";
            // 
            // comboBoxRespuesta
            // 
            comboBoxRespuesta.BackColor = Color.CadetBlue;
            comboBoxRespuesta.FormattingEnabled = true;
            comboBoxRespuesta.Items.AddRange(new object[] { "1.- No contesta", "2.- Sin interes", "3.- Volver a llamar", "4.- Venta", "5.- Telefono erroneo" });
            comboBoxRespuesta.Location = new Point(462, 112);
            comboBoxRespuesta.Name = "comboBoxRespuesta";
            comboBoxRespuesta.Size = new Size(321, 33);
            comboBoxRespuesta.TabIndex = 14;
            comboBoxRespuesta.SelectedIndexChanged += comboBoxRespuesta_SelectedIndexChanged;
            // 
            // ObservacionesPro
            // 
            ObservacionesPro.Location = new Point(71, 403);
            ObservacionesPro.Multiline = true;
            ObservacionesPro.Name = "ObservacionesPro";
            ObservacionesPro.Size = new Size(331, 137);
            ObservacionesPro.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(71, 375);
            label5.Name = "label5";
            label5.Size = new Size(144, 22);
            label5.TabIndex = 16;
            label5.Text = "Observaciones";
            // 
            // fecha
            // 
            fecha.CalendarMonthBackground = Color.CadetBlue;
            fecha.CalendarTitleBackColor = SystemColors.Info;
            fecha.CalendarTrailingForeColor = SystemColors.ControlText;
            fecha.Format = DateTimePickerFormat.Short;
            fecha.Location = new Point(462, 217);
            fecha.Name = "fecha";
            fecha.Size = new Size(321, 31);
            fecha.TabIndex = 17;
            fecha.Value = new DateTime(2024, 5, 17, 19, 42, 25, 0);
            fecha.Visible = false;
            // 
            // hora
            // 
            hora.CalendarMonthBackground = Color.CadetBlue;
            hora.CalendarTitleBackColor = SystemColors.Info;
            hora.Format = DateTimePickerFormat.Time;
            hora.ImeMode = ImeMode.On;
            hora.Location = new Point(462, 280);
            hora.Name = "hora";
            hora.ShowUpDown = true;
            hora.Size = new Size(321, 31);
            hora.TabIndex = 18;
            hora.Value = new DateTime(2024, 5, 17, 19, 42, 25, 0);
            hora.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(71, 275);
            label6.Name = "label6";
            label6.Size = new Size(86, 22);
            label6.TabIndex = 20;
            label6.Text = "Telefono";
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(textBox5);
            panel4.Controls.Add(pictureBox5);
            panel4.Location = new Point(71, 300);
            panel4.Name = "panel4";
            panel4.Size = new Size(323, 59);
            panel4.TabIndex = 19;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtTelefPro);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(-1, -2);
            panel5.Name = "panel5";
            panel5.Size = new Size(323, 59);
            panel5.TabIndex = 11;
            // 
            // txtTelefPro
            // 
            txtTelefPro.BackColor = Color.WhiteSmoke;
            txtTelefPro.BorderStyle = BorderStyle.None;
            txtTelefPro.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefPro.ForeColor = Color.Black;
            txtTelefPro.Location = new Point(67, 13);
            txtTelefPro.Name = "txtTelefPro";
            txtTelefPro.Size = new Size(239, 27);
            txtTelefPro.TabIndex = 2;
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
            // textBox5
            // 
            textBox5.BackColor = Color.WhiteSmoke;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(67, 13);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(239, 27);
            textBox5.TabIndex = 2;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(7, 8);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // comboBoxProductos
            // 
            comboBoxProductos.BackColor = Color.CadetBlue;
            comboBoxProductos.FormattingEnabled = true;
            comboBoxProductos.Location = new Point(462, 215);
            comboBoxProductos.Name = "comboBoxProductos";
            comboBoxProductos.Size = new Size(271, 33);
            comboBoxProductos.TabIndex = 21;
            comboBoxProductos.SelectedIndexChanged += comboBoxProductos_SelectedIndexChanged;
            // 
            // linkGuia
            // 
            linkGuia.ActiveLinkColor = Color.Teal;
            linkGuia.AutoSize = true;
            linkGuia.BackColor = Color.Transparent;
            linkGuia.ForeColor = Color.White;
            linkGuia.LinkColor = Color.FromArgb(0, 61, 59);
            linkGuia.Location = new Point(729, 9);
            linkGuia.Name = "linkGuia";
            linkGuia.Size = new Size(109, 25);
            linkGuia.TabIndex = 22;
            linkGuia.TabStop = true;
            linkGuia.Text = "Guia Speech";
            linkGuia.LinkClicked += linkGuia_LinkClicked;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 1);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(40, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(48, 2);
            label7.Name = "label7";
            label7.Size = new Size(186, 22);
            label7.TabIndex = 24;
            label7.Text = "Tiempo en llamado:";
            // 
            // tiempoDeLlamado
            // 
            tiempoDeLlamado.AutoSize = true;
            tiempoDeLlamado.Location = new Point(59, 49);
            tiempoDeLlamado.Name = "tiempoDeLlamado";
            tiempoDeLlamado.Size = new Size(0, 25);
            tiempoDeLlamado.TabIndex = 25;
            // 
            // FrmRealizarLlamada
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(850, 562);
            Controls.Add(tiempoDeLlamado);
            Controls.Add(label7);
            Controls.Add(pictureBox6);
            Controls.Add(linkGuia);
            Controls.Add(comboBoxProductos);
            Controls.Add(label6);
            Controls.Add(panel4);
            Controls.Add(hora);
            Controls.Add(fecha);
            Controls.Add(label5);
            Controls.Add(ObservacionesPro);
            Controls.Add(comboBoxRespuesta);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRealizarLlamada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRealizarLlamada";
            Load += FrmRealizarLlamada_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Label label2;
        private Panel panel1;
        private TextBox txtNombrePro;
        private PictureBox pictureBox2;
        private Label label4;
        private Panel panel3;
        private TextBox textBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label3;
        private ComboBox comboBoxRespuesta;
        private TextBox ObservacionesPro;
        private Label label5;
        private DateTimePicker fecha;
        private DateTimePicker hora;
        private Panel panel2;
        private TextBox txtApePro;
        private Label label6;
        private Panel panel4;
        private Panel panel5;
        private TextBox txtTelefPro;
        private PictureBox pictureBox4;
        private TextBox textBox5;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private ComboBox comboBoxProductos;
        private LinkLabel linkGuia;
        private PictureBox pictureBox6;
        private Label label7;
        private Label tiempoDeLlamado;
    }
}