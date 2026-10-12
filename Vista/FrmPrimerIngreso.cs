using System;
using System.Data;
using System.Windows.Forms;
using Logica;

namespace Recuperacion_de_contraseña
{
    public partial class FrmPrimerIngreso : Form
    {
        private UsuarioSesion usuarioActual;
        private UsuarioLogica logica = new UsuarioLogica();
        private DataTable dtPreguntas;
        private int contadorRespuestas = 0;

        public FrmPrimerIngreso()
        {
            InitializeComponent();
        }

        public FrmPrimerIngreso(UsuarioSesion sesion)
        {
            InitializeComponent();
            this.usuarioActual = sesion;
        }

        private void FrmPrimerIngreso_Load(object sender, EventArgs e)
        {
            dtPreguntas = logica.ObtenerPreguntas();
            cmbPreguntas.DataSource = dtPreguntas;
            cmbPreguntas.DisplayMember = "pregunta";
            cmbPreguntas.ValueMember = "id_preguntas";

            // Aseguramos que arranquen desmarcados
            chkPregunta1.Checked = false;
            chkPregunta2.Checked = false;
            chkPregunta3.Checked = false;
        }

        private void btnOmitirPregunta_Click(object sender, EventArgs e)
        {
            if (cmbPreguntas.Items.Count > 1)
            {
                cmbPreguntas.SelectedIndex = (cmbPreguntas.SelectedIndex + 1) % cmbPreguntas.Items.Count;
            }
            txtrespuesta.Clear();
            txtrespuesta.Focus();
        }

        private void btnrespuesta_Click(object sender, EventArgs e)
        {
            string respuesta = txtrespuesta.Text.Trim();

            if (string.IsNullOrWhiteSpace(respuesta) || cmbPreguntas.SelectedValue == null)
            {
                MessageBox.Show("Escriba una respuesta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            int idPregunta = Convert.ToInt32(cmbPreguntas.SelectedValue);

            if (logica.RegistrarRespuesta(usuarioActual.IdUsuario, idPregunta, respuesta))
            {
                contadorRespuestas++;
                ProgressBar.PerformStep();

                // Actualizamos el tilde según la cantidad respondida
                if (contadorRespuestas == 1) chkPregunta1.Checked = true;
                else if (contadorRespuestas == 2) chkPregunta2.Checked = true;
                else if (contadorRespuestas == 3) chkPregunta3.Checked = true;

                // Quitar la pregunta respondida de la lista
                ((DataRowView)cmbPreguntas.SelectedItem).Row.Delete();
                txtrespuesta.Clear();

                // Al completar 3 respuestas se habilitan los controles de contraseña
                if (contadorRespuestas == 3)
                {
                    cmbPreguntas.Enabled = false;
                    txtrespuesta.Enabled = false;
                    btnrespuesta.Enabled = false;

                    txtContraseña1.Enabled = true;
                    txtContraseña2.Enabled = true;
                    chkMostrarContra.Enabled = true;
                    btnCambiarContra.Enabled = true;
                    txtContraseña1.Focus();
                }
            }
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            string pass1 = txtContraseña1.Text.Trim();
            string pass2 = txtContraseña2.Text.Trim();

            if (string.IsNullOrWhiteSpace(pass1) || pass1 != pass2)
            {
                MessageBox.Show("Las contraseñas no coinciden o están vacías.", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            if (logica.CambiarContrasenaPrimerIngreso(usuarioActual.IdUsuario, pass1))
            {
                MessageBox.Show("Contraseña actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }

        private void chkMostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña1.UseSystemPasswordChar = !chkMostrarContra.Checked;
            txtContraseña2.UseSystemPasswordChar = !chkMostrarContra.Checked;
        }
    }
}