using Logica;
using login_promires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista;

namespace Register_promires
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());
            //Application.Run(new Balance());
            //Application.Run(new Precios());
            //Application.Run(new Cuentas());
            //Application.Run(new Empleados());
            //Application.Run(new Promedios());
            //Application.Run(new Finanzasadmin());
            //Application.Run(new Proveedores());
            //Application.Run(new MenuEmpresa());
        }
    }
}