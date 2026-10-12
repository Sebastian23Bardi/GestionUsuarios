using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Finanzasadmin : Form
    {
        public Finanzasadmin()
        {
            InitializeComponent();

            ConfigurarBotones();
            ConfigurarGrid();
            CargarDatosBoceto();

            dgvFinanzas.Paint += dgvFinanzas_Paint;
            dgvFinanzas.CellPainting += dgvFinanzas_CellPainting;

            if (cboFiltro.Items.Count > 0)
                cboFiltro.SelectedIndex = 0;
        }

        private void ConfigurarBotones()
        {
            // Entrada (+)
            btnAgregarEntrada.Font = new Font("Arial", 20, FontStyle.Bold);
            btnAgregarEntrada.TextAlign = ContentAlignment.MiddleCenter;
            btnAgregarEntrada.Padding = new Padding(0, 0, 0, 4);

            // Salida (-)
            btnAgregarSalida.Font = new Font("Arial", 20, FontStyle.Bold);
            btnAgregarSalida.TextAlign = ContentAlignment.MiddleCenter;
            btnAgregarSalida.Padding = new Padding(0, 0, 0, 6);

            // Editar (✎)
            btnEditar.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            btnEditar.TextAlign = ContentAlignment.MiddleCenter;

            // Eliminar (✕)
            btnEliminar.Font = new Font("Arial", 16, FontStyle.Bold);
            btnEliminar.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void ConfigurarGrid()
        {
            dgvFinanzas.EnableHeadersVisualStyles = false;
            dgvFinanzas.ColumnHeadersVisible = true;
            dgvFinanzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvFinanzas.ColumnHeadersHeight = 30;
            dgvFinanzas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgvFinanzas.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvFinanzas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvFinanzas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Columnas
            dgvFinanzas.Columns.Add("Nombre", "Nombre");
            dgvFinanzas.Columns.Add("Monto", "monto");
            dgvFinanzas.Columns.Add("Fecha", "Fecha");

            dgvFinanzas.Columns["Nombre"].Width = 140;
            dgvFinanzas.Columns["Monto"].Width = 110;
            dgvFinanzas.Columns["Fecha"].Width = 130;

            dgvFinanzas.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFinanzas.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvFinanzas.RowTemplate.Height = 32;
        }

        private void CargarDatosBoceto()
        {
            dgvFinanzas.Rows.Add("Pollo", "150000", "1-julio");
            dgvFinanzas.Rows.Add("Caja $23.564.320", "800000", "5-julio");
            dgvFinanzas.Rows.Add("Fiado Henán", "110000", "3-julio");
            dgvFinanzas.Rows.Add("Bolsas", "30000", "6-julio");
            dgvFinanzas.Rows.Add("Sueldo José", "80000", "7-julio");
            dgvFinanzas.Rows.Add("Cierre semanal", "660000", "7-julio");
            dgvFinanzas.Rows.Add("Balance semanal", "240000", "7-julio");
        }

        private void dgvFinanzas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 0 || e.ColumnIndex == 1))
            {
                e.Handled = true;
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);

                string concepto = dgvFinanzas.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
                Color colorTexto = Color.Black;

                // Salidas (Rojo)
                if (concepto.StartsWith("Pollo") || concepto.StartsWith("Bolsas") || concepto.StartsWith("Sueldo"))
                    colorTexto = Color.Crimson;
                // Entradas (Verde)
                else if (concepto.StartsWith("Caja") || concepto.StartsWith("Fiado"))
                    colorTexto = Color.ForestGreen;
                // Totales / Balances (Negro)
                else
                    colorTexto = Color.Black;

                Rectangle rect = new Rectangle(e.CellBounds.X + 3, e.CellBounds.Y + 3, e.CellBounds.Width - 6, e.CellBounds.Height - 6);
                using (GraphicsPath path = GetRoundedRectanglePath(rect, 6))
                using (Pen pen = new Pen(Color.Black, 1.2f))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);

                    string texto = e.Value?.ToString() ?? "";
                    TextFormatFlags flags = TextFormatFlags.VerticalCenter;
                    flags |= (e.ColumnIndex == 0) ? TextFormatFlags.Left : TextFormatFlags.HorizontalCenter;

                    Rectangle textRect = new Rectangle(rect.X + 6, rect.Y, rect.Width - 12, rect.Height);
                    TextRenderer.DrawText(e.Graphics, texto, new Font("Segoe UI", 9f, FontStyle.Regular), textRect, colorTexto, flags);
                }
            }
        }

        private void dgvFinanzas_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 1.5f))
            {
                int x1 = dgvFinanzas.Columns[0].Width - 1;
                int x2 = x1 + dgvFinanzas.Columns[1].Width;

                e.Graphics.DrawLine(pen, x1, 0, x1, dgvFinanzas.Height);
                e.Graphics.DrawLine(pen, x2, 0, x2, dgvFinanzas.Height);
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            Rectangle arc = new Rectangle(rect.Location, new Size(diameter, diameter));

            path.AddArc(arc, 180, 90);
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
