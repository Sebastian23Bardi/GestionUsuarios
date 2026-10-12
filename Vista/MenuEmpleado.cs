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
    public partial class MenuEmpleado : Form
    {
        public MenuEmpleado()
        {
            InitializeComponent();
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
