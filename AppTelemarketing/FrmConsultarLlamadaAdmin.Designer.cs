namespace AppTelemarketing
{
    partial class FrmConsultarLlamadaAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarLlamadaAdmin));
            label3 = new Label();
            comboBoxRespuestas = new ComboBox();
            ListadoLlamados = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Respuesta = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Observaciones = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnVolver = new Button();
            label2 = new Label();
            comboBoxTelemarketers = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ListadoLlamados).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 436);
            label3.Name = "label3";
            label3.Size = new Size(184, 21);
            label3.TabIndex = 35;
            label3.Text = "Filtrar por Respuesta";
            // 
            // comboBoxRespuestas
            // 
            comboBoxRespuestas.BackColor = Color.SteelBlue;
            comboBoxRespuestas.ForeColor = Color.White;
            comboBoxRespuestas.FormattingEnabled = true;
            comboBoxRespuestas.Location = new Point(13, 460);
            comboBoxRespuestas.Name = "comboBoxRespuestas";
            comboBoxRespuestas.Size = new Size(209, 33);
            comboBoxRespuestas.TabIndex = 34;
            // 
            // ListadoLlamados
            // 
            dataGridViewCellStyle1.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            ListadoLlamados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ListadoLlamados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ListadoLlamados.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(10, 68, 101);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(10, 68, 101);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ListadoLlamados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ListadoLlamados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListadoLlamados.Columns.AddRange(new DataGridViewColumn[] { UserName, Apellido, Nombre, Telefono, Respuesta, Fecha, Observaciones });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ListadoLlamados.DefaultCellStyle = dataGridViewCellStyle3;
            ListadoLlamados.EnableHeadersVisualStyles = false;
            ListadoLlamados.GridColor = Color.White;
            ListadoLlamados.Location = new Point(13, 70);
            ListadoLlamados.Margin = new Padding(4, 5, 4, 5);
            ListadoLlamados.Name = "ListadoLlamados";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.CadetBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ListadoLlamados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ListadoLlamados.RowHeadersVisible = false;
            ListadoLlamados.RowHeadersWidth = 62;
            ListadoLlamados.RowTemplate.Height = 25;
            ListadoLlamados.Size = new Size(833, 361);
            ListadoLlamados.TabIndex = 33;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserId";
            UserName.Frozen = true;
            UserName.HeaderText = "ID TMK";
            UserName.MinimumWidth = 8;
            UserName.Name = "UserName";
            UserName.Width = 106;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.FillWeight = 75F;
            Apellido.Frozen = true;
            Apellido.HeaderText = "APELLIDO";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 127;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.FillWeight = 75F;
            Nombre.Frozen = true;
            Nombre.HeaderText = "NOMBRE";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 121;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "TelefonoPrincipal";
            Telefono.FillWeight = 75F;
            Telefono.Frozen = true;
            Telefono.HeaderText = "TELEFONO";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 133;
            // 
            // Respuesta
            // 
            Respuesta.DataPropertyName = "Respuestas";
            Respuesta.FillWeight = 40F;
            Respuesta.Frozen = true;
            Respuesta.HeaderText = "RESP.";
            Respuesta.MinimumWidth = 8;
            Respuesta.Name = "Respuesta";
            Respuesta.ReadOnly = true;
            Respuesta.Width = 92;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            Fecha.FillWeight = 50F;
            Fecha.Frozen = true;
            Fecha.HeaderText = "FECHA";
            Fecha.MinimumWidth = 8;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 102;
            // 
            // Observaciones
            // 
            Observaciones.DataPropertyName = "Observacion";
            Observaciones.FillWeight = 170F;
            Observaciones.Frozen = true;
            Observaciones.HeaderText = "OBSERVACIONES";
            Observaciones.MinimumWidth = 8;
            Observaciones.Name = "Observaciones";
            Observaciones.ReadOnly = true;
            Observaciones.Width = 186;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(316, 39);
            label1.Name = "label1";
            label1.Size = new Size(225, 26);
            label1.TabIndex = 32;
            label1.Text = "Consultar Llamadas";
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
            btnVolver.Location = new Point(575, 496);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(225, 40);
            btnVolver.TabIndex = 31;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(250, 436);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 37;
            label2.Text = "Filtrar por TMK";
            // 
            // comboBoxTelemarketers
            // 
            comboBoxTelemarketers.BackColor = Color.SteelBlue;
            comboBoxTelemarketers.ForeColor = Color.White;
            comboBoxTelemarketers.FormattingEnabled = true;
            comboBoxTelemarketers.Location = new Point(250, 460);
            comboBoxTelemarketers.Name = "comboBoxTelemarketers";
            comboBoxTelemarketers.Size = new Size(209, 33);
            comboBoxTelemarketers.TabIndex = 36;
            comboBoxTelemarketers.SelectedIndexChanged += comboBoxTelemarketers_SelectedIndexChanged;
            // 
            // FrmConsultarLlamadaAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 562);
            Controls.Add(label2);
            Controls.Add(comboBoxTelemarketers);
            Controls.Add(label3);
            Controls.Add(comboBoxRespuestas);
            Controls.Add(ListadoLlamados);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConsultarLlamadaAdmin";
            Text = "Frm1";
            Load += FrmConsultarLlamadaAdmin_Load_1;
            ((System.ComponentModel.ISupportInitialize)ListadoLlamados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox comboBoxRespuestas;
        private DataGridView ListadoLlamados;
        private Label label1;
        private Button btnVolver;
        private Label label2;
        private ComboBox comboBoxTelemarketers;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Respuesta;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Observaciones;
    }
}