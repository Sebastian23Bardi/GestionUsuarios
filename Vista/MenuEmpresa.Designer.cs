namespace Vista
{
    partial class MenuEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEmpresa));
            btnPromedio = new Button();
            btnEmpleados = new Button();
            btnFinanzas = new Button();
            btnBalance = new Button();
            btnProveedores = new Button();
            label1 = new Label();
            btnCerrarSesion = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPromedio
            // 
            btnPromedio.BackColor = SystemColors.Window;
            btnPromedio.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnPromedio.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnPromedio.FlatStyle = FlatStyle.Flat;
            btnPromedio.Font = new Font("Segoe UI Emoji", 9F);
            btnPromedio.ForeColor = SystemColors.ControlDarkDark;
            btnPromedio.Image = (Image)resources.GetObject("btnPromedio.Image");
            btnPromedio.Location = new Point(117, 176);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(97, 117);
            btnPromedio.TabIndex = 0;
            btnPromedio.Text = "Promedio";
            btnPromedio.TextImageRelation = TextImageRelation.TextAboveImage;
            btnPromedio.UseVisualStyleBackColor = false;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = SystemColors.Window;
            btnEmpleados.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Segoe UI Emoji", 9F);
            btnEmpleados.ForeColor = SystemColors.ControlDarkDark;
            btnEmpleados.Image = (Image)resources.GetObject("btnEmpleados.Image");
            btnEmpleados.Location = new Point(58, 43);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(97, 117);
            btnEmpleados.TabIndex = 1;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.TextImageRelation = TextImageRelation.TextAboveImage;
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnFinanzas
            // 
            btnFinanzas.BackColor = SystemColors.Window;
            btnFinanzas.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnFinanzas.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnFinanzas.FlatStyle = FlatStyle.Flat;
            btnFinanzas.ForeColor = SystemColors.GrayText;
            btnFinanzas.Image = (Image)resources.GetObject("btnFinanzas.Image");
            btnFinanzas.ImageAlign = ContentAlignment.TopCenter;
            btnFinanzas.Location = new Point(367, 43);
            btnFinanzas.Name = "btnFinanzas";
            btnFinanzas.Size = new Size(97, 117);
            btnFinanzas.TabIndex = 2;
            btnFinanzas.Text = "Finanzas";
            btnFinanzas.TextAlign = ContentAlignment.TopCenter;
            btnFinanzas.TextImageRelation = TextImageRelation.TextAboveImage;
            btnFinanzas.UseVisualStyleBackColor = false;
            btnFinanzas.Click += btnFinanzas_Click_1;
            // 
            // btnBalance
            // 
            btnBalance.BackColor = SystemColors.Window;
            btnBalance.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnBalance.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnBalance.FlatStyle = FlatStyle.Flat;
            btnBalance.Font = new Font("Segoe UI", 9F);
            btnBalance.ForeColor = SystemColors.GrayText;
            btnBalance.Image = (Image)resources.GetObject("btnBalance.Image");
            btnBalance.ImageAlign = ContentAlignment.TopCenter;
            btnBalance.Location = new Point(212, 43);
            btnBalance.Name = "btnBalance";
            btnBalance.Size = new Size(97, 117);
            btnBalance.TabIndex = 3;
            btnBalance.Text = "Balance";
            btnBalance.TextImageRelation = TextImageRelation.TextAboveImage;
            btnBalance.UseVisualStyleBackColor = false;
            btnBalance.Click += btnBalance_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = SystemColors.Window;
            btnProveedores.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnProveedores.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProveedores.ForeColor = SystemColors.ControlDarkDark;
            btnProveedores.Image = (Image)resources.GetObject("btnProveedores.Image");
            btnProveedores.Location = new Point(293, 176);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(102, 117);
            btnProveedores.TabIndex = 4;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextImageRelation = TextImageRelation.TextAboveImage;
            btnProveedores.UseVisualStyleBackColor = false;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(294, 28);
            label1.TabIndex = 0;
            label1.Text = "ReGest | Panel de administración";
            label1.Click += label1_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.White;
            btnCerrarSesion.ForeColor = Color.Black;
            btnCerrarSesion.Location = new Point(405, 3);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(126, 29);
            btnCerrarSesion.TabIndex = 1;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(92, 29, 36);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 37);
            panel1.TabIndex = 5;
            // 
            // MenuEmpresa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(543, 305);
            Controls.Add(panel1);
            Controls.Add(btnProveedores);
            Controls.Add(btnBalance);
            Controls.Add(btnFinanzas);
            Controls.Add(btnEmpleados);
            Controls.Add(btnPromedio);
            Font = new Font("Segoe UI Emoji", 9F);
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MenuEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuEmpresa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPromedio;
        private Button btnEmpleados;
        private Button btnFinanzas;
        private Button btnBalance;
        private Button btnProveedores;
        private Label label1;
        private Button btnCerrarSesion;
        private Panel panel1;
    }
}