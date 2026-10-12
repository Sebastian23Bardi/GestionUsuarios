
namespace login_promires
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            contraseña = new Label();
            usuario = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnSiguiente = new Button();
            cbcontra = new CheckBox();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contraseña
            // 
            contraseña.AutoSize = true;
            contraseña.Location = new Point(270, 139);
            contraseña.Name = "contraseña";
            contraseña.Size = new Size(86, 20);
            contraseña.TabIndex = 999;
            contraseña.Text = "Contraseña:";
            // 
            // usuario
            // 
            usuario.AutoSize = true;
            usuario.Location = new Point(296, 83);
            usuario.Name = "usuario";
            usuario.Size = new Size(62, 20);
            usuario.TabIndex = 9999;
            usuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Window;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(360, 80);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(252, 27);
            txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Location = new Point(360, 136);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(252, 27);
            txtContraseña.TabIndex = 3;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.FromArgb(192, 0, 0);
            btnSiguiente.FlatStyle = FlatStyle.Popup;
            btnSiguiente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = SystemColors.ButtonFace;
            btnSiguiente.Location = new Point(515, 281);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(97, 40);
            btnSiguiente.TabIndex = 6;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnIngresar_Click;
            // 
            // cbcontra
            // 
            cbcontra.AutoSize = true;
            cbcontra.Location = new Point(368, 199);
            cbcontra.Name = "cbcontra";
            cbcontra.Size = new Size(158, 24);
            cbcontra.TabIndex = 4;
            cbcontra.Text = "Mostrar contraseña";
            cbcontra.UseVisualStyleBackColor = true;
            cbcontra.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(368, 239);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(152, 20);
            linkLabel1.TabIndex = 10000;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Recuperar contraseña";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(92, 29, 36);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 351);
            panel1.TabIndex = 10001;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-90, -20);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(434, 433);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AcceptButton = btnSiguiente;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(638, 351);
            Controls.Add(panel1);
            Controls.Add(linkLabel1);
            Controls.Add(cbcontra);
            Controls.Add(btnSiguiente);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(usuario);
            Controls.Add(contraseña);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesión";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label contraseña;
        private Label usuario;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnSiguiente;
        private CheckBox cbcontra;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
