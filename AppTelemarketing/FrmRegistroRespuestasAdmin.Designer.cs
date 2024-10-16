namespace AppTelemarketing
{
    partial class FrmRegistroRespuestasAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroRespuestasAdmin));
            registroLlamadas = new DataGridView();
            label1 = new Label();
            btnVolver = new Button();
            label2 = new Label();
            comboBoxTelemarketers = new ComboBox();
            pictureBoxAjustes = new PictureBox();
            IdRespuesta = new DataGridViewTextBoxColumn();
            DescripcionRespuesta = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)registroLlamadas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAjustes).BeginInit();
            SuspendLayout();
            // 
            // registroLlamadas
            // 
            dataGridViewCellStyle1.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            registroLlamadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            registroLlamadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            registroLlamadas.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(10, 68, 101);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(10, 68, 101);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            registroLlamadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            registroLlamadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registroLlamadas.Columns.AddRange(new DataGridViewColumn[] { IdRespuesta, DescripcionRespuesta, Total, UserName });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            registroLlamadas.DefaultCellStyle = dataGridViewCellStyle3;
            registroLlamadas.EnableHeadersVisualStyles = false;
            registroLlamadas.GridColor = Color.White;
            registroLlamadas.Location = new Point(208, 92);
            registroLlamadas.Name = "registroLlamadas";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.CadetBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            registroLlamadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            registroLlamadas.RowHeadersVisible = false;
            registroLlamadas.RowHeadersWidth = 62;
            registroLlamadas.RowTemplate.Height = 33;
            registroLlamadas.Size = new Size(443, 330);
            registroLlamadas.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(323, 63);
            label1.Name = "label1";
            label1.Size = new Size(224, 26);
            label1.TabIndex = 8;
            label1.Text = "Registro Respuestas";
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
            btnVolver.Location = new Point(576, 510);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(262, 40);
            btnVolver.TabIndex = 27;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(208, 425);
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
            comboBoxTelemarketers.Location = new Point(208, 449);
            comboBoxTelemarketers.Name = "comboBoxTelemarketers";
            comboBoxTelemarketers.Size = new Size(209, 33);
            comboBoxTelemarketers.TabIndex = 38;
            // 
            // pictureBoxAjustes
            // 
            pictureBoxAjustes.Image = (Image)resources.GetObject("pictureBoxAjustes.Image");
            pictureBoxAjustes.Location = new Point(792, 12);
            pictureBoxAjustes.Name = "pictureBoxAjustes";
            pictureBoxAjustes.Size = new Size(46, 35);
            pictureBoxAjustes.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAjustes.TabIndex = 40;
            pictureBoxAjustes.TabStop = false;
            pictureBoxAjustes.Click += pictureBoxAjustes_Click;
            // 
            // IdRespuesta
            // 
            IdRespuesta.DataPropertyName = "CodRespuesta";
            IdRespuesta.HeaderText = "CODIGO";
            IdRespuesta.MinimumWidth = 8;
            IdRespuesta.Name = "IdRespuesta";
            IdRespuesta.Width = 117;
            // 
            // DescripcionRespuesta
            // 
            DescripcionRespuesta.DataPropertyName = "Respuesta";
            DescripcionRespuesta.HeaderText = "RESPUESTA";
            DescripcionRespuesta.MinimumWidth = 8;
            DescripcionRespuesta.Name = "DescripcionRespuesta";
            DescripcionRespuesta.Width = 139;
            // 
            // Total
            // 
            Total.DataPropertyName = "TotalLlamadas";
            Total.HeaderText = "TOTAL";
            Total.MinimumWidth = 8;
            Total.Name = "Total";
            Total.Width = 97;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserId";
            UserName.HeaderText = "TMK ID";
            UserName.MinimumWidth = 8;
            UserName.Name = "UserName";
            UserName.Width = 106;
            // 
            // FrmRegistroRespuestasAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 562);
            Controls.Add(pictureBoxAjustes);
            Controls.Add(label2);
            Controls.Add(comboBoxTelemarketers);
            Controls.Add(btnVolver);
            Controls.Add(registroLlamadas);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegistroRespuestasAdmin";
            Text = "Form1";
            Load += FrmRegistroRespuestasAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)registroLlamadas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAjustes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView registroLlamadas;
        private Label label1;
        private Button btnVolver;
        private Label label2;
        private ComboBox comboBoxTelemarketers;
        private PictureBox pictureBoxAjustes;
        private DataGridViewTextBoxColumn IdRespuesta;
        private DataGridViewTextBoxColumn DescripcionRespuesta;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn UserName;
    }
}