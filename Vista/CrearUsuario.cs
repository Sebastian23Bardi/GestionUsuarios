using Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class CrearUsuario : Form
    {
        private UsuarioLogica usuarioLogica = new UsuarioLogica();

        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            DataTable dtRoles = new DataTable();
            dtRoles.Columns.Add("Id", typeof(int));
            dtRoles.Columns.Add("Nombre", typeof(string));

            dtRoles.Rows.Add(1, "Administrador");
            dtRoles.Rows.Add(2, "Empleado");

            cmbRol.DataSource = dtRoles;
            cmbRol.DisplayMember = "Nombre";
            cmbRol.ValueMember = "Id";
            cmbRol.SelectedIndex = -1;
        }

        private void CrearUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string usuario = txtUsuario.Text.Trim();

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(usuario) || cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor completá todos los campos antes de continuar.",
                                "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnEnviar.Enabled = false;

                int idCargo = Convert.ToInt32(cmbRol.SelectedValue);

                usuarioLogica.CrearYEnviarUsuario(usuario, correo, idCargo);

                MessageBox.Show($"\nUsuario '{usuario}' registrado y credenciales enviadas a: {correo}",
                                "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCorreo.Clear();
                txtUsuario.Clear();
                cmbRol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error durante el proceso: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnEnviar.Enabled = true;
            }
        }
    }
}