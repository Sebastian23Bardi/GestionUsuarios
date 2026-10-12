using login_promires;
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
    public partial class MenuEmpresa : Form
    {
        public MenuEmpresa()
        {
            InitializeComponent();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores prov = new Proveedores();
            prov.ShowDialog();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            FrmStock bal = new FrmStock();
            bal.ShowDialog();
        }

        private void btnFinanzas_Click_1(object sender, EventArgs e)
        {
            Finanzasadmin FinAd = new Finanzasadmin();
            FinAd.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleados emp = new Empleados();
            emp.ShowDialog();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            Promedios prom = new Promedios();
            prom.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Opcional: confirmar si realmente desea salir
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea cerrar sesión?",
                                                     "Cerrar Sesión",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.None);

            if (respuesta == DialogResult.Yes)
            {
                // Abrir el formulario de Login
                FrmLogin login = new FrmLogin();
                login.Show();

                // Cerrar el formulario actual
                this.Dispose(); // o this.Close();
            }
        }
    }
}
