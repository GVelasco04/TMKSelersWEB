namespace WinFormsApp2
{
    partial class FrmRegistroRespuestas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroRespuestas));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            btnVolver = new Button();
            label1 = new Label();
            registroLlamadas = new DataGridView();
            IdRespuesta = new DataGridViewTextBoxColumn();
            DescripcionRespuesta = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)registroLlamadas).BeginInit();
            SuspendLayout();
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
            btnVolver.Location = new Point(613, 510);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(225, 40);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(295, 71);
            label1.Name = "label1";
            label1.Size = new Size(224, 26);
            label1.TabIndex = 5;
            label1.Text = "Registro Respuestas";
            // 
            // registroLlamadas
            // 
            dataGridViewCellStyle5.BackColor = Color.FromArgb(7, 130, 126);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(7, 130, 126);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            registroLlamadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            registroLlamadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            registroLlamadas.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(1, 107, 104);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(1, 107, 104);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            registroLlamadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            registroLlamadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registroLlamadas.Columns.AddRange(new DataGridViewColumn[] { IdRespuesta, DescripcionRespuesta, Total });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.CadetBlue;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            registroLlamadas.DefaultCellStyle = dataGridViewCellStyle7;
            registroLlamadas.EnableHeadersVisualStyles = false;
            registroLlamadas.GridColor = Color.White;
            registroLlamadas.Location = new Point(238, 110);
            registroLlamadas.Name = "registroLlamadas";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.CadetBlue;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            registroLlamadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            registroLlamadas.RowHeadersVisible = false;
            registroLlamadas.RowHeadersWidth = 62;
            registroLlamadas.RowTemplate.Height = 33;
            registroLlamadas.Size = new Size(354, 330);
            registroLlamadas.TabIndex = 6;
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
            // FrmRegistroRespuestas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 562);
            Controls.Add(registroLlamadas);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegistroRespuestas";
            Text = "FrmRegistroLlamada";
            Load += FrmRegistroLlamada_Load;
            ((System.ComponentModel.ISupportInitialize)registroLlamadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label label1;
        private DataGridView registroLlamadas;
        private DataGridViewTextBoxColumn IdRespuesta;
        private DataGridViewTextBoxColumn DescripcionRespuesta;
        private DataGridViewTextBoxColumn Total;
    }
}