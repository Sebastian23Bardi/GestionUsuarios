using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Datos
{
    public class UsuarioDatos
    {
        //private readonly string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoReGest;Trusted_Connection=True;TrustServerCertificate=True;";
        private readonly string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoReGest;Trusted_Connection=True;TrustServerCertificate=True;";
        public DataTable ValidarLogin(string username, string passwordHash)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT id_usuario, username, id_Cargos, Primer_Ingreso 
                             FROM Usuarios 
                             WHERE username = @usuario AND [contraseña] = @password AND Fe_Baja IS NULL";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@usuario", SqlDbType.NVarChar, 50).Value = username;
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar, 64).Value = passwordHash;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public bool RegistrarUsuario(string username, string passwordHash, int idCargo)
        {
            string query = @"INSERT INTO Usuarios (username, [contraseña], Fe_Alta, Fe_Baja, id_Cargos, Primer_Ingreso) 
                     VALUES (@username, @password, @feAlta, NULL, @idCargo, 1)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = username;
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar, 64).Value = passwordHash;
                    cmd.Parameters.Add("@feAlta", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@idCargo", SqlDbType.Int).Value = idCargo;

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable ObtenerPreguntasActivas()
        {
            DataTable dt = new DataTable();
            string query = "SELECT id_preguntas, pregunta FROM dbo.Preguntas_de_Seguridad WHERE estado = 1";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public bool GuardarRespuestaSeguridad(int idUsuario, int idPregunta, string respuesta)
        {
            string query = @"INSERT INTO dbo.usuario_pregunta (id_usuario, id_preguntas, respuesta_Asociada)
                             VALUES (@idUsuario, @idPregunta, @respuesta)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                    cmd.Parameters.Add("@idPregunta", SqlDbType.Int).Value = idPregunta;
                    cmd.Parameters.Add("@respuesta", SqlDbType.NVarChar, 50).Value = respuesta;

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool ActualizarContrasenaYCompletarPrimerIngreso(int idUsuario, string nuevaPasswordHash)
        {
            string query = @"UPDATE dbo.Usuarios 
                             SET [contraseña] = @password, Primer_Ingreso = 0 
                             WHERE id_usuario = @idUsuario";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar, 64).Value = nuevaPasswordHash;
                    cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public DataTable ObtenerPreguntasYRespuestasPorUsuario(string username)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT up.id_usuario, up.id_preguntas, p.pregunta, up.respuesta_Asociada
                     FROM dbo.usuario_pregunta up
                     INNER JOIN dbo.Usuarios u ON up.id_usuario = u.id_usuario
                     INNER JOIN dbo.Preguntas_de_Seguridad p ON up.id_preguntas = p.id_preguntas
                     WHERE u.username = @username AND u.Fe_Baja IS NULL";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = username;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}