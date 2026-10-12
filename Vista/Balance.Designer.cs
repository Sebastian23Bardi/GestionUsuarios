namespace Vista
{
    partial class FrmStock
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
            dgvProductos = new DataGridView();
            lbl_balances = new Label();
            dtpFechaBalance = new DateTimePicker();
            btnEliminar = new Button();
            btnEditar = new Button();
            lblEtiquetaTotal = new Label();
            lblTotal = new Label();
            panel1 = new Panel();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.BackgroundColor = SystemColors.Window;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.GridColor = SystemColors.ControlDark;
            dgvProductos.Location = new Point(11, 24);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(411, 400);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // lbl_balances
            // 
            lbl_balances.AutoSize = true;
            lbl_balances.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_balances.Location = new Point(515, 29);
            lbl_balances.Name = "lbl_balances";
            lbl_balances.Size = new Size(98, 20);
            lbl_balances.TabIndex = 1;
            lbl_balances.Text = "Tus Balances";
            // 
            // dtpFechaBalance
            // 
            dtpFechaBalance.CustomFormat = "dd/MM/yyyy";
            dtpFechaBalance.Format = DateTimePickerFormat.Custom;
            dtpFechaBalance.Location = new Point(467, 52);
            dtpFechaBalance.Name = "dtpFechaBalance";
            dtpFechaBalance.Size = new Size(194, 27);
            dtpFechaBalance.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(499, 216);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 81);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar producto";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(499, 329);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 81);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar producto";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // lblEtiquetaTotal
            // 
            lblEtiquetaTotal.AutoSize = true;
            lblEtiquetaTotal.Location = new Point(3, 11);
            lblEtiquetaTotal.Name = "lblEtiquetaTotal";
            lblEtiquetaTotal.Size = new Size(96, 20);
            lblEtiquetaTotal.TabIndex = 6;
            lblEtiquetaTotal.Text = "Balance total";
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(320, 4);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(90, 25);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblEtiquetaTotal);
            panel1.Controls.Add(lblTotal);
            panel1.Location = new Point(11, 392);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 31);
            panel1.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(499, 103);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(130, 81);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Catalogo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 439);
            Controls.Add(panel1);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dtpFechaBalance);
            Controls.Add(lbl_balances);
            Controls.Add(dgvProductos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Label lbl_balances;
        private DateTimePicker dtpFechaBalance;
        private Button btnEliminar;
        private Button btnEditar;
        private Label lblEtiquetaTotal;
        private Label lblTotal;
        private Panel panel1;
        private Button btnAgregar;
    }
}