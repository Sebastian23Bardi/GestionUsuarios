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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();

            dgvEmpleados.Paint += dgvEmpleados_Paint;
        }

        private void dgvEmpleados_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 1.2f))
            {
                int xAcumulada = 0;
                for (int i = 0; i < dgvEmpleados.Columns.Count - 1; i++)
                {
                    if (dgvEmpleados.Columns[i].Visible)
                    {
                        xAcumulada += dgvEmpleados.Columns[i].Width;
                        e.Graphics.DrawLine(pen, xAcumulada - 1, 0, xAcumulada - 1, dgvEmpleados.Height);
                    }
                }

                int yAcumulada = dgvEmpleados.ColumnHeadersHeight;
                for (int i = 0; i < dgvEmpleados.Rows.Count; i++)
                {
                    yAcumulada += dgvEmpleados.Rows[i].Height;
                    e.Graphics.DrawLine(pen, 0, yAcumulada, dgvEmpleados.Width, yAcumulada);
                }
            }
        }

        private void btnCrearusuario_Click(object sender, EventArgs e)
        {
            CrearUsuario Crear = new CrearUsuario();
            Crear.ShowDialog();
        }
    }
}
