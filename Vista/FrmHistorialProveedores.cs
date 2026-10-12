using System;
using System.Data;
using System.Windows.Forms;
using Logica;

namespace Vista
{
    public partial class FrmHistorialProveedores : Form
    {
        private ProveedoresLogica logica = new ProveedoresLogica();

        public FrmHistorialProveedores()
        {
            InitializeComponent();
        }

        private void FrmHistorialProveedores_Load(object sender, EventArgs e)
        {
            
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            dtpHasta.Value = DateTime.Today;
            dgvHistorial.AutoGenerateColumns = false;
            
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                string filtro = txtBuscar.Text.Trim();
                DateTime desde = dtpDesde.Value.Date;
            
                DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);

                dgvHistorial.DataSource = logica.ConsultarHistorial(filtro, desde, hasta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            dtpHasta.Value = DateTime.Today;
            CargarGrilla();
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            using (FrmNuevaCompra modal = new FrmNuevaCompra())
            {
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    CargarGrilla();
                }
            }
        }

        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}