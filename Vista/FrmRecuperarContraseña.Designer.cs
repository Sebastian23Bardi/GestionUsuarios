namespace Vista
{
    partial class FrmRecuperarContraseña
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
            label1 = new Label();
            label2 = new Label();
            txtNuevaContra = new TextBox();
            txtConfirmarContra = new TextBox();
            btnConfirmar = new Button();
            panel1 = new Panel();
            btnValidarRespuesta = new Button();
            txtRespuesta = new TextBox();
            lblPreguntas = new Label();
            preguntas = new Label();
            label3 = new Label();
            panel2 = new Panel();
            chkMostrarContra = new CheckBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 35);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 0;
            label1.Text = "Nueva Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 82);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 1;
            label2.Text = "Confirmar contraseña:";
            // 
            // txtNuevaContra
            // 
            txtNuevaContra.Location = new Point(163, 32);
            txtNuevaContra.Name = "txtNuevaContra";
            txtNuevaContra.Size = new Size(215, 27);
            txtNuevaContra.TabIndex = 2;
            txtNuevaContra.TextChanged += txtNuevaContra_TextChanged;
            // 
            // txtConfirmarContra
            // 
            txtConfirmarContra.Location = new Point(163, 80);
            txtConfirmarContra.Name = "txtConfirmarContra";
            txtConfirmarContra.Size = new Size(215, 27);
            txtConfirmarContra.TabIndex = 3;
            txtConfirmarContra.TextChanged += txtConfirmarContra_TextChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(92, 29, 36);
            btnConfirmar.FlatStyle = FlatStyle.Popup;
            btnConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = SystemColors.ControlLightLight;
            btnConfirmar.Location = new Point(412, 35);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(97, 67);
            btnConfirmar.TabIndex = 14;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnValidarRespuesta);
            panel1.Controls.Add(txtRespuesta);
            panel1.Controls.Add(lblPreguntas);
            panel1.Location = new Point(12, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 141);
            panel1.TabIndex = 17;
            // 
            // btnValidarRespuesta
            // 
            btnValidarRespuesta.BackColor = Color.FromArgb(192, 0, 0);
            btnValidarRespuesta.FlatStyle = FlatStyle.Popup;
            btnValidarRespuesta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidarRespuesta.ForeColor = Color.White;
            btnValidarRespuesta.Location = new Point(315, 84);
            btnValidarRespuesta.Name = "btnValidarRespuesta";
            btnValidarRespuesta.Size = new Size(185, 29);
            btnValidarRespuesta.TabIndex = 18;
            btnValidarRespuesta.Text = "Validar Respuesta";
            btnValidarRespuesta.UseVisualStyleBackColor = false;
            btnValidarRespuesta.Click += btnValidarRespuesta_Click;
            // 
            // txtRespuesta
            // 
            txtRespuesta.Location = new Point(14, 37);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(488, 27);
            txtRespuesta.TabIndex = 17;
            txtRespuesta.TextChanged += txtRespuesta_TextChanged;
            // 
            // lblPreguntas
            // 
            lblPreguntas.BackColor = Color.White;
            lblPreguntas.BorderStyle = BorderStyle.Fixed3D;
            lblPreguntas.Location = new Point(14, 9);
            lblPreguntas.Name = "lblPreguntas";
            lblPreguntas.Size = new Size(488, 25);
            lblPreguntas.TabIndex = 16;
            lblPreguntas.Text = "label1";
            lblPreguntas.Click += lblPreguntas_Click;
            // 
            // preguntas
            // 
            preguntas.AutoSize = true;
            preguntas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            preguntas.Location = new Point(28, 21);
            preguntas.Name = "preguntas";
            preguntas.Size = new Size(0, 20);
            preguntas.TabIndex = 18;
            preguntas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 21);
            label3.Name = "label3";
            label3.Size = new Size(231, 20);
            label3.TabIndex = 19;
            label3.Text = "Verifica tus respuestas registradas";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.Controls.Add(chkMostrarContra);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtNuevaContra);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtConfirmarContra);
            panel2.Controls.Add(btnConfirmar);
            panel2.Location = new Point(12, 239);
            panel2.Name = "panel2";
            panel2.Size = new Size(517, 164);
            panel2.TabIndex = 21;
            // 
            // chkMostrarContra
            // 
            chkMostrarContra.AutoSize = true;
            chkMostrarContra.Enabled = false;
            chkMostrarContra.Location = new Point(163, 122);
            chkMostrarContra.Name = "chkMostrarContra";
            chkMostrarContra.Size = new Size(160, 24);
            chkMostrarContra.TabIndex = 15;
            chkMostrarContra.Text = "Mostrar Contraseña";
            chkMostrarContra.UseVisualStyleBackColor = true;
            chkMostrarContra.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 205);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 22;
            label4.Text = "Cambiar Contraseña";
            // 
            // FrmRecuperarContraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(539, 429);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(preguntas);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmRecuperarContraseña";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recuperar Contraseña";
            Load += FrmRecuperarContraseña_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNuevaContra;
        private TextBox txtConfirmarContra;
        private Button btnConfirmar;
        private Panel panel1;
        private Button btnValidarRespuesta;
        private TextBox txtRespuesta;
        private Label lblPreguntas;
        private Label preguntas;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private CheckBox chkMostrarContra;
    }
}