namespace AppTelemarketing
{
    partial class FrmEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpresas));
            btnFlow = new Button();
            btnMovistar = new Button();
            btnTelecentro = new Button();
            label1 = new Label();
            btnVolver = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFlow
            // 
            btnFlow.BackColor = Color.Transparent;
            btnFlow.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 130, 126);
            btnFlow.FlatStyle = FlatStyle.Flat;
            btnFlow.Image = (Image)resources.GetObject("btnFlow.Image");
            btnFlow.Location = new Point(-16, 40);
            btnFlow.Name = "btnFlow";
            btnFlow.Size = new Size(504, 189);
            btnFlow.TabIndex = 0;
            btnFlow.UseVisualStyleBackColor = false;
            btnFlow.Click += btnFlow_Click;
            // 
            // btnMovistar
            // 
            btnMovistar.BackColor = Color.Transparent;
            btnMovistar.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 130, 126);
            btnMovistar.FlatStyle = FlatStyle.Flat;
            btnMovistar.Image = (Image)resources.GetObject("btnMovistar.Image");
            btnMovistar.Location = new Point(-46, 226);
            btnMovistar.Name = "btnMovistar";
            btnMovistar.Size = new Size(534, 189);
            btnMovistar.TabIndex = 1;
            btnMovistar.UseVisualStyleBackColor = false;
            btnMovistar.Click += btnMovistar_Click;
            // 
            // btnTelecentro
            // 
            btnTelecentro.BackColor = Color.Transparent;
            btnTelecentro.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 130, 126);
            btnTelecentro.FlatStyle = FlatStyle.Flat;
            btnTelecentro.Image = (Image)resources.GetObject("btnTelecentro.Image");
            btnTelecentro.Location = new Point(-2, 411);
            btnTelecentro.Name = "btnTelecentro";
            btnTelecentro.Size = new Size(490, 189);
            btnTelecentro.TabIndex = 2;
            btnTelecentro.UseVisualStyleBackColor = false;
            btnTelecentro.Click += btnTelecentro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(156, 9);
            label1.Name = "label1";
            label1.Size = new Size(198, 28);
            label1.TabIndex = 3;
            label1.Text = "Seleccione Empresa";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(1, 107, 104);
            btnVolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(-2, 590);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(490, 51);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 107, 104);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 45);
            panel1.TabIndex = 5;
            // 
            // FrmEmpresas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(485, 639);
            Controls.Add(panel1);
            Controls.Add(btnVolver);
            Controls.Add(btnTelecentro);
            Controls.Add(btnMovistar);
            Controls.Add(btnFlow);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEmpresas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEmpresas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnFlow;
        private Button btnMovistar;
        private Button btnTelecentro;
        private Label label1;
        private Button btnVolver;
        private Panel panel1;
    }
}