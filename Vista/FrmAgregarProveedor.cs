using System;
using System.Windows.Forms;
using Logica;

namespace Vista
{
    public partial class FrmAgregarProveedor : Form
    {
        private ProveedoresLogica logica = new ProveedoresLogica();

        public FrmAgregarProveedor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string telTexto = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string alias = txtAlias.Text.Trim();


            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telTexto) ||
                string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(alias))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                bool insertado = logica.RegistrarProveedor(nombre, telTexto, correo, alias);

                if (insertado)
                {
                    MessageBox.Show("Proveedor registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                 
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}