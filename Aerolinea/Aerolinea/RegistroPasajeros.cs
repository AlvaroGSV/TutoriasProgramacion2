using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea
{
    class RegistroPasajeros
    {
        Dictionary<int,Pasajero> registro = new Dictionary<int,Pasajero>();

        public void NuevoRegistro(Pasajero pasajero)
        {
            int nextPosicion = registro.Count + 1;
            registro.Add(nextPosicion, pasajero);
        }

    }
}
