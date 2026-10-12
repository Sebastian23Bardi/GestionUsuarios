using System;
using System.Data;
using System.Windows.Forms;
using Logica;

namespace Vista
{
    public partial class Proveedores : Form
    {
        private ProveedoresLogica logica = new ProveedoresLogica();

        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            CargarGrillaProveedores();
        }

        public void CargarGrillaProveedores()
        {
            try
            {
                // Esta propiedad solo se puede setear por código
                dgvProveedores.AutoGenerateColumns = false;

                dgvProveedores.DataSource = logica.ObtenerProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Al hacer clic en cualquier celda que no sea el checkbox, muestra la ficha del proveedor
        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Si hizo clic en la columna del CheckBox, no abrimos el detalle
            if (dgvProveedores.Columns[e.ColumnIndex].Name == "Seleccionar") return;

            // Se extrae la fila original enlazada desde SQL (DataTable)
            DataRowView filaOrigen = dgvProveedores.Rows[e.RowIndex].DataBoundItem as DataRowView;

            if (filaOrigen != null)
            {
                string nombre = filaOrigen["Nombre"]?.ToString();
                string tel = filaOrigen["Teléfono"]?.ToString();
                string correo = filaOrigen["Correo"]?.ToString();
                string alias = filaOrigen["Alias_Bancario"]?.ToString();
                string fecha = filaOrigen["Fe_Alta"] != DBNull.Value
                    ? Convert.ToDateTime(filaOrigen["Fe_Alta"]).ToString("dd/MM/yyyy")
                    : "";

                string detalle = $"Detalle del Proveedor:\n\n" +
                                 $"• Nombre: {nombre}\n" +
                                 $"• Teléfono: {tel}\n" +
                                 $"• Correo: {correo}\n" +
                                 $"• Alias Bancario: {alias}\n" +
                                 $"• Fecha de Alta: {fecha}";

                MessageBox.Show(detalle, $"Ficha: {nombre}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            // Abre la ventana de historial
            FrmHistorialProveedores frm = new FrmHistorialProveedores();
            frm.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Forzar la confirmación del valor del checkbox
            dgvProveedores.CommitEdit(DataGridViewDataErrorContexts.Commit);
            dgvProveedores.EndEdit();

            // 2. Verificar si hay al menos una fila con el checkbox marcado
            bool haySeleccionados = false;
            foreach (DataGridViewRow fila in dgvProveedores.Rows)
            {
                if (fila.Cells["Seleccionar"].Value != null &&
                    Convert.ToBoolean(fila.Cells["Seleccionar"].Value) == true)
                {
                    haySeleccionados = true;
                    break;
                }
            }

            if (!haySeleccionados)
            {
                MessageBox.Show("Por favor, selecciona al menos un proveedor para eliminar.",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 3. Confirmación
            DialogResult confirm = MessageBox.Show("¿Seguro que querés eliminar los proveedores seleccionados?",
                                                   "Confirmar eliminación",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            int eliminados = 0;

            try
            {
                foreach (DataGridViewRow fila in dgvProveedores.Rows)
                {
                    // Verificamos de forma segura el valor booleano
                    bool seleccionado = fila.Cells["Seleccionar"].Value != null &&
                                        Convert.ToBoolean(fila.Cells["Seleccionar"].Value);

                    if (seleccionado)
                    {
                        DataRowView filaOrigen = fila.DataBoundItem as DataRowView;

                        if (filaOrigen != null)
                        {
                            int id = Convert.ToInt32(filaOrigen["id_Proveedores"]);

                            if (logica.BorrarProveedor(id))
                            {
                                eliminados++;
                            }
                        }
                    }
                }

                if (eliminados > 0)
                {
                    MessageBox.Show($"Se eliminaron {eliminados} proveedor(es) correctamente.",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    CargarGrillaProveedores();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el proveedor seleccionado.",
                                    "Aviso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarProveedor frm = new FrmAgregarProveedor();

            // Si el usuario guardó correctamente, recargamos la grilla
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarGrillaProveedores();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}