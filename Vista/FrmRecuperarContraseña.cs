using System;
using System.Data;
using System.Windows.Forms;
using Logica;

namespace Vista
{
    public partial class FrmRecuperarContraseña : Form
    {
        private string nombreUsuario;
        private UsuarioLogica logica = new UsuarioLogica();
        private DataTable dtPreguntas;
        private int indicePreguntaActual = 0;
        private int idUsuarioRecuperacion = 0;

        public FrmRecuperarContraseña()
        {
            InitializeComponent();
        }

        // Constructor que recibe el usuario desde el Login
        public FrmRecuperarContraseña(string usuario)
        {
            InitializeComponent();
            this.nombreUsuario = usuario;
        }

        private void FrmRecuperarContraseña_Load(object sender, EventArgs e)
        {
            // Bloqueamos inicialmente la sección de cambio de contraseña
            txtNuevaContra.Enabled = false;
            txtConfirmarContra.Enabled = false;
            btnConfirmar.Enabled = false;

            // Ocultar caracteres de contraseña
            txtNuevaContra.UseSystemPasswordChar = true;
            txtConfirmarContra.UseSystemPasswordChar = true;

            // Obtenemos las preguntas del usuario desde la base de datos
            dtPreguntas = logica.ObtenerPreguntasPorUsuario(nombreUsuario);

            if (dtPreguntas == null || dtPreguntas.Rows.Count < 3)
            {
                MessageBox.Show("El usuario no existe o no tiene configuradas sus 3 preguntas de seguridad.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
                return;
            }

            // Guardamos el id del usuario
            idUsuarioRecuperacion = Convert.ToInt32(dtPreguntas.Rows[0]["id_usuario"]);

            // Cargamos la primera pregunta en tu label
            MostrarPreguntaActual();
        }

        private void MostrarPreguntaActual()
        {
            if (indicePreguntaActual < dtPreguntas.Rows.Count)
            {
                lblPreguntas.Text = dtPreguntas.Rows[indicePreguntaActual]["pregunta"].ToString();
                txtRespuesta.Clear();
                txtRespuesta.Focus();
            }
        }

        private void btnValidarRespuesta_Click(object sender, EventArgs e)
        {
            string respuestaIngresada = txtRespuesta.Text.Trim();

            if (string.IsNullOrWhiteSpace(respuestaIngresada))
            {
                MessageBox.Show("Por favor, ingrese su respuesta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            string respuestaCorrecta = dtPreguntas.Rows[indicePreguntaActual]["respuesta_Asociada"].ToString().Trim();

            // Comparar ignorando mayúsculas y minúsculas
            if (string.Equals(respuestaIngresada, respuestaCorrecta, StringComparison.OrdinalIgnoreCase))
            {
                indicePreguntaActual++;

                // Si aún quedan preguntas
                if (indicePreguntaActual < dtPreguntas.Rows.Count)
                {

                    MostrarPreguntaActual();
                }
                else
                {
                    // Deshabilitamos la zona de preguntas
                    lblPreguntas.Text = "Preguntas validadas con éxito.";
                    txtRespuesta.Clear();
                    txtRespuesta.Enabled = false;
                    btnValidarRespuesta.Enabled = false;

                    // Habilitamos la zona de cambio de contraseña
                    txtNuevaContra.Enabled = true;
                    txtConfirmarContra.Enabled = true;
                    chkMostrarContra.Enabled = true;
                    btnConfirmar.Enabled = true;
                    txtNuevaContra.Focus();
                }
            }
            else
            {
                MessageBox.Show("La respuesta ingresada es incorrecta. Intente nuevamente.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                txtRespuesta.SelectAll();
                txtRespuesta.Focus();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string pass1 = txtNuevaContra.Text.Trim();
            string pass2 = txtConfirmarContra.Text.Trim();

            if (string.IsNullOrWhiteSpace(pass1) || pass1 != pass2)
            {
                MessageBox.Show("Las contraseñas no coinciden o están vacías.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            if (logica.CambiarContrasenaPrimerIngreso(idUsuarioRecuperacion, pass1))
            {
                MessageBox.Show("Su contraseña ha sido restablecida exitosamente.",
                                "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al actualizar la contraseña.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void txtRespuesta_TextChanged(object sender, EventArgs e) { }
        private void lblPreguntas_Click(object sender, EventArgs e) { }
        private void txtNuevaContra_TextChanged(object sender, EventArgs e) { }
        private void txtConfirmarContra_TextChanged(object sender, EventArgs e) { }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtNuevaContra.UseSystemPasswordChar = !chkMostrarContra.Checked;
            txtConfirmarContra.UseSystemPasswordChar = !chkMostrarContra.Checked;
        }
    }
}