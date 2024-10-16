namespace AppTelemarketing
{
    partial class FrmConsultarVentasAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarVentasAdmin));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            btnVolver = new Button();
            ListadoVentas = new DataGridView();
            label2 = new Label();
            comboBoxTelemarketers = new ComboBox();
            IdCliente = new DataGridViewTextBoxColumn();
            ApellidoNombre = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            MedioDePago = new DataGridViewTextBoxColumn();
            FechaVenta = new DataGridViewTextBoxColumn();
            ObsSobreVenta = new DataGridViewTextBoxColumn();
            HoraFin = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ListadoVentas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(334, 31);
            label1.Name = "label1";
            label1.Size = new Size(193, 26);
            label1.TabIndex = 29;
            label1.Text = "Consultar Ventas";
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
            btnVolver.Location = new Point(605, 491);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(225, 40);
            btnVolver.TabIndex = 28;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // ListadoVentas
            // 
            dataGridViewCellStyle1.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue;
            ListadoVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ListadoVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ListadoVentas.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(10, 68, 101);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(10, 68, 101);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ListadoVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ListadoVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListadoVentas.Columns.AddRange(new DataGridViewColumn[] { IdCliente, ApellidoNombre, NombreProducto, Precio, MedioDePago, FechaVenta, ObsSobreVenta, HoraFin, UserName });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ListadoVentas.DefaultCellStyle = dataGridViewCellStyle3;
            ListadoVentas.EnableHeadersVisualStyles = false;
            ListadoVentas.GridColor = Color.White;
            ListadoVentas.Location = new Point(13, 73);
            ListadoVentas.Margin = new Padding(4, 5, 4, 5);
            ListadoVentas.Name = "ListadoVentas";
            ListadoVentas.RowHeadersVisible = false;
            ListadoVentas.RowHeadersWidth = 62;
            ListadoVentas.RowTemplate.Height = 25;
            ListadoVentas.Size = new Size(830, 387);
            ListadoVentas.TabIndex = 30;
            ListadoVentas.CellFormatting += ListadoVentas_CellFormatting;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 465);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 41;
            label2.Text = "Filtrar por TMK";
            // 
            // comboBoxTelemarketers
            // 
            comboBoxTelemarketers.BackColor = Color.SteelBlue;
            comboBoxTelemarketers.ForeColor = Color.White;
            comboBoxTelemarketers.FormattingEnabled = true;
            comboBoxTelemarketers.Location = new Point(13, 489);
            comboBoxTelemarketers.Name = "comboBoxTelemarketers";
            comboBoxTelemarketers.Size = new Size(209, 33);
            comboBoxTelemarketers.TabIndex = 40;
            // 
            // IdCliente
            // 
            IdCliente.DataPropertyName = "IdCliente";
            IdCliente.HeaderText = "ID CLIENTE";
            IdCliente.MinimumWidth = 8;
            IdCliente.Name = "IdCliente";
            IdCliente.Width = 135;
            // 
            // ApellidoNombre
            // 
            ApellidoNombre.DataPropertyName = "ApellidoNombre";
            ApellidoNombre.HeaderText = "NOMBRE CLIENTE";
            ApellidoNombre.MinimumWidth = 8;
            ApellidoNombre.Name = "ApellidoNombre";
            ApellidoNombre.Width = 174;
            // 
            // NombreProducto
            // 
            NombreProducto.DataPropertyName = "NombreProducto";
            NombreProducto.HeaderText = "PRODUCTO";
            NombreProducto.MinimumWidth = 8;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.Width = 141;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            Precio.HeaderText = "TOTAL";
            Precio.MinimumWidth = 8;
            Precio.Name = "Precio";
            Precio.Width = 97;
            // 
            // MedioDePago
            // 
            MedioDePago.DataPropertyName = "Descripcion";
            MedioDePago.HeaderText = "MEDIO DE PAGO";
            MedioDePago.MinimumWidth = 8;
            MedioDePago.Name = "MedioDePago";
            MedioDePago.Width = 126;
            // 
            // FechaVenta
            // 
            FechaVenta.DataPropertyName = "FechaVenta";
            FechaVenta.HeaderText = "FECHA/ HORA";
            FechaVenta.MinimumWidth = 8;
            FechaVenta.Name = "FechaVenta";
            FechaVenta.Width = 151;
            // 
            // ObsSobreVenta
            // 
            ObsSobreVenta.DataPropertyName = "ObsSobreVenta";
            ObsSobreVenta.HeaderText = "OBSERVACIONES";
            ObsSobreVenta.MinimumWidth = 8;
            ObsSobreVenta.Name = "ObsSobreVenta";
            ObsSobreVenta.Visible = false;
            ObsSobreVenta.Width = 186;
            // 
            // HoraFin
            // 
            HoraFin.DataPropertyName = "HoraFin";
            HoraFin.HeaderText = "TIEMPO VENTA";
            HoraFin.MinimumWidth = 8;
            HoraFin.Name = "HoraFin";
            HoraFin.Visible = false;
            HoraFin.Width = 155;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserId";
            UserName.HeaderText = "ID TMK";
            UserName.MinimumWidth = 8;
            UserName.Name = "UserName";
            UserName.Width = 99;
            // 
            // FrmConsultarVentasAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 562);
            Controls.Add(label2);
            Controls.Add(comboBoxTelemarketers);
            Controls.Add(ListadoVentas);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConsultarVentasAdmin";
            Text = "FrmConsultarVentasAdmin";
            Load += FrmConsultarVentasAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)ListadoVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnVolver;
        private DataGridView ListadoVentas;
        private Label label2;
        private ComboBox comboBoxTelemarketers;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn ApellidoNombre;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn MedioDePago;
        private DataGridViewTextBoxColumn FechaVenta;
        private DataGridViewTextBoxColumn ObsSobreVenta;
        private DataGridViewTextBoxColumn HoraFin;
        private DataGridViewTextBoxColumn UserName;
    }
}