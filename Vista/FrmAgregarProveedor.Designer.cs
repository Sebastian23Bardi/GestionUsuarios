namespace Vista
{
    partial class FrmAgregarProveedor
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
            lblNombre = new Label();
            lblTeléfono = new Label();
            lblCorreo = new Label();
            lblAliasBancario = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtAlias = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.2F);
            lblNombre.Location = new Point(56, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblTeléfono
            // 
            lblTeléfono.AutoSize = true;
            lblTeléfono.Font = new Font("Segoe UI", 10.2F);
            lblTeléfono.Location = new Point(56, 82);
            lblTeléfono.Name = "lblTeléfono";
            lblTeléfono.Size = new Size(78, 23);
            lblTeléfono.TabIndex = 1;
            lblTeléfono.Text = "Teléfono:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10.2F);
            lblCorreo.Location = new Point(56, 132);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(66, 23);
            lblCorreo.TabIndex = 2;
            lblCorreo.Text = "Correo:";
            // 
            // lblAliasBancario
            // 
            lblAliasBancario.AutoSize = true;
            lblAliasBancario.Font = new Font("Segoe UI", 10.2F);
            lblAliasBancario.Location = new Point(32, 183);
            lblAliasBancario.Name = "lblAliasBancario";
            lblAliasBancario.Size = new Size(120, 23);
            lblAliasBancario.TabIndex = 3;
            lblAliasBancario.Text = "Alias Bancario:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(169, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(205, 30);
            txtNombre.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(169, 78);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(205, 30);
            txtTelefono.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(169, 129);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(205, 30);
            txtCorreo.TabIndex = 6;
            // 
            // txtAlias
            // 
            txtAlias.Location = new Point(169, 179);
            txtAlias.Name = "txtAlias";
            txtAlias.Size = new Size(205, 30);
            txtAlias.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(92, 29, 36);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.Window;
            btnGuardar.Location = new Point(46, 247);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 33);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = SystemColors.ControlText;
            btnCancelar.Location = new Point(268, 247);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 33);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAgregarProveedor
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(422, 308);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtAlias);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(lblAliasBancario);
            Controls.Add(lblCorreo);
            Controls.Add(lblTeléfono);
            Controls.Add(lblNombre);
            Font = new Font("Segoe UI", 10.2F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmAgregarProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAgregarProveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblTeléfono;
        private Label lblCorreo;
        private Label lblAliasBancario;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtAlias;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}