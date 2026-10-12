using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Datos
{
    public class ProveedorDatos
    {
        //private string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoReGest;Trusted_Connection=True;TrustServerCertificate=True;";
        private readonly string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoReGest;Trusted_Connection=True;TrustServerCertificate=True;";

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ListarProveedores", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public bool Eliminar(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_EliminarProveedor", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);

                    con.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    
                    return filasAfectadas > 0 || filasAfectadas == -1;
                }
            }
        }

        public bool Insertar(string nombre, int telefono, string correo, string alias)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertarProveedor", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Alias_Bancario", alias);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}