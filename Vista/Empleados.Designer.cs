namespace Vista
{
    partial class Empleados
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
            dgvEmpleados = new DataGridView();
            btnCrearusuario = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToResizeColumns = false;
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(20, 20);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersVisible = false;
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.ScrollBars = ScrollBars.None;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(590, 330);
            dgvEmpleados.TabIndex = 0;
            // 
            // btnCrearusuario
            // 
            btnCrearusuario.BackColor = Color.AliceBlue;
            btnCrearusuario.FlatStyle = FlatStyle.Flat;
            btnCrearusuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearusuario.Location = new Point(360, 383);
            btnCrearusuario.Name = "btnCrearusuario";
            btnCrearusuario.Size = new Size(139, 38);
            btnCrearusuario.TabIndex = 1;
            btnCrearusuario.Text = "Crear Usuario";
            btnCrearusuario.UseVisualStyleBackColor = false;
            btnCrearusuario.Click += btnCrearusuario_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.AliceBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(514, 383);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 38);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(648, 433);
            Controls.Add(btnGuardar);
            Controls.Add(btnCrearusuario);
            Controls.Add(dgvEmpleados);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Empleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Empleados y Permisos";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmpleados;
        private Button btnCrearusuario;
        private Button btnGuardar;
    }
}