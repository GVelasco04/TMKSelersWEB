namespace AppTelemarketing
{
    partial class FrmAjustesRespuestas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjustesRespuestas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnVolver = new Button();
            btnGuardar = new Button();
            label2 = new Label();
            panel1 = new Panel();
            txtNuevaRespuesta = new TextBox();
            pictureBox2 = new PictureBox();
            TipoRespuestas = new DataGridView();
            IdRespuesta = new DataGridViewTextBoxColumn();
            DescripcionRespuesta = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnEliminarRespuesta = new Button();
            pictureBoxRefresh = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TipoRespuestas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).BeginInit();
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
            btnVolver.Location = new Point(581, 510);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(262, 40);
            btnVolver.TabIndex = 33;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(10, 68, 101);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 165, 215);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.ImageAlign = ContentAlignment.TopLeft;
            btnGuardar.Location = new Point(12, 97);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(139, 40);
            btnGuardar.TabIndex = 32;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(241, 22);
            label2.TabIndex = 31;
            label2.Text = "Agregar Nueva Respuesta";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtNuevaRespuesta);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(12, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 58);
            panel1.TabIndex = 30;
            // 
            // txtNuevaRespuesta
            // 
            txtNuevaRespuesta.BackColor = Color.WhiteSmoke;
            txtNuevaRespuesta.BorderStyle = BorderStyle.None;
            txtNuevaRespuesta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNuevaRespuesta.ForeColor = Color.Black;
            txtNuevaRespuesta.Location = new Point(67, 13);
            txtNuevaRespuesta.Name = "txtNuevaRespuesta";
            txtNuevaRespuesta.Size = new Size(238, 27);
            txtNuevaRespuesta.TabIndex = 2;
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
            // TipoRespuestas
            // 
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            TipoRespuestas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            TipoRespuestas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TipoRespuestas.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(10, 68, 101);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(10, 68, 101);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            TipoRespuestas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            TipoRespuestas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TipoRespuestas.Columns.AddRange(new DataGridViewColumn[] { IdRespuesta, DescripcionRespuesta });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            TipoRespuestas.DefaultCellStyle = dataGridViewCellStyle3;
            TipoRespuestas.EnableHeadersVisualStyles = false;
            TipoRespuestas.GridColor = Color.White;
            TipoRespuestas.Location = new Point(311, 132);
            TipoRespuestas.Name = "TipoRespuestas";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.CadetBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            TipoRespuestas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            TipoRespuestas.RowHeadersVisible = false;
            TipoRespuestas.RowHeadersWidth = 62;
            TipoRespuestas.RowTemplate.Height = 33;
            TipoRespuestas.Size = new Size(311, 330);
            TipoRespuestas.TabIndex = 29;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(334, 104);
            label1.Name = "label1";
            label1.Size = new Size(273, 26);
            label1.TabIndex = 28;
            label1.Text = "Registro Tipo Respuestas";
            // 
            // btnEliminarRespuesta
            // 
            btnEliminarRespuesta.BackColor = Color.FromArgb(10, 68, 101);
            btnEliminarRespuesta.FlatAppearance.BorderSize = 0;
            btnEliminarRespuesta.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 165, 215);
            btnEliminarRespuesta.FlatStyle = FlatStyle.Flat;
            btnEliminarRespuesta.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarRespuesta.ForeColor = Color.White;
            btnEliminarRespuesta.Image = (Image)resources.GetObject("btnEliminarRespuesta.Image");
            btnEliminarRespuesta.ImageAlign = ContentAlignment.TopLeft;
            btnEliminarRespuesta.Location = new Point(311, 468);
            btnEliminarRespuesta.Name = "btnEliminarRespuesta";
            btnEliminarRespuesta.Size = new Size(168, 40);
            btnEliminarRespuesta.TabIndex = 34;
            btnEliminarRespuesta.Text = "Eliminar Respuesta";
            btnEliminarRespuesta.UseVisualStyleBackColor = false;
            btnEliminarRespuesta.Click += btnEliminarRespuesta_Click;
            // 
            // pictureBoxRefresh
            // 
            pictureBoxRefresh.BackColor = Color.Transparent;
            pictureBoxRefresh.ErrorImage = null;
            pictureBoxRefresh.Image = (Image)resources.GetObject("pictureBoxRefresh.Image");
            pictureBoxRefresh.Location = new Point(792, 9);
            pictureBoxRefresh.Name = "pictureBoxRefresh";
            pictureBoxRefresh.Size = new Size(46, 35);
            pictureBoxRefresh.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRefresh.TabIndex = 41;
            pictureBoxRefresh.TabStop = false;
            pictureBoxRefresh.Click += pictureBoxRefresh_Click;
            // 
            // FrmAjustesRespuestas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 562);
            Controls.Add(pictureBoxRefresh);
            Controls.Add(btnEliminarRespuesta);
            Controls.Add(btnVolver);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(TipoRespuestas);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAjustesRespuestas";
            Text = "FrmAjustesRespuestas";
            Load += FrmAjustesRespuestas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)TipoRespuestas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Button btnGuardar;
        private Label label2;
        private Panel panel1;
        private TextBox txtNuevaRespuesta;
        private PictureBox pictureBox2;
        private DataGridView TipoRespuestas;
        private Label label1;
        private Button btnEliminarRespuesta;
        private DataGridViewTextBoxColumn IdRespuesta;
        private DataGridViewTextBoxColumn DescripcionRespuesta;
        private PictureBox pictureBoxRefresh;
    }
}