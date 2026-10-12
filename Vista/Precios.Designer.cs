namespace Vista
{
    partial class Precios
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
            pnlTituloTabla = new Panel();
            lblColPrecio = new Label();
            lblColProducto = new Label();
            lblCategoriaTitulo = new Label();
            dgvListaPrecios = new DataGridView();
            lblNombreLista = new Label();
            cboCategorias = new ComboBox();
            pnlTituloTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaPrecios).BeginInit();
            SuspendLayout();
            // 
            // pnlTituloTabla
            // 
            pnlTituloTabla.BackColor = SystemColors.Window;
            pnlTituloTabla.BorderStyle = BorderStyle.FixedSingle;
            pnlTituloTabla.Controls.Add(lblColPrecio);
            pnlTituloTabla.Controls.Add(lblColProducto);
            pnlTituloTabla.Controls.Add(lblCategoriaTitulo);
            pnlTituloTabla.Location = new Point(20, 20);
            pnlTituloTabla.Name = "pnlTituloTabla";
            pnlTituloTabla.Size = new Size(370, 60);
            pnlTituloTabla.TabIndex = 0;
            // 
            // lblColPrecio
            // 
            lblColPrecio.BackColor = Color.White;
            lblColPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColPrecio.ImageAlign = ContentAlignment.MiddleRight;
            lblColPrecio.Location = new Point(261, 31);
            lblColPrecio.Name = "lblColPrecio";
            lblColPrecio.Size = new Size(105, 26);
            lblColPrecio.TabIndex = 2;
            lblColPrecio.Text = "Precio";
            // 
            // lblColProducto
            // 
            lblColProducto.BackColor = Color.White;
            lblColProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColProducto.Location = new Point(1, 31);
            lblColProducto.Name = "lblColProducto";
            lblColProducto.Size = new Size(256, 26);
            lblColProducto.TabIndex = 1;
            lblColProducto.Text = "Producto";
            lblColProducto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCategoriaTitulo
            // 
            lblCategoriaTitulo.BackColor = Color.White;
            lblCategoriaTitulo.Location = new Point(1, 1);
            lblCategoriaTitulo.Name = "lblCategoriaTitulo";
            lblCategoriaTitulo.Size = new Size(368, 28);
            lblCategoriaTitulo.TabIndex = 0;
            lblCategoriaTitulo.Text = "Embutidos";
            lblCategoriaTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvListaPrecios
            // 
            dgvListaPrecios.AllowUserToAddRows = false;
            dgvListaPrecios.AllowUserToResizeColumns = false;
            dgvListaPrecios.BackgroundColor = SystemColors.Window;
            dgvListaPrecios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaPrecios.GridColor = SystemColors.ActiveCaptionText;
            dgvListaPrecios.Location = new Point(20, 80);
            dgvListaPrecios.Name = "dgvListaPrecios";
            dgvListaPrecios.RowHeadersVisible = false;
            dgvListaPrecios.RowHeadersWidth = 51;
            dgvListaPrecios.ScrollBars = ScrollBars.Vertical;
            dgvListaPrecios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaPrecios.Size = new Size(370, 358);
            dgvListaPrecios.TabIndex = 1;
            // 
            // lblNombreLista
            // 
            lblNombreLista.AutoSize = true;
            lblNombreLista.Location = new Point(426, 32);
            lblNombreLista.Name = "lblNombreLista";
            lblNombreLista.Size = new Size(116, 20);
            lblNombreLista.TabIndex = 2;
            lblNombreLista.Text = "Nombre de lista";
            // 
            // cboCategorias
            // 
            cboCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategorias.FormattingEnabled = true;
            cboCategorias.Location = new Point(409, 55);
            cboCategorias.Name = "cboCategorias";
            cboCategorias.Size = new Size(151, 28);
            cboCategorias.TabIndex = 3;
            cboCategorias.SelectedIndexChanged += cboCategorias_SelectedIndexChanged;
            // 
            // Precios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 450);
            Controls.Add(pnlTituloTabla);
            Controls.Add(cboCategorias);
            Controls.Add(dgvListaPrecios);
            Controls.Add(lblNombreLista);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Precios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Precios";
            pnlTituloTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaPrecios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTituloTabla;
        private Label lblCategoriaTitulo;
        private DataGridView dgvListaPrecios;
        private Label lblNombreLista;
        private ComboBox cboCategorias;
        private Label lblColPrecio;
        private Label lblColProducto;
    }
}