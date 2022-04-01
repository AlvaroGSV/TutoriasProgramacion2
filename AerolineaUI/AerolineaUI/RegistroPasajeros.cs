using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaUI
{
    public class RegistroPasajeros
    {
        Dictionary<int,Pasajero> registro = new Dictionary<int,Pasajero>();

        private int SiguientePosición()
        {
            int posicion = registro.Count + 1;
            return posicion;
        }

        private string siguienteClave()
        {
            string mesa = "PasajeroNormal";
            int posicion = registro.Count + 1;
            return mesa + posicion;
        }

        public void NuevoRegistro(Pasajero pasajero)
        {
            registro.Add(SiguientePosición(), pasajero);
        }

    }
}
