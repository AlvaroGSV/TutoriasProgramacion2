using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaUI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            RegistroPasajeros registroPasajeros = new RegistroPasajeros();
            metodos met = new metodos(registroPasajeros);
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(met));
        }
    }
}
