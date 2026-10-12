using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Datos
{
    public class HistorialProveedoresDatos
    {
        private readonly string connectionString =
            @"Server=DESKTOP-NAV6PC1\SQLEXPRESS;Database=ProyectoReGest;Trusted_Connection=True;TrustServerCertificate=True;";

        public bool RegistrarCompra(
            int? idProveedor,
            int idProducto,
            decimal cantidad,
            decimal costoTotal,
            DateTime fechaCompra,
            DateTime? fechaVencimiento)
        {
            string query = @"
                INSERT INTO dbo.Compras_Proveedores
                (
                    id_Proveedor,
                    id_productoFK,
                    Cantidad,
                    CostoTotal,
                    FechaCompra,
                    Fecha_vencimiento
                )
                VALUES
                (
                    @idProveedor,
                    @idProducto,
                    @cantidad,
                    @costoTotal,
                    @fechaCompra,
                    @fechaVencimiento
                )";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@idProveedor", SqlDbType.Int).Value =
                        (object)idProveedor ?? DBNull.Value;

                    cmd.Parameters.Add("@idProducto", SqlDbType.Int).Value =
                        idProducto;

                    SqlParameter parametroCantidad =
                        cmd.Parameters.Add("@cantidad", SqlDbType.Decimal);

                    parametroCantidad.Precision = 10;
                    parametroCantidad.Scale = 2;
                    parametroCantidad.Value = cantidad;

                    SqlParameter parametroCosto =
                        cmd.Parameters.Add("@costoTotal", SqlDbType.Decimal);

                    parametroCosto.Precision = 18;
                    parametroCosto.Scale = 2;
                    parametroCosto.Value = costoTotal;

                    cmd.Parameters.Add("@fechaCompra", SqlDbType.DateTime).Value =
                        fechaCompra;

                    cmd.Parameters.Add("@fechaVencimiento", SqlDbType.DateTime).Value =
                        (object)fechaVencimiento ?? DBNull.Value;

                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable ObtenerHistorial(
            string filtro,
            DateTime desde,
            DateTime hasta)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT
                    c.id_Compra AS [ID],
                    c.FechaCompra AS [Fecha],
                    p.Nombre AS [Proveedor],
                    pc.Nombre AS [Producto],
                    c.Cantidad,
                    c.CostoTotal AS [Total]
                FROM dbo.Compras_Proveedores c
                LEFT JOIN dbo.Proveedores p
                    ON c.id_Proveedor = p.id_Proveedores
                INNER JOIN dbo.Productos_catalogo pc
                    ON c.id_productoFK = pc.id_producto
                WHERE c.FechaCompra >= @desde
                  AND c.FechaCompra <= @hasta
                  AND
                  (
                      @filtro = ''
                      OR p.Nombre LIKE '%' + @filtro + '%'
                      OR pc.Nombre LIKE '%' + @filtro + '%'
                  )
                ORDER BY c.FechaCompra DESC";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@desde", SqlDbType.DateTime).Value =
                        desde.Date;

                    cmd.Parameters.Add("@hasta", SqlDbType.DateTime).Value =
                        hasta.Date.AddDays(1).AddTicks(-1);

                    cmd.Parameters.Add("@filtro", SqlDbType.NVarChar, 100).Value =
                        string.IsNullOrWhiteSpace(filtro)
                            ? ""
                            : filtro.Trim();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public DataTable ObtenerProveedoresCombo()
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT
                    id_Proveedores,
                    Nombre
                FROM dbo.Proveedores
                ORDER BY Nombre ASC";

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

        public DataTable ObtenerProductosCatalogoCombo()
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT
                    id_producto,
                    Nombre
                FROM dbo.Productos_catalogo
                WHERE Estado = 1
                ORDER BY Nombre ASC";

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

        public DataTable ObtenerProveedores()
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT
                    id_Proveedores,
                    Nombre
                FROM dbo.Proveedores
                ORDER BY Nombre ASC";

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
    }
}