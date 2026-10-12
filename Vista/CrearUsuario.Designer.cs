namespace Vista
{
    partial class CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearUsuario));
            btnEnviar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtCorreo = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            lblrol = new Label();
            cmbRol = new ComboBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(92, 29, 36);
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviar.ForeColor = SystemColors.ControlLightLight;
            btnEnviar.Location = new Point(329, 189);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(87, 32);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "Crear";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(65, 74);
            label1.Name = "label1";
            label1.Size = new Size(66, 23);
            label1.TabIndex = 1;
            label1.Text = "Correo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(58, 116);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 2;
            label2.Text = "Usuario:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(136, 74);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(204, 27);
            txtCorreo.TabIndex = 3;

            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(136, 116);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(204, 27);
            txtUsuario.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(149, 20);
            label3.Name = "label3";
            label3.Size = new Size(144, 23);
            label3.TabIndex = 5;
            label3.Text = "Ingrese los datos ";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(92, 29, 36);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(444, 55);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(441, 49);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblrol
            // 
            lblrol.AutoSize = true;
            lblrol.Font = new Font("Segoe UI", 10.2F);
            lblrol.ForeColor = SystemColors.ControlDarkDark;
            lblrol.Location = new Point(96, 159);
            lblrol.Name = "lblrol";
            lblrol.Size = new Size(38, 23);
            lblrol.TabIndex = 7;
            lblrol.Text = "Rol:";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(136, 158);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(151, 28);
            cmbRol.TabIndex = 8;
            
            // 
            // CrearUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(444, 253);
            Controls.Add(cmbRol);
            Controls.Add(lblrol);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(txtCorreo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEnviar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Name = "CrearUsuario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CrearUsuario";
            Load += CrearUsuario_Load;
            KeyDown += CrearUsuario_KeyDown;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private Label label1;
        private Label label2;
        private TextBox txtCorreo;
        private TextBox txtUsuario;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Label lblrol;
        private ComboBox cmbRol;
    }
}