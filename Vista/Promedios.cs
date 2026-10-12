using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class Promedios : Form
    {
        public Promedios()
        {
            InitializeComponent();

            ConfigurarTablaPrincipal();
            ConfigurarTablasInferiores();
            CargarDatosBoceto();

            dgvPromedios.Paint += dgvPromedios_Paint;
            dgvResumenFinanzas.Paint += dgvResumenFinanzas_Paint;
            dgvParametros.Paint += dgvParametros_Paint;

            if (cboTipoPromedio.Items.Count > 0) cboTipoPromedio.SelectedIndex = 0;
            if (cboNuevoPromedio.Items.Count > 0) cboNuevoPromedio.SelectedIndex = 0;
        }

        private void ConfigurarTablaPrincipal()
        {
            dgvPromedios.EnableHeadersVisualStyles = false;
            dgvPromedios.ColumnHeadersVisible = true;
            dgvPromedios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPromedios.ColumnHeadersHeight = 30;
            dgvPromedios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgvPromedios.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvPromedios.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvPromedios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);

            dgvPromedios.Columns.Add("Corte", "Corte");
            dgvPromedios.Columns.Add("Kilaje", "Kilaje");
            dgvPromedios.Columns.Add("Precio", "Precio");
            dgvPromedios.Columns.Add("Importe", "Importe");

            dgvPromedios.Columns["Corte"].Width = 140;
            dgvPromedios.Columns["Kilaje"].Width = 90;
            dgvPromedios.Columns["Precio"].Width = 100;
            dgvPromedios.Columns["Importe"].Width = 120;

            dgvPromedios.Columns["Corte"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPromedios.Columns["Kilaje"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPromedios.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPromedios.Columns["Importe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvPromedios.RowTemplate.Height = 28;
            dgvPromedios.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvPromedios.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void ConfigurarTablasInferiores()
        {
            // 1. Resumen Finanzas (Recaudación, Costo, Ganancia)
            dgvResumenFinanzas.EnableHeadersVisualStyles = false;
            dgvResumenFinanzas.ColumnHeadersVisible = true;
            dgvResumenFinanzas.ColumnHeadersHeight = 28;
            dgvResumenFinanzas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvResumenFinanzas.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvResumenFinanzas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);

            dgvResumenFinanzas.Columns.Add("Categoria", "Categoria");
            dgvResumenFinanzas.Columns.Add("Importe", "Importe");
            dgvResumenFinanzas.Columns["Categoria"].Width = 140;
            dgvResumenFinanzas.Columns["Importe"].Width = 130;
            dgvResumenFinanzas.Columns["Importe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvResumenFinanzas.RowTemplate.Height = 28;
            dgvResumenFinanzas.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvResumenFinanzas.DefaultCellStyle.SelectionForeColor = Color.Black;

            // 2. Parámetros (Precio, Kilaje, Merma)
            dgvParametros.EnableHeadersVisualStyles = false;
            dgvParametros.ColumnHeadersVisible = false; // Sin encabezados, son pares clave-valor
            dgvParametros.Columns.Add("Parametro", "Parametro");
            dgvParametros.Columns.Add("Valor", "Valor");
            dgvParametros.Columns["Parametro"].Width = 85;
            dgvParametros.Columns["Valor"].Width = 80;
            dgvParametros.Columns["Parametro"].DefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            dgvParametros.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvParametros.RowTemplate.Height = 28;
            dgvParametros.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvParametros.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void CargarDatosBoceto()
        {
            // Datos tabla de cortes
            dgvPromedios.Rows.Add("Matambre", "1,580", "11000", "17380");
            dgvPromedios.Rows.Add("Vacio", "4,700", "14000", "65800");
            dgvPromedios.Rows.Add("Asado", "8,500", "11000", "93500");
            dgvPromedios.Rows.Add("Nalga", "4,350", "14000", "60900");

            // Datos finanzas
            dgvResumenFinanzas.Rows.Add("Recaudación", "816383,5");
            dgvResumenFinanzas.Rows.Add("Costo", "637000");
            dgvResumenFinanzas.Rows.Add("Ganancia bruta", "179383,5");

            // Datos parámetros
            dgvParametros.Rows.Add("Precio", "7000");
            dgvParametros.Rows.Add("Kilaje", "91");
            dgvParametros.Rows.Add("Merma", "18");
        }

        private void dgvPromedios_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 1.2f))
            {
                int xAcum = 0;
                for (int i = 0; i < dgvPromedios.Columns.Count - 1; i++)
                {
                    xAcum += dgvPromedios.Columns[i].Width;
                    e.Graphics.DrawLine(pen, xAcum - 1, 0, xAcum - 1, dgvPromedios.Height);
                }

                int yAcum = dgvPromedios.ColumnHeadersHeight;
                for (int i = 0; i < dgvPromedios.Rows.Count; i++)
                {
                    yAcum += dgvPromedios.Rows[i].Height;
                    e.Graphics.DrawLine(pen, 0, yAcum, dgvPromedios.Width, yAcum);
                }
            }
        }

        private void dgvResumenFinanzas_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 1.2f))
            {
                int x = dgvResumenFinanzas.Columns[0].Width - 1;
                e.Graphics.DrawLine(pen, x, 0, x, dgvResumenFinanzas.Height);

                int yAcum = dgvResumenFinanzas.ColumnHeadersHeight;
                for (int i = 0; i < dgvResumenFinanzas.Rows.Count; i++)
                {
                    yAcum += dgvResumenFinanzas.Rows[i].Height;
                    e.Graphics.DrawLine(pen, 0, yAcum, dgvResumenFinanzas.Width, yAcum);
                }
            }
        }

        private void dgvParametros_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 1.2f))
            {
                int x = dgvParametros.Columns[0].Width - 1;
                e.Graphics.DrawLine(pen, x, 0, x, dgvParametros.Height);

                int yAcum = 0;
                for (int i = 0; i < dgvParametros.Rows.Count; i++)
                {
                    yAcum += dgvParametros.Rows[i].Height;
                    e.Graphics.DrawLine(pen, 0, yAcum, dgvParametros.Width, yAcum);
                }
            }
        }
    }
}
