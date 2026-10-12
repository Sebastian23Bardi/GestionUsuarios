namespace Vista
{
    partial class FrmHistorialProveedores
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorialProveedores));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvHistorial = new DataGridView();
            lblBuscar = new Label();
            lblDesde = new Label();
            lblHasta = new Label();
            txtBuscar = new TextBox();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            btnFiltrar = new Button();
            btnLimpiar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            btnNuevaCompra = new Button();
            colFecha = new DataGridViewTextBoxColumn();
            colProveedor = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colKilos = new DataGridViewTextBoxColumn();
            colUnidades = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToResizeColumns = false;
            dgvHistorial.AllowUserToResizeRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Columns.AddRange(new DataGridViewColumn[] { colFecha, colProveedor, colProducto, colKilos, colUnidades, colTotal });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvHistorial.DefaultCellStyle = dataGridViewCellStyle7;
            dgvHistorial.Location = new Point(58, 165);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.ScrollBars = ScrollBars.Vertical;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.Size = new Size(776, 325);
            dgvHistorial.TabIndex = 0;
            dgvHistorial.CellContentClick += dgvHistorial_CellContentClick;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(102, 73);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(55, 20);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar:";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(413, 73);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(54, 20);
            lblDesde.TabIndex = 2;
            lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(621, 73);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(50, 20);
            lblHasta.TabIndex = 3;
            lblHasta.Text = "Hasta:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(163, 70);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(193, 27);
            txtBuscar.TabIndex = 4;
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(473, 68);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(124, 27);
            dtpDesde.TabIndex = 5;
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(677, 70);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(128, 27);
            dtpHasta.TabIndex = 6;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(101, 122);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 29);
            btnFiltrar.TabIndex = 7;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(243, 122);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar Filtros";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(92, 29, 36);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(931, 56);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(916, 55);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnNuevaCompra
            // 
            btnNuevaCompra.Location = new Point(384, 122);
            btnNuevaCompra.Name = "btnNuevaCompra";
            btnNuevaCompra.Size = new Size(138, 29);
            btnNuevaCompra.TabIndex = 10;
            btnNuevaCompra.Text = "Nueva Compra";
            btnNuevaCompra.UseVisualStyleBackColor = true;
            btnNuevaCompra.Click += btnNuevaCompra_Click;
            // 
            // colFecha
            // 
            colFecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            colFecha.DefaultCellStyle = dataGridViewCellStyle1;
            colFecha.FillWeight = 75F;
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colProveedor
            // 
            colProveedor.DataPropertyName = "Proveedor";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colProveedor.DefaultCellStyle = dataGridViewCellStyle2;
            colProveedor.FillWeight = 110F;
            colProveedor.HeaderText = "Proveedor";
            colProveedor.MinimumWidth = 6;
            colProveedor.Name = "colProveedor";
            colProveedor.ReadOnly = true;
            // 
            // colProducto
            // 
            colProducto.DataPropertyName = "Producto";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colProducto.DefaultCellStyle = dataGridViewCellStyle3;
            colProducto.FillWeight = 110F;
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 6;
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            // 
            // colKilos
            // 
            colKilos.DataPropertyName = "Kilos";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            colKilos.DefaultCellStyle = dataGridViewCellStyle4;
            colKilos.FillWeight = 60F;
            colKilos.HeaderText = "Kilos";
            colKilos.MinimumWidth = 6;
            colKilos.Name = "colKilos";
            colKilos.ReadOnly = true;
            // 
            // colUnidades
            // 
            colUnidades.DataPropertyName = "Unidades";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colUnidades.DefaultCellStyle = dataGridViewCellStyle5;
            colUnidades.FillWeight = 60F;
            colUnidades.HeaderText = "Unidades";
            colUnidades.MinimumWidth = 6;
            colUnidades.Name = "colUnidades";
            colUnidades.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.DataPropertyName = "Total";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            colTotal.DefaultCellStyle = dataGridViewCellStyle6;
            colTotal.FillWeight = 75F;
            colTotal.HeaderText = "Total ($)";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // FrmHistorialProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(931, 545);
            Controls.Add(btnNuevaCompra);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnFiltrar);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(txtBuscar);
            Controls.Add(lblHasta);
            Controls.Add(lblDesde);
            Controls.Add(lblBuscar);
            Controls.Add(dgvHistorial);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "FrmHistorialProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historial de Proveedores";
            Load += FrmHistorialProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistorial;
        private Label lblBuscar;
        private Label lblDesde;
        private Label lblHasta;
        private TextBox txtBuscar;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Button btnFiltrar;
        private Button btnLimpiar;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Button btnNuevaCompra;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colProveedor;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colKilos;
        private DataGridViewTextBoxColumn colUnidades;
        private DataGridViewTextBoxColumn colTotal;
    }
}