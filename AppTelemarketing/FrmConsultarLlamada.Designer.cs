namespace AppTelemarketing
{
    partial class FrmConsultarLlamada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarLlamada));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            btnVolver = new Button();
            ListadoLlamados = new DataGridView();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Respuesta = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Observaciones = new DataGridViewTextBoxColumn();
            comboBoxRespuesta = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)ListadoLlamados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(311, 26);
            label1.Name = "label1";
            label1.Size = new Size(225, 26);
            label1.TabIndex = 25;
            label1.Text = "Consultar Llamadas";
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
            btnVolver.Location = new Point(578, 473);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(225, 40);
            btnVolver.TabIndex = 24;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // ListadoLlamados
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 130, 126);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(7, 130, 126);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            ListadoLlamados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ListadoLlamados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ListadoLlamados.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(1, 107, 104);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(1, 107, 104);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ListadoLlamados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ListadoLlamados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListadoLlamados.Columns.AddRange(new DataGridViewColumn[] { Apellido, Nombre, Telefono, Respuesta, Fecha, Observaciones });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.CadetBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ListadoLlamados.DefaultCellStyle = dataGridViewCellStyle3;
            ListadoLlamados.EnableHeadersVisualStyles = false;
            ListadoLlamados.GridColor = Color.White;
            ListadoLlamados.Location = new Point(47, 67);
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
            ListadoLlamados.Size = new Size(756, 340);
            ListadoLlamados.TabIndex = 26;
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
            // comboBoxRespuesta
            // 
            comboBoxRespuesta.BackColor = Color.CadetBlue;
            comboBoxRespuesta.ForeColor = Color.White;
            comboBoxRespuesta.FormattingEnabled = true;
            comboBoxRespuesta.Items.AddRange(new object[] { "1.- No contesta", "2.- Sin interes", "3.- Volver a llamar", "4.- Venta", "5.- Telefono erroneo" });
            comboBoxRespuesta.Location = new Point(47, 437);
            comboBoxRespuesta.Name = "comboBoxRespuesta";
            comboBoxRespuesta.Size = new Size(209, 33);
            comboBoxRespuesta.TabIndex = 29;
            comboBoxRespuesta.SelectedIndexChanged += comboBoxRespuesta_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 413);
            label3.Name = "label3";
            label3.Size = new Size(184, 21);
            label3.TabIndex = 30;
            label3.Text = "Filtrar por Respuesta";
            // 
            // FrmConsultarLlamada
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 562);
            Controls.Add(label3);
            Controls.Add(comboBoxRespuesta);
            Controls.Add(ListadoLlamados);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConsultarLlamada";
            Text = "FrmConsultarLlamada";
            Load += FrmConsultarLlamada_Load;
            ((System.ComponentModel.ISupportInitialize)ListadoLlamados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnVolver;
        private DataGridView ListadoLlamados;
        private ComboBox comboBoxRespuesta;
        private Label label3;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Respuesta;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Observaciones;
    }
}