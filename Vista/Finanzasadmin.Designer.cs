namespace Vista
{
    partial class Finanzasadmin
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
            btnAgregarEntrada = new Button();
            btnAgregarSalida = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            lblAgregarEntrada = new Label();
            lblAgregarSalida = new Label();
            lblEliminar = new Label();
            lblEditar = new Label();
            dgvFinanzas = new DataGridView();
            pnlCabecera = new Panel();
            cboFiltro = new ComboBox();
            lblTituloFinanzas = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFinanzas).BeginInit();
            pnlCabecera.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregarEntrada
            // 
            btnAgregarEntrada.FlatAppearance.BorderColor = Color.ForestGreen;
            btnAgregarEntrada.FlatStyle = FlatStyle.Flat;
            btnAgregarEntrada.ForeColor = Color.ForestGreen;
            btnAgregarEntrada.Location = new Point(460, 40);
            btnAgregarEntrada.Name = "btnAgregarEntrada";
            btnAgregarEntrada.Size = new Size(110, 42);
            btnAgregarEntrada.TabIndex = 0;
            btnAgregarEntrada.Text = "+";
            btnAgregarEntrada.UseVisualStyleBackColor = true;
            // 
            // btnAgregarSalida
            // 
            btnAgregarSalida.FlatAppearance.BorderColor = Color.DarkOrange;
            btnAgregarSalida.FlatStyle = FlatStyle.Flat;
            btnAgregarSalida.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarSalida.ForeColor = Color.DarkOrange;
            btnAgregarSalida.Location = new Point(460, 120);
            btnAgregarSalida.Name = "btnAgregarSalida";
            btnAgregarSalida.Size = new Size(110, 42);
            btnAgregarSalida.TabIndex = 1;
            btnAgregarSalida.Text = "-";
            btnAgregarSalida.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderColor = Color.Black;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(460, 200);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 42);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "✎";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderColor = Color.Crimson;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.Crimson;
            btnEliminar.Location = new Point(460, 280);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 42);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "✕";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblAgregarEntrada
            // 
            lblAgregarEntrada.AutoSize = true;
            lblAgregarEntrada.ForeColor = Color.ForestGreen;
            lblAgregarEntrada.Location = new Point(460, 86);
            lblAgregarEntrada.Name = "lblAgregarEntrada";
            lblAgregarEntrada.Size = new Size(118, 20);
            lblAgregarEntrada.TabIndex = 4;
            lblAgregarEntrada.Text = "Agregar entrada";
            // 
            // lblAgregarSalida
            // 
            lblAgregarSalida.AutoSize = true;
            lblAgregarSalida.ForeColor = Color.DarkOrange;
            lblAgregarSalida.Location = new Point(460, 166);
            lblAgregarSalida.Name = "lblAgregarSalida";
            lblAgregarSalida.Size = new Size(104, 20);
            lblAgregarSalida.TabIndex = 5;
            lblAgregarSalida.Text = "agregar salida";
            // 
            // lblEliminar
            // 
            lblEliminar.AutoSize = true;
            lblEliminar.BackColor = Color.White;
            lblEliminar.ForeColor = Color.Crimson;
            lblEliminar.Location = new Point(460, 326);
            lblEliminar.Name = "lblEliminar";
            lblEliminar.Size = new Size(63, 20);
            lblEliminar.TabIndex = 6;
            lblEliminar.Text = "Eliminar";
            // 
            // lblEditar
            // 
            lblEditar.AutoSize = true;
            lblEditar.ForeColor = Color.Black;
            lblEditar.Location = new Point(460, 246);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(132, 20);
            lblEditar.TabIndex = 7;
            lblEditar.Text = "Editar movimiento";
            // 
            // dgvFinanzas
            // 
            dgvFinanzas.AllowUserToAddRows = false;
            dgvFinanzas.AllowUserToDeleteRows = false;
            dgvFinanzas.AllowUserToResizeColumns = false;
            dgvFinanzas.AllowUserToResizeRows = false;
            dgvFinanzas.BackgroundColor = Color.White;
            dgvFinanzas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvFinanzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFinanzas.Location = new Point(20, 53);
            dgvFinanzas.MultiSelect = false;
            dgvFinanzas.Name = "dgvFinanzas";
            dgvFinanzas.RowHeadersVisible = false;
            dgvFinanzas.RowHeadersWidth = 51;
            dgvFinanzas.ScrollBars = ScrollBars.None;
            dgvFinanzas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFinanzas.Size = new Size(380, 380);
            dgvFinanzas.TabIndex = 8;
            // 
            // pnlCabecera
            // 
            pnlCabecera.BorderStyle = BorderStyle.FixedSingle;
            pnlCabecera.Controls.Add(cboFiltro);
            pnlCabecera.Controls.Add(lblTituloFinanzas);
            pnlCabecera.Location = new Point(20, 20);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(380, 34);
            pnlCabecera.TabIndex = 9;
            // 
            // cboFiltro
            // 
            cboFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFiltro.FlatStyle = FlatStyle.Flat;
            cboFiltro.FormattingEnabled = true;
            cboFiltro.Items.AddRange(new object[] { "Ver todo" });
            cboFiltro.Location = new Point(220, 4);
            cboFiltro.Name = "cboFiltro";
            cboFiltro.Size = new Size(150, 28);
            cboFiltro.TabIndex = 1;
            // 
            // lblTituloFinanzas
            // 
            lblTituloFinanzas.AutoSize = true;
            lblTituloFinanzas.Location = new Point(8, 5);
            lblTituloFinanzas.Name = "lblTituloFinanzas";
            lblTituloFinanzas.Size = new Size(65, 20);
            lblTituloFinanzas.TabIndex = 0;
            lblTituloFinanzas.Text = "Finanzas";
            // 
            // Finanzasadmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(662, 493);
            Controls.Add(pnlCabecera);
            Controls.Add(dgvFinanzas);
            Controls.Add(lblEditar);
            Controls.Add(lblEliminar);
            Controls.Add(lblAgregarSalida);
            Controls.Add(lblAgregarEntrada);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregarSalida);
            Controls.Add(btnAgregarEntrada);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Finanzasadmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Finanzas";
            ((System.ComponentModel.ISupportInitialize)dgvFinanzas).EndInit();
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarEntrada;
        private Button btnAgregarSalida;
        private Button btnEditar;
        private Button btnEliminar;
        private Label lblAgregarEntrada;
        private Label lblAgregarSalida;
        private Label lblEliminar;
        private Label lblEditar;
        private DataGridView dgvFinanzas;
        private Panel pnlCabecera;
        private ComboBox cboFiltro;
        private Label lblTituloFinanzas;
    }
}