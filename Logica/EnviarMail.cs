using System;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace Logica
{
    public class EnviarMail
    {
        public static void Enviar(string destino, string asunto, string cuerpo)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("nehucroce@gmail.com", "Regest");
                mail.To.Add(destino);
                mail.Subject = asunto;
                mail.Body = cuerpo;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("nehucroce@gmail.com", "mwiy ibmd vgkk ygwf");
                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
            catch
            {
                throw new Exception("Error al enviar el mail. \n \n " +
                    "Por favor verifica tu conexión a internet y que tus datos sean correctos.");
            }
        }

        // Método del profesor para mandar solo destino y la clave provisoria
        public static void Enviar(string destino, string nuevaContrasenia)
        {
            string asunto = "Recuperación de contraseña";
            string cuerpo = CrearCuerpoRecuperacion(nuevaContrasenia);

            Enviar(destino, asunto, cuerpo);
        }

        // Método con formato del profesor que además incluye el nombre de usuario
        public static void EnviarCredenciales(string destino, string usuario, string nuevaContrasenia)
        {
            string asunto = "Alta de Usuario - Credenciales";
            string cuerpo = @"<style>
                                h1{color:dodgerblue; font-family: sans-serif;}
                                h2{color:darkorange; font-family: sans-serif;}
                                p{font-size: 15px; font-family: sans-serif;}
                              </style>
                              <h1>¡Bienvenido al sistema!</h1>
                              <p><b>Usuario:</b> " + usuario + @"</p>
                              <p>Contraseña provisoria:</p>
                              <h2>" + nuevaContrasenia + @"</h2>
                              <p>Por seguridad, cambiá tu clave al ingresar.</p>";

            Enviar(destino, asunto, cuerpo);
        }

        private static string CrearCuerpoRecuperacion(string nuevaContrasenia)
        {
            return @"<style>
                        h1{color:dodgerblue; font-family: sans-serif;}
                        h2{color:darkorange; font-family: sans-serif;}
                    </style>
                    <h1>Contraseña de ingreso:</h1>
                    <h2>" + nuevaContrasenia + "</h2>";
        }

        public static string GenerarPasswordAleatoria(int longitud = 8)
        {
            const string caracteres = "abcdefghjkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            StringBuilder sb = new StringBuilder();

            using (var rng = RandomNumberGenerator.Create())
            {
                byte[] buffer = new byte[sizeof(uint)];
                for (int i = 0; i < longitud; i++)
                {
                    rng.GetBytes(buffer);
                    uint num = BitConverter.ToUInt32(buffer, 0);
                    sb.Append(caracteres[(int)(num % (uint)caracteres.Length)]);
                }
            }
            return sb.ToString();
        }
    }
}