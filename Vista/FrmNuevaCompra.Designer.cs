namespace Vista
{
    partial class FrmNuevaCompra
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
            dtpFecha = new DateTimePicker();
            cmbProveedor = new ComboBox();
            cmbProducto = new ComboBox();
            txtUnidades = new TextBox();
            txtPrecioTotal = new TextBox();
            btnGuardar = new Button();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            datetimepickervencimiento = new DateTimePicker();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(157, 34);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(118, 27);
            dtpFecha.TabIndex = 0;
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(157, 78);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(169, 28);
            cmbProveedor.TabIndex = 1;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(157, 119);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(169, 28);
            cmbProducto.TabIndex = 2;
            // 
            // txtUnidades
            // 
            txtUnidades.Location = new Point(157, 161);
            txtUnidades.Name = "txtUnidades";
            txtUnidades.Size = new Size(169, 27);
            txtUnidades.TabIndex = 4;
            txtUnidades.KeyPress += txtUnidades_KeyPress;
            // 
            // txtPrecioTotal
            // 
            txtPrecioTotal.Location = new Point(157, 204);
            txtPrecioTotal.Name = "txtPrecioTotal";
            txtPrecioTotal.Size = new Size(169, 27);
            txtPrecioTotal.TabIndex = 5;
            txtPrecioTotal.KeyPress += txtDecimales_KeyPress;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(315, 388);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 33);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(104, 24, 30);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 50);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(314, 28);
            label1.TabIndex = 0;
            label1.Text = "NUEVA COMPRA A PROVEEDOR";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(datetimepickervencimiento);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbProveedor);
            groupBox1.Controls.Add(cmbProducto);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(txtPrecioTotal);
            groupBox1.Controls.Add(txtUnidades);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(104, 24, 30);
            groupBox1.Location = new Point(20, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 317);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Operación";
            // 
            // datetimepickervencimiento
            // 
            datetimepickervencimiento.Format = DateTimePickerFormat.Short;
            datetimepickervencimiento.Location = new Point(158, 249);
            datetimepickervencimiento.Name = "datetimepickervencimiento";
            datetimepickervencimiento.ShowCheckBox = true;
            datetimepickervencimiento.Size = new Size(117, 27);
            datetimepickervencimiento.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(-3, 252);
            label5.Name = "label5";
            label5.Size = new Size(156, 20);
            label5.TabIndex = 15;
            label5.Text = "Fecha de vencimiento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.5F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(20, 206);
            label7.Name = "label7";
            label7.Size = new Size(133, 21);
            label7.TabIndex = 13;
            label7.Text = "Precio unitario($):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.5F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(76, 167);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 12;
            label6.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.5F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(75, 121);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 10;
            label4.Text = "Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.5F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(66, 80);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 9;
            label3.Text = "Proveedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(98, 40);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 8;
            label2.Text = "Fecha:";
            // 
            // FrmNuevaCompra
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 228, 242);
            ClientSize = new Size(451, 433);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(btnGuardar);
            Font = new Font("Segoe UI", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNuevaCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmNuevaCompra";
            Load += FrmNuevaCompra_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpFecha;
        private ComboBox cmbProveedor;
        private ComboBox cmbProducto;
        private TextBox txtUnidades;
        private TextBox txtPrecioTotal;
        private Button btnGuardar;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private DateTimePicker datetimepickervencimiento;
    }
}