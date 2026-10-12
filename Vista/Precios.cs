using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Precios : Form
    {
        private DataTable tablaPrecios;

        public Precios()
        {
            InitializeComponent();

            ConfigurarEstructura();
            CargarCategorias();

            dgvListaPrecios.Paint += dgvListaPrecios_Paint;
            pnlTituloTabla.Paint += pnlTituloTabla_Paint;

            // Disparar la carga inicial de productos
            CargarProductosPorCategoria("Embutidos");
        }

        private void ConfigurarEstructura()
        {
            tablaPrecios = new DataTable();
            tablaPrecios.Columns.Add("Producto", typeof(string));
            tablaPrecios.Columns.Add("Precio", typeof(decimal));

            dgvListaPrecios.DataSource = tablaPrecios;
            dgvListaPrecios.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Configuración estricta del encabezado
            dgvListaPrecios.EnableHeadersVisualStyles = false;
            dgvListaPrecios.ColumnHeadersVisible = true;
            dgvListaPrecios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListaPrecios.ColumnHeadersHeight = 28;

            dgvListaPrecios.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvListaPrecios.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvListaPrecios.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvListaPrecios.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            dgvListaPrecios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Anchos y textos de columnas
            dgvListaPrecios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvListaPrecios.Columns["Producto"].HeaderText = "Producto";
            dgvListaPrecios.Columns["Producto"].Width = 260;
            dgvListaPrecios.Columns["Producto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvListaPrecios.ColumnHeadersVisible = false;

            dgvListaPrecios.Columns["Precio"].HeaderText = "Precio";
            dgvListaPrecios.Columns["Precio"].Width = 110;
            dgvListaPrecios.Columns["Precio"].DefaultCellStyle.Format = "N2";
            dgvListaPrecios.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListaPrecios.Columns["Precio"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void CargarCategorias()
        {
            cboCategorias.Items.Clear();
            cboCategorias.Items.AddRange(new string[] {
                "Media res",
                "Pollo",
                "Cerdo",
                "Cordero",
                "Embutidos",
                "Varios"
            });

            if (cboCategorias.Items.Count > 0)
                cboCategorias.SelectedIndex = 4; // Embutidos
        }

        private void cboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategorias.SelectedItem == null) return;

            string categoriaSeleccionada = cboCategorias.SelectedItem.ToString();
            lblCategoriaTitulo.Text = categoriaSeleccionada;
            CargarProductosPorCategoria(categoriaSeleccionada);
        }

        private void CargarProductosPorCategoria(string categoria)
        {
            tablaPrecios.Rows.Clear();

            if (categoria == "Embutidos")
            {
                tablaPrecios.Rows.Add("Chorizo", 9000m);
                tablaPrecios.Rows.Add("Morcilla", 6500m);
            }
            else if (categoria == "Pollo")
            {
                tablaPrecios.Rows.Add("Pechuga", 7500m);
                tablaPrecios.Rows.Add("Pata y Muslo", 4200m);
            }
        }

        private void pnlTituloTabla_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(dgvListaPrecios.GridColor, 1))
            {
                // 1. Línea horizontal entre "Embutidos" y "Producto / Precio"
                e.Graphics.DrawLine(pen, 0, 30, pnlTituloTabla.Width, 30);

                // 2. Línea vertical exacta según el ancho de la primera columna
                if (dgvListaPrecios.Columns.Count > 0)
                {
                    int x = dgvListaPrecios.Columns[0].Width - 2;
                    e.Graphics.DrawLine(pen, x, 30, x, pnlTituloTabla.Height);
                }
            }
        }

        private void dgvListaPrecios_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(dgvListaPrecios.GridColor, 1))
            {
                int xAcumulada = 0;
                for (int i = 0; i < dgvListaPrecios.Columns.Count; i++)
                {
                    if (dgvListaPrecios.Columns[i].Visible)
                    {
                        xAcumulada += dgvListaPrecios.Columns[i].Width;
                        // Dibuja una única línea vertical continua
                        e.Graphics.DrawLine(pen, xAcumulada - 1, 0, xAcumulada - 1, dgvListaPrecios.Height);
                    }
                }
            }
        }

        private void cboCategorias_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (cboCategorias.SelectedItem == null) return;

            string categoriaSeleccionada = cboCategorias.SelectedItem.ToString();
            lblCategoriaTitulo.Text = categoriaSeleccionada;
            CargarProductosPorCategoria(categoriaSeleccionada);
        }
    }
}