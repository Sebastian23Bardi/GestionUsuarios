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
    public partial class FrmStock : Form
    {
        private DataTable tablaProductos;
        public FrmStock()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearCatalogo catalogo = new CrearCatalogo();
            catalogo.ShowDialog();
            this.Close();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
