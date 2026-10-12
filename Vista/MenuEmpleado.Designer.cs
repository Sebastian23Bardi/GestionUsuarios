namespace Vista
{
    partial class MenuEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEmpleado));
            btnFinanzas = new Button();
            btnBalance = new Button();
            btnPrecios = new Button();
            label1 = new Label();
            panel1 = new Panel();
            btnCerrarSesion = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFinanzas
            // 
            btnFinanzas.BackColor = Color.White;
            btnFinanzas.Cursor = Cursors.Hand;
            btnFinanzas.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnFinanzas.FlatStyle = FlatStyle.Flat;
            btnFinanzas.Font = new Font("Segoe UI", 12F);
            btnFinanzas.ForeColor = SystemColors.GrayText;
            btnFinanzas.Image = (Image)resources.GetObject("btnFinanzas.Image");
            btnFinanzas.ImageAlign = ContentAlignment.TopCenter;
            btnFinanzas.Location = new Point(59, 59);
            btnFinanzas.Margin = new Padding(3, 2, 3, 2);
            btnFinanzas.Name = "btnFinanzas";
            btnFinanzas.Size = new Size(85, 88);
            btnFinanzas.TabIndex = 0;
            btnFinanzas.Text = "Finanzas";
            btnFinanzas.TextImageRelation = TextImageRelation.TextAboveImage;
            btnFinanzas.UseVisualStyleBackColor = false;
            // 
            // btnBalance
            // 
            btnBalance.BackColor = Color.White;
            btnBalance.Cursor = Cursors.Hand;
            btnBalance.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnBalance.FlatStyle = FlatStyle.Flat;
            btnBalance.Font = new Font("Segoe UI", 12F);
            btnBalance.ForeColor = SystemColors.GrayText;
            btnBalance.Image = (Image)resources.GetObject("btnBalance.Image");
            btnBalance.Location = new Point(206, 59);
            btnBalance.Margin = new Padding(3, 2, 3, 2);
            btnBalance.Name = "btnBalance";
            btnBalance.Size = new Size(85, 86);
            btnBalance.TabIndex = 1;
            btnBalance.Text = "Balance";
            btnBalance.TextImageRelation = TextImageRelation.TextAboveImage;
            btnBalance.UseVisualStyleBackColor = false;
            // 
            // btnPrecios
            // 
            btnPrecios.BackColor = Color.White;
            btnPrecios.Cursor = Cursors.Hand;
            btnPrecios.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnPrecios.FlatStyle = FlatStyle.Flat;
            btnPrecios.Font = new Font("Segoe UI", 12F);
            btnPrecios.ForeColor = SystemColors.GrayText;
            btnPrecios.Image = (Image)resources.GetObject("btnPrecios.Image");
            btnPrecios.ImageAlign = ContentAlignment.BottomLeft;
            btnPrecios.Location = new Point(355, 57);
            btnPrecios.Margin = new Padding(3, 2, 3, 2);
            btnPrecios.Name = "btnPrecios";
            btnPrecios.Size = new Size(85, 88);
            btnPrecios.TabIndex = 2;
            btnPrecios.Text = "Precios";
            btnPrecios.TextImageRelation = TextImageRelation.TextAboveImage;
            btnPrecios.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 21);
            label1.TabIndex = 0;
            label1.Text = "ReGest | Menú Operativo";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(92, 29, 36);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(551, 28);
            panel1.TabIndex = 3;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.White;
            btnCerrarSesion.Location = new Point(385, 2);
            btnCerrarSesion.Margin = new Padding(3, 2, 3, 2);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(108, 22);
            btnCerrarSesion.TabIndex = 1;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // MenuEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(503, 190);
            Controls.Add(panel1);
            Controls.Add(btnPrecios);
            Controls.Add(btnBalance);
            Controls.Add(btnFinanzas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuEmpleado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnFinanzas;
        private Button btnBalance;
        private Button btnPrecios;
        private Label label1;
        private Panel panel1;
        private Button btnCerrarSesion;
    }
}