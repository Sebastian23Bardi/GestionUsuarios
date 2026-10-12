namespace Vista
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            dgvProveedores = new DataGridView();
            Seleccionar = new DataGridViewCheckBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            btnVerHistorial = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.AllowUserToResizeColumns = false;
            dgvProveedores.AllowUserToResizeRows = false;
            dgvProveedores.BackgroundColor = Color.White;
            dgvProveedores.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.ColumnHeadersVisible = false;
            dgvProveedores.Columns.AddRange(new DataGridViewColumn[] { Seleccionar, Nombre });
            dgvProveedores.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvProveedores.GridColor = SystemColors.ScrollBar;
            dgvProveedores.Location = new Point(42, 58);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersVisible = false;
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.ScrollBars = ScrollBars.None;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(324, 323);
            dgvProveedores.TabIndex = 1;
            dgvProveedores.CellClick += dgvProveedores_CellClick;
            dgvProveedores.CellContentClick += dgvProveedores_CellContentClick;
            // 
            // Seleccionar
            // 
            Seleccionar.HeaderText = "Sel";
            Seleccionar.MinimumWidth = 6;
            Seleccionar.Name = "Seleccionar";
            Seleccionar.Width = 35;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Proveedor";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // btnVerHistorial
            // 
            btnVerHistorial.BackColor = Color.FromArgb(192, 0, 0);
            btnVerHistorial.FlatStyle = FlatStyle.Flat;
            btnVerHistorial.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerHistorial.ForeColor = SystemColors.ControlLightLight;
            btnVerHistorial.Location = new Point(283, 389);
            btnVerHistorial.Name = "btnVerHistorial";
            btnVerHistorial.Size = new Size(96, 35);
            btnVerHistorial.TabIndex = 2;
            btnVerHistorial.Text = "Historial";
            btnVerHistorial.UseVisualStyleBackColor = false;
            btnVerHistorial.Click += btnVerHistorial_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(92, 29, 36);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(26, 389);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(95, 35);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(158, 389);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(95, 35);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(92, 29, 36);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(409, 54);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(555, 49);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(409, 436);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnVerHistorial);
            Controls.Add(dgvProveedores);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Proveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proveedores";
            Load += Proveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvProveedores;
        private Button btnVerHistorial;
        private Button btnAgregar;
        private Button btnEliminar;
        private DataGridViewCheckBoxColumn Seleccionar;
        private DataGridViewTextBoxColumn Nombre;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
    }
}