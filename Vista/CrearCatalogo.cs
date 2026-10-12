using System;
using System.Windows.Forms;
using Logica;

namespace Vista
{
    public partial class CrearCatalogo : Form
    {
        private int filaSeleccionada = -1;

        private ProductosLogica productosLogica =
            new ProductosLogica();

        public CrearCatalogo()
        {
            InitializeComponent();

            btnagregareditar.Text = "Agregar";
            btneliminarlimpiar.Text = "Limpiar controles";
        }

        private void CrearCatalogo_Load(object sender, EventArgs e)
        {
            comboboxcategoria.Items.Add("Vacuno");
            comboboxcategoria.Items.Add("Pollo");
            comboboxcategoria.Items.Add("Achura");
            comboboxcategoria.Items.Add("Cerdo");
            comboboxcategoria.Items.Add("Otros");

            comboboxmedida.Items.Add("Kilos");
            comboboxmedida.Items.Add("Litros");
            comboboxmedida.Items.Add("Unidades");

            comboboxtipoproducto.Items.Add("Revendible");
            comboboxtipoproducto.Items.Add("Elaborable");
            comboboxtipoproducto.Items.Add("Derivado");

            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns[0].DataPropertyName =
                "Nombre";

            dataGridView1.Columns[1].DataPropertyName =
                "Categoria";

            dataGridView1.Columns[2].DataPropertyName =
                "Medida";

            dataGridView1.Columns[3].DataPropertyName =
                "Tipo";

            dataGridView1.DataSource =
                productosLogica.ObtenerProductos();

            LimpiarFormulario();
        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.ClearSelection();

                dataGridView1.Rows[e.RowIndex].Selected =
                    true;
            }
        }

        private void dataGridView1_SelectionChanged(
            object sender,
            EventArgs e)
        {
        }

        private void btnagregareditar_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
                textboxnombreproducto.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre del producto."
                );

                textboxnombreproducto.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(
                comboboxcategoria.Text))
            {
                MessageBox.Show(
                    "Seleccione una categoría."
                );

                comboboxcategoria.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(
                comboboxmedida.Text))
            {
                MessageBox.Show(
                    "Seleccione una unidad de medida."
                );

                comboboxmedida.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(
                comboboxtipoproducto.Text))
            {
                MessageBox.Show(
                    "Seleccione el tipo de producto."
                );

                comboboxtipoproducto.Focus();

                return;
            }

            // AGREGAR
            if (btnagregareditar.Text == "Agregar")
            {
                productosLogica.AgregarProducto(
                    textboxnombreproducto.Text,
                    comboboxcategoria.Text,
                    comboboxmedida.Text,
                    comboboxtipoproducto.Text
                );

                LimpiarFormulario();
            }

            // EDITAR
            else if (
                btnagregareditar.Text == "Editar" &&
                filaSeleccionada >= 0)
            {
                productosLogica.EditarProducto(
                    filaSeleccionada,
                    textboxnombreproducto.Text,
                    comboboxcategoria.Text,
                    comboboxmedida.Text,
                    comboboxtipoproducto.Text
                );

                LimpiarFormulario();
            }
        }

        private void dataGridView1_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                filaSeleccionada = e.RowIndex;

                btnagregareditar.Text = "Editar";

                btneliminarlimpiar.Text =
                    "Eliminar producto";

                textboxnombreproducto.Text =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells[0].Value?.ToString();

                comboboxcategoria.SelectedItem =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells[1].Value?.ToString();

                comboboxmedida.SelectedItem =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells[2].Value?.ToString();

                comboboxtipoproducto.SelectedItem =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells[3].Value?.ToString();
            }
        }

        private void btneliminarlimpiar_Click(
            object sender,
            EventArgs e)
        {
            // SI NO HAY PRODUCTO SELECCIONADO,
            // EL BOTÓN LIMPIA LOS CONTROLES
            if (filaSeleccionada < 0)
            {
                LimpiarFormulario();
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de eliminar el producto seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                productosLogica.EliminarProducto(
                    filaSeleccionada
                );

                LimpiarFormulario();
            }
        }

        private void LimpiarFormulario()
        {
            textboxnombreproducto.Clear();

            comboboxcategoria.SelectedIndex = -1;

            comboboxmedida.SelectedIndex = -1;

            comboboxtipoproducto.SelectedIndex = -1;

            dataGridView1.ClearSelection();

            filaSeleccionada = -1;

            btnagregareditar.Text = "Agregar";

            btneliminarlimpiar.Text =
                "Limpiar controles";

            textboxnombreproducto.Focus();
        }
    }
}