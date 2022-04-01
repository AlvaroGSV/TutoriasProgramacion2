using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutoria2
{
    class claseRandom
    {
        public bool ValidaNumeroRepetido(int numGuardado, int numNuevo)
        {
            bool valida = false; //el numero no se repite
            if(numGuardado == numNuevo)
            {
                valida = true; //el nuemro se repitio
            }
            return valida;
        }
    }
}
