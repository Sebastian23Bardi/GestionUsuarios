namespace Vista
{
    partial class Cuentas
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
            pnlCabecera = new Panel();
            cboFiltro = new ComboBox();
            lblTituloCuentas = new Label();
            dgvCuentas = new DataGridView();
            btnAgregarEntrada = new Button();
            lblAgregarEntrada = new Label();
            btnAgregarSalida = new Button();
            lblAgregarSalida = new Label();
            pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecera
            // 
            pnlCabecera.BackColor = Color.White;
            pnlCabecera.BorderStyle = BorderStyle.FixedSingle;
            pnlCabecera.Controls.Add(cboFiltro);
            pnlCabecera.Controls.Add(lblTituloCuentas);
            pnlCabecera.Location = new Point(20, 20);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(400, 34);
            pnlCabecera.TabIndex = 0;
            // 
            // cboFiltro
            // 
            cboFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFiltro.FormattingEnabled = true;
            cboFiltro.Items.AddRange(new object[] { "Ver todo" });
            cboFiltro.Location = new Point(245, 2);
            cboFiltro.Name = "cboFiltro";
            cboFiltro.Size = new Size(150, 28);
            cboFiltro.TabIndex = 1;
            // 
            // lblTituloCuentas
            // 
            lblTituloCuentas.AutoSize = true;
            lblTituloCuentas.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloCuentas.Location = new Point(5, 5);
            lblTituloCuentas.Name = "lblTituloCuentas";
            lblTituloCuentas.Size = new Size(80, 25);
            lblTituloCuentas.TabIndex = 0;
            lblTituloCuentas.Text = "Cuentas";
            // 
            // dgvCuentas
            // 
            dgvCuentas.AllowUserToAddRows = false;
            dgvCuentas.AllowUserToResizeColumns = false;
            dgvCuentas.BackgroundColor = Color.White;
            dgvCuentas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentas.Location = new Point(20, 53);
            dgvCuentas.Name = "dgvCuentas";
            dgvCuentas.RowHeadersVisible = false;
            dgvCuentas.RowHeadersWidth = 51;
            dgvCuentas.Size = new Size(400, 380);
            dgvCuentas.TabIndex = 1;
            // 
            // btnAgregarEntrada
            // 
            btnAgregarEntrada.FlatAppearance.BorderColor = Color.ForestGreen;
            btnAgregarEntrada.FlatAppearance.BorderSize = 2;
            btnAgregarEntrada.FlatStyle = FlatStyle.Flat;
            btnAgregarEntrada.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarEntrada.ForeColor = Color.ForestGreen;
            btnAgregarEntrada.Location = new Point(460, 70);
            btnAgregarEntrada.Name = "btnAgregarEntrada";
            btnAgregarEntrada.Size = new Size(110, 45);
            btnAgregarEntrada.TabIndex = 2;
            btnAgregarEntrada.Text = "+";
            btnAgregarEntrada.UseVisualStyleBackColor = true;
            // 
            // lblAgregarEntrada
            // 
            lblAgregarEntrada.AutoSize = true;
            lblAgregarEntrada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgregarEntrada.ForeColor = Color.ForestGreen;
            lblAgregarEntrada.Location = new Point(460, 118);
            lblAgregarEntrada.Name = "lblAgregarEntrada";
            lblAgregarEntrada.Size = new Size(124, 20);
            lblAgregarEntrada.TabIndex = 3;
            lblAgregarEntrada.Text = "Agregar entrada";
            // 
            // btnAgregarSalida
            // 
            btnAgregarSalida.FlatAppearance.BorderColor = Color.Crimson;
            btnAgregarSalida.FlatAppearance.BorderSize = 2;
            btnAgregarSalida.FlatStyle = FlatStyle.Flat;
            btnAgregarSalida.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarSalida.ForeColor = Color.Crimson;
            btnAgregarSalida.Location = new Point(460, 180);
            btnAgregarSalida.Name = "btnAgregarSalida";
            btnAgregarSalida.Size = new Size(110, 45);
            btnAgregarSalida.TabIndex = 4;
            btnAgregarSalida.Text = "-";
            btnAgregarSalida.UseVisualStyleBackColor = true;
            // 
            // lblAgregarSalida
            // 
            lblAgregarSalida.AutoSize = true;
            lblAgregarSalida.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgregarSalida.ForeColor = Color.Crimson;
            lblAgregarSalida.Location = new Point(460, 230);
            lblAgregarSalida.Name = "lblAgregarSalida";
            lblAgregarSalida.Size = new Size(110, 20);
            lblAgregarSalida.TabIndex = 5;
            lblAgregarSalida.Text = "Agregar salida";
            // 
            // Cuentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 450);
            Controls.Add(lblAgregarSalida);
            Controls.Add(btnAgregarSalida);
            Controls.Add(lblAgregarEntrada);
            Controls.Add(btnAgregarEntrada);
            Controls.Add(dgvCuentas);
            Controls.Add(pnlCabecera);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Cuentas";
            Text = "Finanzas";
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCabecera;
        private Label lblTituloCuentas;
        private ComboBox cboFiltro;
        private DataGridView dgvCuentas;
        private Button btnAgregarEntrada;
        private Label lblAgregarEntrada;
        private Button btnAgregarSalida;
        private Label lblAgregarSalida;
    }
}