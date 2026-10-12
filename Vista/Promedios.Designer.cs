namespace Vista
{
    partial class Promedios
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
            pnlCabeceraPromedios = new Panel();
            cboTipoPromedio = new ComboBox();
            label1 = new Label();
            dgvPromedios = new DataGridView();
            lblNuevoPromedio = new Label();
            cboNuevoPromedio = new ComboBox();
            dgvResumenFinanzas = new DataGridView();
            dgvParametros = new DataGridView();
            btnAtras = new Button();
            btnAdelante = new Button();
            btnGuardar = new Button();
            btnResetear = new Button();
            pnlCabeceraPromedios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPromedios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResumenFinanzas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParametros).BeginInit();
            SuspendLayout();
            // 
            // pnlCabeceraPromedios
            // 
            pnlCabeceraPromedios.BorderStyle = BorderStyle.FixedSingle;
            pnlCabeceraPromedios.Controls.Add(cboTipoPromedio);
            pnlCabeceraPromedios.Controls.Add(label1);
            pnlCabeceraPromedios.Location = new Point(29, 71);
            pnlCabeceraPromedios.Name = "pnlCabeceraPromedios";
            pnlCabeceraPromedios.Size = new Size(450, 32);
            pnlCabeceraPromedios.TabIndex = 0;
            // 
            // cboTipoPromedio
            // 
            cboTipoPromedio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoPromedio.FormattingEnabled = true;
            cboTipoPromedio.Items.AddRange(new object[] { "Feedlot" });
            cboTipoPromedio.Location = new Point(265, 1);
            cboTipoPromedio.Name = "cboTipoPromedio";
            cboTipoPromedio.Size = new Size(180, 28);
            cboTipoPromedio.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 5);
            label1.Name = "label1";
            label1.Size = new Size(127, 23);
            label1.TabIndex = 0;
            label1.Text = "Tus promedios";
            // 
            // dgvPromedios
            // 
            dgvPromedios.AllowUserToAddRows = false;
            dgvPromedios.AllowUserToResizeColumns = false;
            dgvPromedios.BackgroundColor = Color.White;
            dgvPromedios.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPromedios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPromedios.Location = new Point(29, 102);
            dgvPromedios.Name = "dgvPromedios";
            dgvPromedios.RowHeadersVisible = false;
            dgvPromedios.RowHeadersWidth = 51;
            dgvPromedios.ScrollBars = ScrollBars.None;
            dgvPromedios.Size = new Size(450, 260);
            dgvPromedios.TabIndex = 1;
            // 
            // lblNuevoPromedio
            // 
            lblNuevoPromedio.AutoSize = true;
            lblNuevoPromedio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNuevoPromedio.Location = new Point(509, 71);
            lblNuevoPromedio.Name = "lblNuevoPromedio";
            lblNuevoPromedio.Size = new Size(145, 23);
            lblNuevoPromedio.TabIndex = 2;
            lblNuevoPromedio.Text = "Nuevo promedio";
            // 
            // cboNuevoPromedio
            // 
            cboNuevoPromedio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNuevoPromedio.FormattingEnabled = true;
            cboNuevoPromedio.Items.AddRange(new object[] { "Media res", "Pollo", "Cerdo", "Cordero", "Varios" });
            cboNuevoPromedio.Location = new Point(509, 96);
            cboNuevoPromedio.Name = "cboNuevoPromedio";
            cboNuevoPromedio.Size = new Size(200, 28);
            cboNuevoPromedio.TabIndex = 3;
            // 
            // dgvResumenFinanzas
            // 
            dgvResumenFinanzas.AllowUserToAddRows = false;
            dgvResumenFinanzas.BackgroundColor = Color.White;
            dgvResumenFinanzas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvResumenFinanzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumenFinanzas.Location = new Point(29, 381);
            dgvResumenFinanzas.Name = "dgvResumenFinanzas";
            dgvResumenFinanzas.RowHeadersVisible = false;
            dgvResumenFinanzas.RowHeadersWidth = 51;
            dgvResumenFinanzas.ScrollBars = ScrollBars.None;
            dgvResumenFinanzas.Size = new Size(270, 130);
            dgvResumenFinanzas.TabIndex = 4;
            // 
            // dgvParametros
            // 
            dgvParametros.AllowUserToAddRows = false;
            dgvParametros.BackgroundColor = Color.White;
            dgvParametros.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvParametros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParametros.Location = new Point(314, 391);
            dgvParametros.Name = "dgvParametros";
            dgvParametros.RowHeadersVisible = false;
            dgvParametros.RowHeadersWidth = 51;
            dgvParametros.ScrollBars = ScrollBars.None;
            dgvParametros.Size = new Size(165, 110);
            dgvParametros.TabIndex = 5;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.AliceBlue;
            btnAtras.Location = new Point(509, 361);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(160, 34);
            btnAtras.TabIndex = 6;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = false;
            // 
            // btnAdelante
            // 
            btnAdelante.BackColor = Color.AliceBlue;
            btnAdelante.Location = new Point(509, 403);
            btnAdelante.Name = "btnAdelante";
            btnAdelante.Size = new Size(160, 34);
            btnAdelante.TabIndex = 7;
            btnAdelante.Text = "Adelante";
            btnAdelante.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.AliceBlue;
            btnGuardar.Location = new Point(509, 445);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 34);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnResetear
            // 
            btnResetear.BackColor = Color.AliceBlue;
            btnResetear.Location = new Point(509, 487);
            btnResetear.Name = "btnResetear";
            btnResetear.Size = new Size(160, 34);
            btnResetear.TabIndex = 9;
            btnResetear.Text = "Resetear";
            btnResetear.UseVisualStyleBackColor = false;
            // 
            // Promedios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(860, 535);
            Controls.Add(btnResetear);
            Controls.Add(btnGuardar);
            Controls.Add(btnAdelante);
            Controls.Add(btnAtras);
            Controls.Add(dgvParametros);
            Controls.Add(dgvResumenFinanzas);
            Controls.Add(cboNuevoPromedio);
            Controls.Add(lblNuevoPromedio);
            Controls.Add(dgvPromedios);
            Controls.Add(pnlCabeceraPromedios);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Promedios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Promedios";
            pnlCabeceraPromedios.ResumeLayout(false);
            pnlCabeceraPromedios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPromedios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResumenFinanzas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvParametros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCabeceraPromedios;
        private ComboBox cboTipoPromedio;
        private Label label1;
        private DataGridView dgvPromedios;
        private Label lblNuevoPromedio;
        private ComboBox cboNuevoPromedio;
        private DataGridView dgvResumenFinanzas;
        private DataGridView dgvParametros;
        private Button btnAtras;
        private Button btnAdelante;
        private Button btnGuardar;
        private Button btnResetear;
    }
}