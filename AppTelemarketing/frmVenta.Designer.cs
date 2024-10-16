namespace AppTelemarketing
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            btnGuardar = new Button();
            btnVolver = new Button();
            label1 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            txtTelefono = new TextBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            txtApellido = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            txtNombre = new TextBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            panel5 = new Panel();
            txtProducto = new TextBox();
            pictureBox5 = new PictureBox();
            cmbMedioPago = new ComboBox();
            label7 = new Label();
            label9 = new Label();
            panel6 = new Panel();
            txtDirrecion = new TextBox();
            pictureBox6 = new PictureBox();
            label10 = new Label();
            panel7 = new Panel();
            txtMail = new TextBox();
            pictureBox7 = new PictureBox();
            label8 = new Label();
            label11 = new Label();
            cmbProvincia = new ComboBox();
            label12 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            txtTotal = new TextBox();
            pictureBox4 = new PictureBox();
            panel8 = new Panel();
            txtCodigoPostal = new TextBox();
            pictureBox8 = new PictureBox();
            cmbLocalidad = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            lblTiempoTranscurrido = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
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
            btnGuardar.Location = new Point(78, 511);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(298, 40);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
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
            btnVolver.Location = new Point(447, 511);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(298, 40);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-1, 5);
            label1.Name = "label1";
            label1.Size = new Size(156, 21);
            label1.TabIndex = 5;
            label1.Text = "Datos Prospecto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(59, 222);
            label4.Name = "label4";
            label4.Size = new Size(86, 22);
            label4.TabIndex = 15;
            label4.Text = "Telefono";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtTelefono);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(59, 247);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 58);
            panel3.TabIndex = 14;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(62, 136);
            label3.Name = "label3";
            label3.Size = new Size(83, 22);
            label3.TabIndex = 13;
            label3.Text = "Apellido";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtApellido);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(59, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 58);
            panel2.TabIndex = 12;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(59, 51);
            label2.Name = "label2";
            label2.Size = new Size(82, 22);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(59, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 58);
            panel1.TabIndex = 10;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(62, 307);
            label6.Name = "label6";
            label6.Size = new Size(90, 22);
            label6.TabIndex = 17;
            label6.Text = "Producto";
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtProducto);
            panel5.Controls.Add(pictureBox5);
            panel5.Location = new Point(59, 332);
            panel5.Name = "panel5";
            panel5.Size = new Size(323, 58);
            panel5.TabIndex = 16;
            // 
            // txtProducto
            // 
            txtProducto.BackColor = Color.WhiteSmoke;
            txtProducto.BorderStyle = BorderStyle.None;
            txtProducto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtProducto.ForeColor = Color.Black;
            txtProducto.Location = new Point(67, 13);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(238, 27);
            txtProducto.TabIndex = 2;
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
            // cmbMedioPago
            // 
            cmbMedioPago.FormattingEnabled = true;
            cmbMedioPago.Location = new Point(465, 357);
            cmbMedioPago.Name = "cmbMedioPago";
            cmbMedioPago.Size = new Size(321, 33);
            cmbMedioPago.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(464, 334);
            label7.Name = "label7";
            label7.Size = new Size(146, 22);
            label7.TabIndex = 20;
            label7.Text = "Medio de Pago";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(464, 51);
            label9.Name = "label9";
            label9.Size = new Size(90, 22);
            label9.TabIndex = 25;
            label9.Text = "Dirreción";
            // 
            // panel6
            // 
            panel6.BackColor = Color.WhiteSmoke;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(txtDirrecion);
            panel6.Controls.Add(pictureBox6);
            panel6.Location = new Point(461, 76);
            panel6.Name = "panel6";
            panel6.Size = new Size(323, 58);
            panel6.TabIndex = 24;
            // 
            // txtDirrecion
            // 
            txtDirrecion.BackColor = Color.WhiteSmoke;
            txtDirrecion.BorderStyle = BorderStyle.None;
            txtDirrecion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDirrecion.ForeColor = Color.Black;
            txtDirrecion.Location = new Point(67, 13);
            txtDirrecion.Name = "txtDirrecion";
            txtDirrecion.Size = new Size(238, 27);
            txtDirrecion.TabIndex = 2;
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(62, 394);
            label10.Name = "label10";
            label10.Size = new Size(64, 22);
            label10.TabIndex = 23;
            label10.Text = "E-mail";
            // 
            // panel7
            // 
            panel7.BackColor = Color.WhiteSmoke;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(txtMail);
            panel7.Controls.Add(pictureBox7);
            panel7.Location = new Point(62, 418);
            panel7.Name = "panel7";
            panel7.Size = new Size(323, 58);
            panel7.TabIndex = 22;
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.WhiteSmoke;
            txtMail.BorderStyle = BorderStyle.None;
            txtMail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.ForeColor = Color.Black;
            txtMail.Location = new Point(67, 13);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(238, 27);
            txtMail.TabIndex = 2;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(7, 8);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(40, 40);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(464, 222);
            label8.Name = "label8";
            label8.Size = new Size(0, 22);
            label8.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(461, 137);
            label11.Name = "label11";
            label11.Size = new Size(132, 22);
            label11.TabIndex = 27;
            label11.Text = "Codigo Postal";
            // 
            // cmbProvincia
            // 
            cmbProvincia.FormattingEnabled = true;
            cmbProvincia.Location = new Point(464, 241);
            cmbProvincia.Name = "cmbProvincia";
            cmbProvincia.Size = new Size(321, 33);
            cmbProvincia.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.Control;
            label12.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(461, 221);
            label12.Name = "label12";
            label12.Size = new Size(91, 22);
            label12.TabIndex = 30;
            label12.Text = "Provincia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(464, 394);
            label5.Name = "label5";
            label5.Size = new Size(51, 22);
            label5.TabIndex = 35;
            label5.Text = "Total";
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtTotal);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(464, 418);
            panel4.Name = "panel4";
            panel4.Size = new Size(206, 56);
            panel4.TabIndex = 34;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.WhiteSmoke;
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.ForeColor = Color.Black;
            txtTotal.Location = new Point(52, 14);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(148, 27);
            txtTotal.TabIndex = 2;
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
            // panel8
            // 
            panel8.BackColor = Color.WhiteSmoke;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(txtCodigoPostal);
            panel8.Controls.Add(pictureBox8);
            panel8.Location = new Point(464, 161);
            panel8.Name = "panel8";
            panel8.Size = new Size(323, 58);
            panel8.TabIndex = 25;
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.BackColor = Color.WhiteSmoke;
            txtCodigoPostal.BorderStyle = BorderStyle.None;
            txtCodigoPostal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigoPostal.ForeColor = Color.Black;
            txtCodigoPostal.Location = new Point(67, 13);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(238, 27);
            txtCodigoPostal.TabIndex = 2;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(7, 8);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(40, 40);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 1;
            pictureBox8.TabStop = false;
            // 
            // cmbLocalidad
            // 
            cmbLocalidad.FormattingEnabled = true;
            cmbLocalidad.Location = new Point(463, 296);
            cmbLocalidad.Name = "cmbLocalidad";
            cmbLocalidad.Size = new Size(321, 33);
            cmbLocalidad.TabIndex = 37;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(461, 275);
            label13.Name = "label13";
            label13.Size = new Size(98, 22);
            label13.TabIndex = 36;
            label13.Text = "Localidad";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(447, 4);
            label14.Name = "label14";
            label14.Size = new Size(165, 22);
            label14.TabIndex = 39;
            label14.Text = "Tiempo en Venta:";
            // 
            // lblTiempoTranscurrido
            // 
            lblTiempoTranscurrido.AutoSize = true;
            lblTiempoTranscurrido.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTiempoTranscurrido.Location = new Point(628, 5);
            lblTiempoTranscurrido.Name = "lblTiempoTranscurrido";
            lblTiempoTranscurrido.Size = new Size(0, 22);
            lblTiempoTranscurrido.TabIndex = 40;
            // 
            // frmVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 562);
            Controls.Add(lblTiempoTranscurrido);
            Controls.Add(label14);
            Controls.Add(cmbLocalidad);
            Controls.Add(label13);
            Controls.Add(panel8);
            Controls.Add(label5);
            Controls.Add(panel4);
            Controls.Add(cmbProvincia);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(panel6);
            Controls.Add(label10);
            Controls.Add(panel7);
            Controls.Add(cmbMedioPago);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel5);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(btnGuardar);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "frmVenta";
            Text = "frmVenta";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnVolver;
        private Label label1;
        private Label label4;
        private Panel panel3;
        private TextBox txtTelefono;
        private PictureBox pictureBox3;
        private Label label3;
        private Panel panel2;
        private TextBox txtApellido;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel1;
        private TextBox txtNombre;
        private PictureBox pictureBox2;
        private Label label6;
        private Panel panel5;
        private TextBox txtProducto;
        private PictureBox pictureBox5;
        private ComboBox cmbMedioPago;
        private Label label7;
        private Label label9;
        private Panel panel6;
        private TextBox txtDirrecion;
        private PictureBox pictureBox6;
        private Label label10;
        private Panel panel7;
        private TextBox txtMail;
        private PictureBox pictureBox7;
        private Label label8;
        private Label label11;
        private ComboBox cmbProvincia;
        private Label label12;
        private Label label5;
        private Panel panel4;
        private TextBox txtTotal;
        private PictureBox pictureBox4;
        private Panel panel8;
        private TextBox txtCodigoPostal;
        private PictureBox pictureBox8;
        private ComboBox cmbLocalidad;
        private Label label13;
        private Label label14;
        private Label lblTiempoTranscurrido;
    }
}