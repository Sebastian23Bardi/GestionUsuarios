namespace Vista
{
    partial class CrearCatalogo
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
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            medida = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textboxnombreproducto = new TextBox();
            btnagregareditar = new Button();
            btneliminarlimpiar = new Button();
            label4 = new Label();
            label5 = new Label();
            comboboxmedida = new ComboBox();
            comboboxcategoria = new ComboBox();
            label6 = new Label();
            comboboxtipoproducto = new ComboBox();
            btnguardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, categoria, medida, tipo });
            dataGridView1.Location = new Point(15, 213);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1009, 375);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre de producto";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // categoria
            // 
            categoria.HeaderText = "Categoría";
            categoria.MinimumWidth = 6;
            categoria.Name = "categoria";
            categoria.Width = 125;
            // 
            // medida
            // 
            medida.HeaderText = "Medida";
            medida.MinimumWidth = 6;
            medida.Name = "medida";
            medida.Width = 125;
            // 
            // tipo
            // 
            tipo.HeaderText = "Tipo de pruducto";
            tipo.MinimumWidth = 6;
            tipo.Name = "tipo";
            tipo.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 124);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(25, 175);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 2;
            label2.Text = "Categoría:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(357, 128);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 3;
            label3.Text = "Medida:";
            // 
            // textboxnombreproducto
            // 
            textboxnombreproducto.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textboxnombreproducto.Location = new Point(103, 125);
            textboxnombreproducto.Margin = new Padding(3, 4, 3, 4);
            textboxnombreproducto.Name = "textboxnombreproducto";
            textboxnombreproducto.Size = new Size(227, 31);
            textboxnombreproducto.TabIndex = 4;
            // 
            // btnagregareditar
            // 
            btnagregareditar.Location = new Point(938, 91);
            btnagregareditar.Margin = new Padding(3, 4, 3, 4);
            btnagregareditar.Name = "btnagregareditar";
            btnagregareditar.Size = new Size(86, 31);
            btnagregareditar.TabIndex = 7;
            btnagregareditar.Text = "Agregar";
            btnagregareditar.UseVisualStyleBackColor = true;
            btnagregareditar.Click += btnagregareditar_Click;
            // 
            // btneliminarlimpiar
            // 
            btneliminarlimpiar.Location = new Point(938, 128);
            btneliminarlimpiar.Margin = new Padding(3, 4, 3, 4);
            btneliminarlimpiar.Name = "btneliminarlimpiar";
            btneliminarlimpiar.Size = new Size(86, 31);
            btneliminarlimpiar.TabIndex = 8;
            btneliminarlimpiar.Text = "Eliminar";
            btneliminarlimpiar.UseVisualStyleBackColor = true;
            btneliminarlimpiar.Click += btneliminarlimpiar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(339, 41);
            label4.TabIndex = 9;
            label4.Text = "Catálogo de productos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 74);
            label5.Name = "label5";
            label5.Size = new Size(192, 31);
            label5.TabIndex = 10;
            label5.Text = "Datos de prducto";
            // 
            // comboboxmedida
            // 
            comboboxmedida.Font = new Font("Segoe UI", 10.8F);
            comboboxmedida.FormattingEnabled = true;
            comboboxmedida.Location = new Point(439, 125);
            comboboxmedida.Margin = new Padding(3, 4, 3, 4);
            comboboxmedida.Name = "comboboxmedida";
            comboboxmedida.Size = new Size(95, 33);
            comboboxmedida.TabIndex = 11;
            // 
            // comboboxcategoria
            // 
            comboboxcategoria.Font = new Font("Segoe UI", 10.8F);
            comboboxcategoria.FormattingEnabled = true;
            comboboxcategoria.Location = new Point(116, 172);
            comboboxcategoria.Margin = new Padding(3, 4, 3, 4);
            comboboxcategoria.Name = "comboboxcategoria";
            comboboxcategoria.Size = new Size(131, 33);
            comboboxcategoria.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(253, 175);
            label6.Name = "label6";
            label6.Size = new Size(155, 25);
            label6.TabIndex = 13;
            label6.Text = "Tipo de producto:";
            // 
            // comboboxtipoproducto
            // 
            comboboxtipoproducto.Font = new Font("Segoe UI", 10.8F);
            comboboxtipoproducto.FormattingEnabled = true;
            comboboxtipoproducto.Location = new Point(414, 172);
            comboboxtipoproducto.Margin = new Padding(3, 4, 3, 4);
            comboboxtipoproducto.Name = "comboboxtipoproducto";
            comboboxtipoproducto.Size = new Size(163, 33);
            comboboxtipoproducto.TabIndex = 14;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(938, 169);
            btnguardar.Margin = new Padding(3, 4, 3, 4);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(86, 31);
            btnguardar.TabIndex = 15;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            // 
            // CrearCatalogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 599);
            Controls.Add(btnguardar);
            Controls.Add(comboboxtipoproducto);
            Controls.Add(label6);
            Controls.Add(comboboxcategoria);
            Controls.Add(comboboxmedida);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btneliminarlimpiar);
            Controls.Add(btnagregareditar);
            Controls.Add(textboxnombreproducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CrearCatalogo";
            StartPosition = FormStartPosition.CenterScreen;
            Load += CrearCatalogo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textboxnombreproducto;
        private Button btnagregareditar;
        private Button btneliminarlimpiar;
        private Label label4;
        private Label label5;
        private ComboBox comboboxmedida;
        private ComboBox comboboxcategoria;
        private Label label6;
        private ComboBox comboboxtipoproducto;
        private Button btnguardar;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn medida;
        private DataGridViewTextBoxColumn tipo;
    }
}