namespace AppTelemarketing
{
    partial class FrmConsultarAgendadosAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarAgendadosAdmin));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnVolver = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            ListadoAgendados = new DataGridView();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            Observaciones = new DataGridViewTextBoxColumn();
            IdProspecto = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            label2 = new Label();
            comboBoxTelemarketers = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ListadoAgendados).BeginInit();
            SuspendLayout();
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
            btnVolver.Location = new Point(610, 487);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(226, 40);
            btnVolver.TabIndex = 30;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.HighlightText;
            dateTimePicker1.Location = new Point(253, 35);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(354, 31);
            dateTimePicker1.TabIndex = 29;
            dateTimePicker1.Value = new DateTime(2024, 5, 21, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(304, 71);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 26);
            label1.TabIndex = 28;
            label1.Text = "Consultar Agendados";
            // 
            // ListadoAgendados
            // 
            dataGridViewCellStyle1.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            ListadoAgendados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ListadoAgendados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            ListadoAgendados.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(10, 68, 101);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(10, 68, 101);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ListadoAgendados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ListadoAgendados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListadoAgendados.Columns.AddRange(new DataGridViewColumn[] { NombreCompleto, Telefono, Fecha, Hora, Observaciones, IdProspecto, UserName });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ListadoAgendados.DefaultCellStyle = dataGridViewCellStyle3;
            ListadoAgendados.EnableHeadersVisualStyles = false;
            ListadoAgendados.GridColor = SystemColors.Window;
            ListadoAgendados.Location = new Point(23, 102);
            ListadoAgendados.Margin = new Padding(4, 5, 4, 5);
            ListadoAgendados.Name = "ListadoAgendados";
            ListadoAgendados.RowHeadersVisible = false;
            ListadoAgendados.RowHeadersWidth = 62;
            ListadoAgendados.RowTemplate.Height = 25;
            ListadoAgendados.Size = new Size(809, 330);
            ListadoAgendados.TabIndex = 27;
            ListadoAgendados.CellFormatting += ListadoAgendados_CellFormatting_1;
            // 
            // NombreCompleto
            // 
            NombreCompleto.DataPropertyName = "Nombre";
            NombreCompleto.Frozen = true;
            NombreCompleto.HeaderText = "NOMBRE Y APELLIDO";
            NombreCompleto.MinimumWidth = 8;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 201;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "TelefonoPrincipal";
            Telefono.Frozen = true;
            Telefono.HeaderText = "TELEFONO";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 133;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "FechaAgenda";
            Fecha.FillWeight = 75F;
            Fecha.Frozen = true;
            Fecha.HeaderText = "FECHA";
            Fecha.MinimumWidth = 8;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 102;
            // 
            // Hora
            // 
            Hora.DataPropertyName = "HoraAgenda";
            Hora.FillWeight = 75F;
            Hora.Frozen = true;
            Hora.HeaderText = "HORA";
            Hora.MinimumWidth = 8;
            Hora.Name = "Hora";
            Hora.ReadOnly = true;
            Hora.Width = 98;
            // 
            // Observaciones
            // 
            Observaciones.DataPropertyName = "ObsProspecto";
            Observaciones.FillWeight = 170F;
            Observaciones.Frozen = true;
            Observaciones.HeaderText = "OBSERVACIONES";
            Observaciones.MinimumWidth = 8;
            Observaciones.Name = "Observaciones";
            Observaciones.ReadOnly = true;
            Observaciones.Width = 186;
            // 
            // IdProspecto
            // 
            IdProspecto.DataPropertyName = "Idprospecto";
            IdProspecto.Frozen = true;
            IdProspecto.HeaderText = "IDPROSPECTO";
            IdProspecto.MinimumWidth = 8;
            IdProspecto.Name = "IdProspecto";
            IdProspecto.Visible = false;
            IdProspecto.Width = 163;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserId";
            UserName.Frozen = true;
            UserName.HeaderText = "ID TMK";
            UserName.MinimumWidth = 8;
            UserName.Name = "UserName";
            UserName.Width = 99;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 437);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 39;
            label2.Text = "Filtrar por TMK";
            // 
            // comboBoxTelemarketers
            // 
            comboBoxTelemarketers.BackColor = Color.SteelBlue;
            comboBoxTelemarketers.ForeColor = Color.White;
            comboBoxTelemarketers.FormattingEnabled = true;
            comboBoxTelemarketers.Location = new Point(27, 461);
            comboBoxTelemarketers.Name = "comboBoxTelemarketers";
            comboBoxTelemarketers.Size = new Size(209, 33);
            comboBoxTelemarketers.TabIndex = 38;
            // 
            // FrmConsultarAgendadosAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 562);
            Controls.Add(label2);
            Controls.Add(comboBoxTelemarketers);
            Controls.Add(btnVolver);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(ListadoAgendados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConsultarAgendadosAdmin";
            Text = "FrmConsultarAgendadosAdmin";
            Load += FrmConsultarAgendadosAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)ListadoAgendados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVolver;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private DataGridView ListadoAgendados;
        private Label label2;
        private ComboBox comboBoxTelemarketers;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Observaciones;
        private DataGridViewTextBoxColumn IdProspecto;
        private DataGridViewTextBoxColumn UserName;
    }
}