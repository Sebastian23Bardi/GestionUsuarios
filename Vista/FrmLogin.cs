using Logica;
using Recuperacion_de_contraseña;
using Register_promires;
using System;
using System.Windows.Forms;
using Vista;

namespace login_promires
{
    public partial class FrmLogin : Form
    {
        private UsuarioLogica logica = new UsuarioLogica();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text.Trim();
            string pass = txtContraseña.Text.Trim();

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Atención");
                return;
            }

            UsuarioSesion sesion = logica.IniciarSesion(user, pass);

            if (sesion == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación");
                txtContraseña.Clear();
                txtContraseña.Focus();
                return;
            }

           
            if (sesion.PrimerIngreso)
            {
                MessageBox.Show("Es su primer ingreso. Debe responder las preguntas de seguridad y actualizar su contraseña.", "Primer Ingreso");

                this.Hide();
                FrmPrimerIngreso primeringreso = new FrmPrimerIngreso(sesion);
                primeringreso.ShowDialog();
                this.Show();
                txtContraseña.Clear();
            }
            else
            {

                if (sesion.IdCargo == 1) 
                {
                    this.Hide();
                    MenuEmpresa menuAdmin = new MenuEmpresa();
                    menuAdmin.Show();
                }
                else if (sesion.IdCargo == 2) 
                {
                    this.Hide();
                    MenuEmpleado menuEmp = new MenuEmpleado();
                    menuEmp.Show();
                }
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbcontra.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Por favor, ingrese su nombre de usuario para recuperar la contraseña.",
                                "Atención");
                txtUsuario.Focus();
                return;
            }

            FrmRecuperarContraseña passrec = new FrmRecuperarContraseña(usuario);
            passrec.ShowDialog();
        }
    }
}