using System;
using System.Data;
using Datos;

namespace Logica
{
    public class ProductosLogica
    {
        private DataTable tablaProductos = new DataTable();

        private DataTable tablaProductosCompra = new DataTable();

        private DataTable tablaProductosElaborados = new DataTable();

        private DataTable tablaProductosDerivados = new DataTable();

        private ProductosDatos productosDatos = new ProductosDatos();
        public ProductosLogica()
        {
            // TABLA GENERAL
            tablaProductos.Columns.Add("id_producto");
            tablaProductos.Columns.Add("Nombre");
            tablaProductos.Columns.Add("Categoria");
            tablaProductos.Columns.Add("Medida");
            tablaProductos.Columns.Add("Tipo");

            // PRODUCTOS DE COMPRA
            tablaProductosCompra.Columns.Add("Nombre");
            tablaProductosCompra.Columns.Add("Categoria");
            tablaProductosCompra.Columns.Add("Medida");
            tablaProductosCompra.Columns.Add("Tipo");

            // PRODUCTOS ELABORADOS
            tablaProductosElaborados.Columns.Add("Nombre");
            tablaProductosElaborados.Columns.Add("Categoria");
            tablaProductosElaborados.Columns.Add("Medida");
            tablaProductosElaborados.Columns.Add("Tipo");

            // PRODUCTOS DERIVADOS
            tablaProductosDerivados.Columns.Add("Nombre");
            tablaProductosDerivados.Columns.Add("Categoria");
            tablaProductosDerivados.Columns.Add("Medida");
            tablaProductosDerivados.Columns.Add("Tipo");

            CargarProductosDesdeBaseDatos();
        }
        private void CargarProductosDesdeBaseDatos()
        {
            DataTable productosGuardados =
                productosDatos.ObtenerProductosCatalogo();

            foreach (DataRow fila in productosGuardados.Rows)
            {
                int idProducto =
                    Convert.ToInt32(fila["id_producto"]);

                string nombre =
                    fila["Nombre"].ToString();

                string categoria =
                    fila["Categoria"].ToString();

                string medida =
                    fila["Medida"].ToString();

                string tipo =
                    fila["Tipo"].ToString();

                tablaProductos.Rows.Add(
                    idProducto,
                    nombre,
                    categoria,
                    medida,
                    tipo
                );

                if (tipo == "Revendible")
                {
                    tablaProductosCompra.Rows.Add(
                        nombre,
                        categoria,
                        medida,
                        "Revendible"
                    );
                }
                else if (tipo == "Elaborable")
                {
                    tablaProductosElaborados.Rows.Add(
                        nombre,
                        categoria,
                        medida,
                        "Elaborable"
                    );
                }
                else if (tipo == "Derivado")
                {
                    tablaProductosDerivados.Rows.Add(
                        nombre,
                        categoria,
                        medida,
                        "Derivado"
                    );
                }
            }
        }
        public void AgregarProducto(
            string nombre,
            string categoria,
            string medida,
            string tipo)
        {
            // Primero guardamos en SQL y obtenemos el ID generado
            int idProducto =
                productosDatos.AgregarProductoCatalogo(
                    nombre,
                    categoria,
                    medida,
                    tipo
                );

            // Después agregamos el producto a la tabla de memoria
            tablaProductos.Rows.Add(
                idProducto,
                nombre,
                categoria,
                medida,
                tipo
            );

            if (tipo == "Revendible")
            {
                AgregarRevendible(
                    nombre,
                    categoria,
                    medida
                );
            }
            else if (tipo == "Elaborable")
            {
                AgregarElaborable(
                    nombre,
                    categoria,
                    medida
                );
            }
            else if (tipo == "Derivado")
            {
                AgregarDerivado(
                    nombre,
                    categoria,
                    medida
                );
            }
        }
        private void AgregarRevendible(
            string nombre,
            string categoria,
            string medida)
        {
            tablaProductosCompra.Rows.Add(
                nombre,
                categoria,
                medida,
                "Revendible"
            );
        }
        private void AgregarElaborable(
            string nombre,
            string categoria,
            string medida)
        {
            tablaProductosElaborados.Rows.Add(
                nombre,
                categoria,
                medida,
                "Elaborable"
            );
        }
        private void AgregarDerivado(
            string nombre,
            string categoria,
            string medida)
        {
            tablaProductosDerivados.Rows.Add(
                nombre,
                categoria,
                medida,
                "Derivado"
            );
        }
        public void EditarProducto(
            int indice,
            string nombre,
            string categoria,
            string medida,
            string tipo)
        {
            if (indice >= 0 &&
                indice < tablaProductos.Rows.Count)
            {
                int idProducto =
                    Convert.ToInt32(
                        tablaProductos.Rows[indice]["id_producto"]
                    );

                // Primero actualizamos SQL Server
                productosDatos.EditarProductoCatalogo(
                    idProducto,
                    nombre,
                    categoria,
                    medida,
                    tipo
                );

                // Después actualizamos la tabla de memoria
                tablaProductos.Rows[indice]["Nombre"] = nombre;
                tablaProductos.Rows[indice]["Categoria"] = categoria;
                tablaProductos.Rows[indice]["Medida"] = medida;
                tablaProductos.Rows[indice]["Tipo"] = tipo;

                ReconstruirTablasPorTipo();
            }
        }
        public void EliminarProducto(int indice)
        {
            if (indice >= 0 &&
                indice < tablaProductos.Rows.Count)
            {
                int idProducto =
                    Convert.ToInt32(
                        tablaProductos.Rows[indice]["id_producto"]
                    );

                // Eliminación lógica en SQL Server
                productosDatos.EliminarProductoCatalogo(
                    idProducto
                );

                // Eliminamos de la tabla de memoria
                tablaProductos.Rows.RemoveAt(indice);

                ReconstruirTablasPorTipo();
            }
        }
        private void ReconstruirTablasPorTipo()
        {
            tablaProductosCompra.Clear();
            tablaProductosElaborados.Clear();
            tablaProductosDerivados.Clear();

            foreach (DataRow fila in tablaProductos.Rows)
            {
                string nombre =
                    fila["Nombre"].ToString();

                string categoria =
                    fila["Categoria"].ToString();

                string medida =
                    fila["Medida"].ToString();

                string tipo =
                    fila["Tipo"].ToString();

                if (tipo == "Revendible")
                {
                    tablaProductosCompra.Rows.Add(
                        nombre,
                        categoria,
                        medida,
                        "Revendible"
                    );
                }
                else if (tipo == "Elaborable")
                {
                    tablaProductosElaborados.Rows.Add(
                        nombre,
                        categoria,
                        medida,
                        "Elaborable"
                    );
                }
                else if (tipo == "Derivado")
                {
                    tablaProductosDerivados.Rows.Add(
                        nombre,
                        categoria,
                        medida,
                        "Derivado"
                    );
                }
            }
        }
        public int CantidadProductos()
        {
            return tablaProductos.Rows.Count;
        }

        public DataTable ObtenerProductos()
        {
            return tablaProductos;
        }

        public DataTable ObtenerProductosCompra()
        {
            return tablaProductosCompra;
        }

        public DataTable ObtenerProductosElaborados()
        {
            return tablaProductosElaborados;
        }

        public DataTable ObtenerProductosDerivados()
        {
            return tablaProductosDerivados;
        }
    }
}