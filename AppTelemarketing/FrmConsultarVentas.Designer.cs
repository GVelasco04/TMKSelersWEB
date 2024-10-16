namespace WinFormsApp2
{
    partial class FrmConsultarVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarVentas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnVolver = new Button();
            label1 = new Label();
            ListadoVentas = new DataGridView();
            IdCliente = new DataGridViewTextBoxColumn();
            ApellidoNombre = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            MedioDePago = new DataGridViewTextBoxColumn();
            FechaVenta = new DataGridViewTextBoxColumn();
            ObsSobreVenta = new DataGridViewTextBoxColumn();
            UserId = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ListadoVentas).BeginInit();
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
            btnVolver.Location = new Point(612, 489);
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
            label1.Location = new Point(332, 32);
            label1.Name = "label1";
            label1.Size = new Size(193, 26);
            label1.TabIndex = 5;
            label1.Text = "Consultar Ventas";
            // 
            // ListadoVentas
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 130, 126);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(7, 130, 126);
            ListadoVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ListadoVentas.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(1, 107, 104);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(1, 107, 104);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ListadoVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ListadoVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListadoVentas.Columns.AddRange(new DataGridViewColumn[] { IdCliente, ApellidoNombre, NombreProducto, Precio, MedioDePago, FechaVenta, ObsSobreVenta, UserId });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.CadetBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ListadoVentas.DefaultCellStyle = dataGridViewCellStyle3;
            ListadoVentas.EnableHeadersVisualStyles = false;
            ListadoVentas.GridColor = Color.White;
            ListadoVentas.Location = new Point(20, 72);
            ListadoVentas.Margin = new Padding(4, 5, 4, 5);
            ListadoVentas.Name = "ListadoVentas";
            ListadoVentas.RowHeadersVisible = false;
            ListadoVentas.RowHeadersWidth = 62;
            ListadoVentas.RowTemplate.Height = 25;
            ListadoVentas.Size = new Size(806, 387);
            ListadoVentas.TabIndex = 28;
            ListadoVentas.CellFormatting += ListadoVentas_CellFormatting;
            // 
            // IdCliente
            // 
            IdCliente.DataPropertyName = "IdCliente";
            IdCliente.HeaderText = "CLIENTE";
            IdCliente.MinimumWidth = 8;
            IdCliente.Name = "IdCliente";
            IdCliente.Width = 75;
            // 
            // ApellidoNombre
            // 
            ApellidoNombre.DataPropertyName = "ApellidoNombre";
            ApellidoNombre.HeaderText = "NOMBRE CLIENTE";
            ApellidoNombre.MinimumWidth = 8;
            ApellidoNombre.Name = "ApellidoNombre";
            ApellidoNombre.Width = 150;
            // 
            // NombreProducto
            // 
            NombreProducto.DataPropertyName = "NombreProducto";
            NombreProducto.HeaderText = "PRODUCTO";
            NombreProducto.MinimumWidth = 8;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.Width = 150;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            Precio.HeaderText = "TOTAL";
            Precio.MinimumWidth = 8;
            Precio.Name = "Precio";
            Precio.Width = 75;
            // 
            // MedioDePago
            // 
            MedioDePago.DataPropertyName = "Descripcion";
            MedioDePago.HeaderText = "MEDIO DE PAGO";
            MedioDePago.MinimumWidth = 8;
            MedioDePago.Name = "MedioDePago";
            MedioDePago.Width = 150;
            // 
            // FechaVenta
            // 
            FechaVenta.DataPropertyName = "FechaVenta";
            FechaVenta.HeaderText = "FECHA";
            FechaVenta.MinimumWidth = 8;
            FechaVenta.Name = "FechaVenta";
            FechaVenta.Width = 75;
            // 
            // ObsSobreVenta
            // 
            ObsSobreVenta.DataPropertyName = "ObsSobreVenta";
            ObsSobreVenta.HeaderText = "OBSERVACIONES";
            ObsSobreVenta.MinimumWidth = 8;
            ObsSobreVenta.Name = "ObsSobreVenta";
            ObsSobreVenta.Width = 150;
            // 
            // UserId
            // 
            UserId.DataPropertyName = "UserId";
            UserId.HeaderText = "USUARIO";
            UserId.MinimumWidth = 8;
            UserId.Name = "UserId";
            UserId.Visible = false;
            UserId.Width = 20;
            // 
            // FrmConsultarVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 562);
            Controls.Add(ListadoVentas);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConsultarVentas";
            Text = "FrmConsultarVentas";
            Load += FrmConsultarVentas_Load;
            ((System.ComponentModel.ISupportInitialize)ListadoVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label label1;
        private DataGridView ListadoVentas;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn ApellidoNombre;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn MedioDePago;
        private DataGridViewTextBoxColumn FechaVenta;
        private DataGridViewTextBoxColumn ObsSobreVenta;
        private DataGridViewTextBoxColumn UserId;
    }
}