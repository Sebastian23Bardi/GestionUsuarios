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
    public partial class Cuentas : Form
    {
        public Cuentas()
        {
            InitializeComponent();

            ConfigurarGrid();
            CargarDatosBoceto();

            dgvCuentas.Paint += dgvCuentas_Paint;
            dgvCuentas.CellPainting += dgvCuentas_CellPainting;

            if (cboFiltro.Items.Count > 0)
                cboFiltro.SelectedIndex = 0;
        }

        private void ConfigurarGrid()
        {
            dgvCuentas.EnableHeadersVisualStyles = false;
            dgvCuentas.ColumnHeadersVisible = true;
            dgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCuentas.ColumnHeadersHeight = 30;
            dgvCuentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgvCuentas.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvCuentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvCuentas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvCuentas.Columns.Add("Nombre", "Nombre");
            dgvCuentas.Columns.Add("Monto", "monto");
            dgvCuentas.Columns.Add("Fecha", "Fecha");

            dgvCuentas.Columns["Nombre"].Width = 140;
            dgvCuentas.Columns["Monto"].Width = 110;
            dgvCuentas.Columns["Fecha"].Width = 130;

            dgvCuentas.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCuentas.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvCuentas.RowTemplate.Height = 32;
        }

        private void CargarDatosBoceto()
        {
            dgvCuentas.Rows.Add("Pollo", "150000", "1-julio");
            dgvCuentas.Rows.Add("Caja", "800000", "3-julio");
            dgvCuentas.Rows.Add("Fiado Henán", "110000", "5-julio");
            dgvCuentas.Rows.Add("Bolsas", "30000", "6-julio");
            dgvCuentas.Rows.Add("Balance semanal", "240000", "7-julio");
        }

        private void dgvCuentas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 0 || e.ColumnIndex == 1))
            {
                e.Handled = true;
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);

                string concepto = dgvCuentas.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
                Color colorTexto = Color.Black;

                // Colores según el tipo de movimiento del boceto
                if (concepto == "Pollo" || concepto == "Bolsas")
                    colorTexto = Color.Crimson;
                else if (concepto == "Caja" || concepto == "Fiado Henán")
                    colorTexto = Color.ForestGreen;
                else
                    colorTexto = Color.Black;

                // Dibujar celda redondeada tipo botón
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
                    TextRenderer.DrawText(e.Graphics, texto, new Font("Segoe UI", 9.5f, FontStyle.Regular), textRect, colorTexto, flags);
                }
            }
        }

        private void dgvCuentas_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 1.5f))
            {
                int x1 = dgvCuentas.Columns[0].Width - 1;
                int x2 = x1 + dgvCuentas.Columns[1].Width;

                // Líneas divisorias verticales continuas
                e.Graphics.DrawLine(pen, x1, 0, x1, dgvCuentas.Height);
                e.Graphics.DrawLine(pen, x2, 0, x2, dgvCuentas.Height);
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
