using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ProductosDatos
    {
        private string cadenaConexion =
            @"Server=DESKTOP-NAV6PC1\SQLEXPRESS;Database=ProyectoReGest;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=5;";

        public int ObtenerIdCategoria(string nombreCategoria)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = @"
                    SELECT id_Categoria
                    FROM [Categoria de producto]
                    WHERE Tipo_de_categoria = @categoria
                    AND Estado = 1";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.CommandTimeout = 5;

                    comando.Parameters.AddWithValue(
                        "@categoria",
                        nombreCategoria
                    );

                    conexion.Open();

                    object resultado = comando.ExecuteScalar();

                    if (resultado == null)
                    {
                        throw new Exception(
                            "No se encontró la categoría: " + nombreCategoria
                        );
                    }

                    return Convert.ToInt32(resultado);
                }
            }
        }

        public void AgregarProductoCompra(
            string nombre,
            string categoria,
            string medida)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string consultaCategoria = @"
                    SELECT id_Categoria
                    FROM [Categoria de producto]
                    WHERE Tipo_de_categoria = @categoria
                    AND Estado = 1";

                int idCategoria;

                using (SqlCommand comandoCategoria =
                       new SqlCommand(consultaCategoria, conexion))
                {
                    comandoCategoria.CommandTimeout = 5;

                    comandoCategoria.Parameters.AddWithValue(
                        "@categoria",
                        categoria
                    );

                    object resultado =
                        comandoCategoria.ExecuteScalar();

                    if (resultado == null)
                    {
                        throw new Exception(
                            "No se encontró la categoría: " + categoria
                        );
                    }

                    idCategoria = Convert.ToInt32(resultado);
                }

                string consultaProducto = @"
                    INSERT INTO Productos_compra
                    (
                        Nombre,
                        id_CategoriaFK,
                        Unidad_Medida,
                        Es_Fraccionable,
                        Estado
                    )
                    VALUES
                    (
                        @nombre,
                        @idCategoria,
                        @medida,
                        0,
                        1
                    )";

                using (SqlCommand comandoProducto =
                       new SqlCommand(consultaProducto, conexion))
                {
                    comandoProducto.CommandTimeout = 5;

                    comandoProducto.Parameters.AddWithValue(
                        "@nombre",
                        nombre
                    );

                    comandoProducto.Parameters.AddWithValue(
                        "@idCategoria",
                        idCategoria
                    );

                    comandoProducto.Parameters.AddWithValue(
                        "@medida",
                        medida
                    );

                    comandoProducto.ExecuteNonQuery();
                }
            }
        }

        public int AgregarProductoCatalogo(
            string nombre,
            string categoria,
            string medida,
            string tipo)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string consultaCategoria = @"
                    SELECT id_Categoria
                    FROM [Categoria de producto]
                    WHERE Tipo_de_categoria = @categoria
                    AND Estado = 1";

                int idCategoria;

                using (SqlCommand comandoCategoria =
                       new SqlCommand(consultaCategoria, conexion))
                {
                    comandoCategoria.CommandTimeout = 5;

                    comandoCategoria.Parameters.AddWithValue(
                        "@categoria",
                        categoria
                    );

                    object resultado =
                        comandoCategoria.ExecuteScalar();

                    if (resultado == null)
                    {
                        throw new Exception(
                            "No se encontró la categoría: " + categoria
                        );
                    }

                    idCategoria = Convert.ToInt32(resultado);
                }

                string consultaProducto = @"
                    INSERT INTO Productos_catalogo
                    (
                        Nombre,
                        id_CategoriaFK,
                        Unidad_Medida,
                        Tipo,
                        Estado
                    )
                    VALUES
                    (
                        @nombre,
                        @idCategoria,
                        @medida,
                        @tipo,
                        1
                    );

                    SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand comandoProducto =
                       new SqlCommand(consultaProducto, conexion))
                {
                    comandoProducto.CommandTimeout = 5;

                    comandoProducto.Parameters.AddWithValue(
                        "@nombre",
                        nombre
                    );

                    comandoProducto.Parameters.AddWithValue(
                        "@idCategoria",
                        idCategoria
                    );

                    comandoProducto.Parameters.AddWithValue(
                        "@medida",
                        medida
                    );

                    comandoProducto.Parameters.AddWithValue(
                        "@tipo",
                        tipo
                    );

                    return Convert.ToInt32(
                        comandoProducto.ExecuteScalar()
                    );
                }
            }
        }

        public DataTable ObtenerProductosCatalogo()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = @"
                    SELECT
                        pc.id_producto,
                        pc.Nombre,
                        c.Tipo_de_categoria AS Categoria,
                        pc.Unidad_Medida AS Medida,
                        pc.Tipo
                    FROM Productos_catalogo pc
                    INNER JOIN [Categoria de producto] c
                        ON pc.id_CategoriaFK = c.id_Categoria
                    WHERE pc.Estado = 1
                    ORDER BY pc.Nombre";

                using (SqlCommand comando =
                       new SqlCommand(consulta, conexion))
                {
                    comando.CommandTimeout = 5;

                    using (SqlDataAdapter adaptador =
                           new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }

        public void EditarProductoCatalogo(
            int idProducto,
            string nombre,
            string categoria,
            string medida,
            string tipo)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                int idCategoria;

                string consultaCategoria = @"
                    SELECT id_Categoria
                    FROM [Categoria de producto]
                    WHERE Tipo_de_categoria = @categoria
                    AND Estado = 1";

                using (SqlCommand comandoCategoria =
                       new SqlCommand(consultaCategoria, conexion))
                {
                    comandoCategoria.CommandTimeout = 5;

                    comandoCategoria.Parameters.AddWithValue(
                        "@categoria",
                        categoria
                    );

                    object resultado =
                        comandoCategoria.ExecuteScalar();

                    if (resultado == null)
                    {
                        throw new Exception(
                            "No se encontró la categoría: " + categoria
                        );
                    }

                    idCategoria = Convert.ToInt32(resultado);
                }

                string consulta = @"
                    UPDATE Productos_catalogo
                    SET
                        Nombre = @nombre,
                        id_CategoriaFK = @idCategoria,
                        Unidad_Medida = @medida,
                        Tipo = @tipo
                    WHERE id_producto = @idProducto";

                using (SqlCommand comando =
                       new SqlCommand(consulta, conexion))
                {
                    comando.CommandTimeout = 5;

                    comando.Parameters.AddWithValue(
                        "@idProducto",
                        idProducto
                    );

                    comando.Parameters.AddWithValue(
                        "@nombre",
                        nombre
                    );

                    comando.Parameters.AddWithValue(
                        "@idCategoria",
                        idCategoria
                    );

                    comando.Parameters.AddWithValue(
                        "@medida",
                        medida
                    );

                    comando.Parameters.AddWithValue(
                        "@tipo",
                        tipo
                    );

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void EliminarProductoCatalogo(int idProducto)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string consulta = @"
                    UPDATE Productos_catalogo
                    SET Estado = 0
                    WHERE id_producto = @idProducto";

                using (SqlCommand comando =
                       new SqlCommand(consulta, conexion))
                {
                    comando.CommandTimeout = 5;

                    comando.Parameters.AddWithValue(
                        "@idProducto",
                        idProducto
                    );

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}