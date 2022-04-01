using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea
{
    class Program
    {
        RegistroPasajeros pasajeros;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.pasajeros = new RegistroPasajeros();
            metodos met = new metodos(program.pasajeros);
        }
    }
}
