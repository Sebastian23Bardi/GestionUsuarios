using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class ProveedoresLogica
    {
        private ProveedorDatos datos = new ProveedorDatos();

        public DataTable ObtenerProveedores()
        {
            return datos.Listar();
        }
        public DataTable ConsultarHistorial(string filtro, DateTime desde, DateTime hasta)
        {
            HistorialProveedoresDatos datosHistorial = new HistorialProveedoresDatos();
            return datosHistorial.ObtenerHistorial(filtro, desde, hasta);
        }
        public bool RegistrarProveedor(string nombre, string telTexto, string correo, string alias)
        {
 
            if (!int.TryParse(telTexto, out int telefono))
            {
                throw new Exception("El teléfono debe contener únicamente números.");
            }


            return datos.Insertar(nombre, telefono, correo, alias);
        }
        public bool BorrarProveedor(int id)
        {
            return datos.Eliminar(id);
        }
    }
}