using System;
using System.Data;
using Datos;

namespace Logica
{
    public class HistorialProveedoresLogica
    {
        private HistorialProveedoresDatos datos =
            new HistorialProveedoresDatos();
        public bool GuardarCompra(
            int? idProveedor,
            int idProducto,
            DateTime fecha,
            decimal cantidad,
            decimal precio,
            DateTime? fechaVencimiento)
        {
            if (idProducto <= 0)
                throw new ArgumentException(
                    "Debe seleccionar un producto.");

            if (cantidad <= 0)
                throw new ArgumentException(
                    "La cantidad debe ser mayor a 0.");

            if (precio <= 0)
                throw new ArgumentException(
                    "El costo total debe ser mayor a 0.");

            return datos.RegistrarCompra(
                idProveedor,
                idProducto,
                cantidad,
                precio,
                fecha,
                fechaVencimiento);
        }
        public DataTable ConsultarHistorial(
            string filtro,
            DateTime desde,
            DateTime hasta)
        {
            return datos.ObtenerHistorial(
                filtro,
                desde,
                hasta);
        }
        public DataTable ObtenerProveedores()
        {
            return datos.ObtenerProveedoresCombo();
        }
        public DataTable ObtenerProductosCompra()
        {
            return datos.ObtenerProductosCatalogoCombo();
        }
        public DataTable ListarProveedores()
        {
            return datos.ObtenerProveedores();
        }
    }
}