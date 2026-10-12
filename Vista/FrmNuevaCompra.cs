using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Logica;

namespace Vista
{
    public partial class FrmNuevaCompra : Form
    {
        private ProveedoresLogica logicaProveedores =
            new ProveedoresLogica();

        private HistorialProveedoresLogica logicaHistorial =
            new HistorialProveedoresLogica();

        public FrmNuevaCompra()
        {
            InitializeComponent();
        }

        private void FrmNuevaCompra_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;

            datetimepickervencimiento.ShowCheckBox = true;
            datetimepickervencimiento.Checked = false;

            CargarComboProveedores();
            CargarComboProductos();
        }

        private void CargarComboProveedores()
        {
            try
            {
                DataTable dt = logicaHistorial.ListarProveedores();

                if (dt != null && dt.Rows.Count > 0)
                {
                    cmbProveedor.DisplayMember = "Nombre";
                    cmbProveedor.ValueMember = "id_Proveedores";
                    cmbProveedor.DataSource = dt;
                    cmbProveedor.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show(
                        "La consulta devolvió 0 filas. Verifique que la tabla dbo.Proveedores tenga registros.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al consultar proveedores: " + ex.Message,
                    "Error SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarComboProductos()
        {
            try
            {
                DataTable dt =
                    logicaHistorial.ObtenerProductosCompra();

                if (dt != null && dt.Rows.Count > 0)
                {
                    cmbProducto.DisplayMember = "Nombre";
                    cmbProducto.ValueMember = "id_producto";
                    cmbProducto.DataSource = dt;
                    cmbProducto.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show(
                        "No hay productos activos en el catálogo.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al consultar productos: " + ex.Message,
                    "Error SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbProveedor.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Por favor, seleccione un proveedor.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);

                cmbProveedor.Focus();
                return;
            }

            if (cmbProducto.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Por favor, seleccione un producto.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);

                cmbProducto.Focus();
                return;
            }


            string rawCantidad =
                txtUnidades.Text.Trim().Replace(',', '.');

            if (!decimal.TryParse(
                    rawCantidad,
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out decimal cantidad) ||
                cantidad <= 0)
            {
                MessageBox.Show(
                    "Ingrese una cantidad válida y mayor a 0.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);

                txtUnidades.Focus();
                return;
            }


            string rawPrecio =
                txtPrecioTotal.Text.Trim().Replace(',', '.');

            if (!decimal.TryParse(
                    rawPrecio,
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out decimal precio) ||
                precio <= 0)
            {
                MessageBox.Show(
                    "Ingrese un monto válido y mayor a 0 para el precio total.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);

                txtPrecioTotal.Focus();
                return;
            }


            try
            {
                int? idProveedor = null;

                if (cmbProveedor.SelectedValue != null &&
                    int.TryParse(
                        cmbProveedor.SelectedValue.ToString(),
                        out int idProveedorObtenido))
                {
                    idProveedor = idProveedorObtenido;
                }

                if (cmbProducto.SelectedValue == null ||
                    !int.TryParse(
                        cmbProducto.SelectedValue.ToString(),
                        out int idProducto))
                {
                    MessageBox.Show(
                        "No se pudo obtener el ID del producto seleccionado.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                DateTime fechaCompra = dtpFecha.Value;

                DateTime? fechaVencimiento = null;

                if (datetimepickervencimiento.Checked)
                {
                    fechaVencimiento =
                        datetimepickervencimiento.Value.Date;
                }


                bool exito = logicaHistorial.GuardarCompra(
                    idProveedor,
                    idProducto,
                    fechaCompra,
                    cantidad,
                    precio,
                    fechaVencimiento);

                if (exito)
                {
                    MessageBox.Show(
                        "Compra guardada exitosamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar la compra: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);
            }
        }
        private void txtUnidades_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (char.IsControl(e.KeyChar) ||
                char.IsDigit(e.KeyChar))
            {
                return;
            }

            if ((e.KeyChar == ',' || e.KeyChar == '.') &&
                !txt.Text.Contains(",") &&
                !txt.Text.Contains("."))
            {
                return;
            }

            e.Handled = true;
        }

        private void txtDecimales_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (char.IsControl(e.KeyChar) ||
                char.IsDigit(e.KeyChar))
            {
                return;
            }

            if ((e.KeyChar == ',' || e.KeyChar == '.') &&
                !txt.Text.Contains(",") &&
                !txt.Text.Contains("."))
            {
                return;
            }

            e.Handled = true;
        }
    }
}