namespace AppTelemarketing
{
    partial class FrmCargarDatosBBDD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargarDatosBBDD));
            label1 = new Label();
            lbArchivos = new ListBox();
            btnVolver = new Button();
            btnCargarBD = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(148, 33);
            label1.Name = "label1";
            label1.Size = new Size(575, 26);
            label1.TabIndex = 32;
            label1.Text = "Listado de Archivos cargados en la BBDD Prospectos";
            // 
            // lbArchivos
            // 
            lbArchivos.BackColor = SystemColors.ActiveCaption;
            lbArchivos.FormattingEnabled = true;
            lbArchivos.ItemHeight = 25;
            lbArchivos.Location = new Point(219, 76);
            lbArchivos.Name = "lbArchivos";
            lbArchivos.Size = new Size(408, 379);
            lbArchivos.TabIndex = 31;
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
            btnVolver.Location = new Point(601, 510);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(226, 40);
            btnVolver.TabIndex = 33;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCargarBD
            // 
            btnCargarBD.BackColor = Color.FromArgb(10, 68, 101);
            btnCargarBD.FlatAppearance.BorderSize = 0;
            btnCargarBD.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 165, 215);
            btnCargarBD.FlatStyle = FlatStyle.Flat;
            btnCargarBD.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCargarBD.ForeColor = Color.White;
            btnCargarBD.Image = (Image)resources.GetObject("btnCargarBD.Image");
            btnCargarBD.ImageAlign = ContentAlignment.TopLeft;
            btnCargarBD.Location = new Point(219, 461);
            btnCargarBD.Name = "btnCargarBD";
            btnCargarBD.Size = new Size(176, 40);
            btnCargarBD.TabIndex = 34;
            btnCargarBD.Text = "Cargar BBDD";
            btnCargarBD.UseVisualStyleBackColor = false;
            btnCargarBD.Click += btnCargarBD_Click;
            // 
            // FrmCargarDatosBBDD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 562);
            Controls.Add(btnCargarBD);
            Controls.Add(btnVolver);
            Controls.Add(label1);
            Controls.Add(lbArchivos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCargarDatosBBDD";
            Text = "FrmCargarDatosBBDD";
            Load += FrmCargarDatosBBDD_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lbArchivos;
        private Button btnCargarBBDD;
        private Button btnVolver;
        private Button btnCargarBD;
    }
}