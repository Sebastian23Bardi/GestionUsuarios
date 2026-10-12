namespace Recuperacion_de_contraseña
{
    partial class FrmPrimerIngreso
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
            NuevaContra = new Label();
            ConfirmarContraseña = new Label();
            txtContraseña1 = new TextBox();
            txtContraseña2 = new TextBox();
            preguntas = new Label();
            btnCambiarContra = new Button();
            btnrespuesta = new Button();
            txtrespuesta = new TextBox();
            panel2 = new Panel();
            chkPregunta3 = new RadioButton();
            chkPregunta2 = new RadioButton();
            chkPregunta1 = new RadioButton();
            label5 = new Label();
            ProgressBar = new ProgressBar();
            label1 = new Label();
            cmbPreguntas = new ComboBox();
            panel1 = new Panel();
            chkMostrarContra = new CheckBox();
            lblpaso1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NuevaContra
            // 
            NuevaContra.AutoSize = true;
            NuevaContra.Location = new Point(5, 33);
            NuevaContra.Name = "NuevaContra";
            NuevaContra.Size = new Size(132, 20);
            NuevaContra.TabIndex = 0;
            NuevaContra.Text = "Nueva Contraseña:";
            // 
            // ConfirmarContraseña
            // 
            ConfirmarContraseña.AutoSize = true;
            ConfirmarContraseña.Location = new Point(5, 85);
            ConfirmarContraseña.Name = "ConfirmarContraseña";
            ConfirmarContraseña.Size = new Size(156, 20);
            ConfirmarContraseña.TabIndex = 1;
            ConfirmarContraseña.Text = "Confirmar Contraseña:";
            // 
            // txtContraseña1
            // 
            txtContraseña1.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña1.Enabled = false;
            txtContraseña1.Location = new Point(167, 31);
            txtContraseña1.Name = "txtContraseña1";
            txtContraseña1.Size = new Size(215, 27);
            txtContraseña1.TabIndex = 3;
            txtContraseña1.UseSystemPasswordChar = true;
            // 
            // txtContraseña2
            // 
            txtContraseña2.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña2.Enabled = false;
            txtContraseña2.Location = new Point(167, 83);
            txtContraseña2.Name = "txtContraseña2";
            txtContraseña2.Size = new Size(215, 27);
            txtContraseña2.TabIndex = 4;
            txtContraseña2.UseSystemPasswordChar = true;
            // 
            // preguntas
            // 
            preguntas.AutoSize = true;
            preguntas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            preguntas.Location = new Point(12, 309);
            preguntas.Name = "preguntas";
            preguntas.Size = new Size(240, 20);
            preguntas.TabIndex = 5;
            preguntas.Text = "Paso 2: Creá tu nueva contraseña";
            preguntas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCambiarContra
            // 
            btnCambiarContra.BackColor = Color.FromArgb(92, 29, 36);
            btnCambiarContra.Enabled = false;
            btnCambiarContra.FlatStyle = FlatStyle.Popup;
            btnCambiarContra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiarContra.ForeColor = SystemColors.ControlLightLight;
            btnCambiarContra.Location = new Point(389, 38);
            btnCambiarContra.Name = "btnCambiarContra";
            btnCambiarContra.Size = new Size(97, 67);
            btnCambiarContra.TabIndex = 13;
            btnCambiarContra.Text = "Confirmar";
            btnCambiarContra.UseVisualStyleBackColor = false;
            btnCambiarContra.Click += btnCambiarContra_Click;
            // 
            // btnrespuesta
            // 
            btnrespuesta.BackColor = Color.FromArgb(192, 0, 0);
            btnrespuesta.FlatStyle = FlatStyle.Popup;
            btnrespuesta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnrespuesta.ForeColor = Color.White;
            btnrespuesta.Location = new Point(155, 220);
            btnrespuesta.Name = "btnrespuesta";
            btnrespuesta.Size = new Size(166, 29);
            btnrespuesta.TabIndex = 18;
            btnrespuesta.Text = "Guardar respuesta";
            btnrespuesta.UseVisualStyleBackColor = false;
            btnrespuesta.Click += btnrespuesta_Click;
            // 
            // txtrespuesta
            // 
            txtrespuesta.Location = new Point(3, 104);
            txtrespuesta.Name = "txtrespuesta";
            txtrespuesta.Size = new Size(333, 27);
            txtrespuesta.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.Controls.Add(chkPregunta3);
            panel2.Controls.Add(chkPregunta2);
            panel2.Controls.Add(chkPregunta1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnrespuesta);
            panel2.Controls.Add(ProgressBar);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtrespuesta);
            panel2.Controls.Add(cmbPreguntas);
            panel2.Location = new Point(11, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(504, 253);
            panel2.TabIndex = 19;
            // 
            // chkPregunta3
            // 
            chkPregunta3.AutoCheck = false;
            chkPregunta3.AutoSize = true;
            chkPregunta3.BackColor = SystemColors.InactiveCaption;
            chkPregunta3.Enabled = false;
            chkPregunta3.ForeColor = SystemColors.GrayText;
            chkPregunta3.Location = new Point(281, 182);
            chkPregunta3.Name = "chkPregunta3";
            chkPregunta3.Size = new Size(101, 24);
            chkPregunta3.TabIndex = 33;
            chkPregunta3.Text = "Pregunta 3";
            chkPregunta3.UseVisualStyleBackColor = false;
            // 
            // chkPregunta2
            // 
            chkPregunta2.AutoCheck = false;
            chkPregunta2.AutoSize = true;
            chkPregunta2.Enabled = false;
            chkPregunta2.ForeColor = SystemColors.GrayText;
            chkPregunta2.Location = new Point(155, 182);
            chkPregunta2.Name = "chkPregunta2";
            chkPregunta2.Size = new Size(101, 24);
            chkPregunta2.TabIndex = 32;
            chkPregunta2.Text = "Pregunta 2";
            chkPregunta2.UseVisualStyleBackColor = true;
            // 
            // chkPregunta1
            // 
            chkPregunta1.AutoCheck = false;
            chkPregunta1.AutoSize = true;
            chkPregunta1.Enabled = false;
            chkPregunta1.ForeColor = SystemColors.GrayText;
            chkPregunta1.Location = new Point(19, 182);
            chkPregunta1.Name = "chkPregunta1";
            chkPregunta1.Size = new Size(101, 24);
            chkPregunta1.TabIndex = 31;
            chkPregunta1.Text = "Pregunta 1";
            chkPregunta1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 18);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 27;
            label5.Text = "Preguntas:";
            // 
            // ProgressBar
            // 
            ProgressBar.Location = new Point(3, 137);
            ProgressBar.Maximum = 3;
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(401, 29);
            ProgressBar.Step = 1;
            ProgressBar.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 73);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 22;
            label1.Text = "Respuesta:";
            // 
            // cmbPreguntas
            // 
            cmbPreguntas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPreguntas.FormattingEnabled = true;
            cmbPreguntas.Location = new Point(3, 41);
            cmbPreguntas.Name = "cmbPreguntas";
            cmbPreguntas.Size = new Size(401, 28);
            cmbPreguntas.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(chkMostrarContra);
            panel1.Controls.Add(NuevaContra);
            panel1.Controls.Add(ConfirmarContraseña);
            panel1.Controls.Add(txtContraseña1);
            panel1.Controls.Add(btnCambiarContra);
            panel1.Controls.Add(txtContraseña2);
            panel1.Location = new Point(11, 347);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 158);
            panel1.TabIndex = 20;
            // 
            // chkMostrarContra
            // 
            chkMostrarContra.AutoSize = true;
            chkMostrarContra.Enabled = false;
            chkMostrarContra.Location = new Point(171, 122);
            chkMostrarContra.Name = "chkMostrarContra";
            chkMostrarContra.Size = new Size(160, 24);
            chkMostrarContra.TabIndex = 14;
            chkMostrarContra.Text = "Mostrar Contraseña";
            chkMostrarContra.UseVisualStyleBackColor = true;
            chkMostrarContra.CheckedChanged += chkMostrarContra_CheckedChanged;
            // 
            // lblpaso1
            // 
            lblpaso1.AutoSize = true;
            lblpaso1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblpaso1.Location = new Point(16, 9);
            lblpaso1.Name = "lblpaso1";
            lblpaso1.Size = new Size(368, 20);
            lblpaso1.TabIndex = 21;
            lblpaso1.Text = "Paso 1: Configurá tus preguntas de seguridad (0/3)";
            lblpaso1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmPrimerIngreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(532, 519);
            Controls.Add(lblpaso1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(preguntas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmPrimerIngreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Primer Ingreso";
            Load += FrmPrimerIngreso_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NuevaContra;
        private Label ConfirmarContraseña;
        private TextBox txtContraseña1;
        private TextBox txtContraseña2;
        private Label preguntas;
        private Button btnCambiarContra;
        private Button btnrespuesta;
        private TextBox txtrespuesta;
        private Panel panel2;
        private Label label1;
        private ComboBox cmbPreguntas;
        private ProgressBar ProgressBar;
        private Panel panel1;
        private Label label5;
        private Label lblpaso1;
        private RadioButton chkPregunta3;
        private RadioButton chkPregunta2;
        private RadioButton chkPregunta1;
        private CheckBox chkMostrarContra;
    }
}
