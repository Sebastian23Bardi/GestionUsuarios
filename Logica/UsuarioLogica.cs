using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using Datos;

namespace Logica
{
    public class UsuarioLogica
    {
        private UsuarioDatos datos = new UsuarioDatos();

        public string CalcularHashSHA256(string textoPlano)
        {
            if (string.IsNullOrEmpty(textoPlano)) return "";

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(textoPlano));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("X2"));
                }
                return builder.ToString();
            }
        }

        public UsuarioSesion IniciarSesion(string username, string passwordPlana)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(passwordPlana))
            {
                return null;
            }

            string passwordHash = CalcularHashSHA256(passwordPlana);
            DataTable dt = datos.ValidarLogin(username, passwordHash);

            if (dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];
                return new UsuarioSesion
                {
                    IdUsuario = Convert.ToInt32(fila["id_usuario"]),
                    Username = fila["username"].ToString(),
                    IdCargo = Convert.ToInt32(fila["id_Cargos"]),
                    PrimerIngreso = Convert.ToBoolean(fila["Primer_Ingreso"])
                };
            }

            return null;
        }

        public void CrearYEnviarUsuario(string username, string email, int idCargo)
        {
            string claveProvisoria = EnviarMail.GenerarPasswordAleatoria(8);
            string claveHasheada = CalcularHashSHA256(claveProvisoria);

            bool guardado = datos.RegistrarUsuario(username, claveHasheada, idCargo);

            if (!guardado)
            {
                throw new Exception("No se pudo registrar el usuario en la base de datos.");
            }

            EnviarMail.EnviarCredenciales(email, username, claveProvisoria);
        }

        public DataTable ObtenerPreguntas()
        {
            return datos.ObtenerPreguntasActivas();
        }

        public bool RegistrarRespuesta(int idUsuario, int idPregunta, string respuesta)
        {
            return datos.GuardarRespuestaSeguridad(idUsuario, idPregunta, respuesta);
        }

        public bool CambiarContrasenaPrimerIngreso(int idUsuario, string nuevaPasswordPlana)
        {
            string hash = CalcularHashSHA256(nuevaPasswordPlana);
            return datos.ActualizarContrasenaYCompletarPrimerIngreso(idUsuario, hash);
        }
        public DataTable ObtenerPreguntasPorUsuario(string username)
        {
            return datos.ObtenerPreguntasYRespuestasPorUsuario(username);
        }
    }
}