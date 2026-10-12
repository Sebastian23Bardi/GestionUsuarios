using System;
using Datos;
namespace Logica
{
    public class UsuarioSesion
    {
        public int IdUsuario { get; set; }
        public string Username { get; set; }
        public int IdCargo { get; set; }
        public bool PrimerIngreso { get; set; }
    }
}