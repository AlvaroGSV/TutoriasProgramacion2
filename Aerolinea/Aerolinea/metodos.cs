using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea
{
    class metodos
    {
        RegistroPasajeros pasajeros;

        public metodos (RegistroPasajeros registroPasajeros)
        {
            pasajeros = registroPasajeros;
        }

        public int NuevoPasajero(string PrimerNombre, string SegundoNombre,
            string PrimerApellido, string SegundoApellido,
            string Nacionalidad, int Edad, string Telefono, string CorreoElectronio)
        {
            int valido = 0;
            if(PrimerApellido!= " " || PrimerApellido == null)
            {
                if(PrimerNombre!= " " || PrimerNombre == null)
                {
                    if(SegundoApellido != " " || SegundoApellido == null)
                    {
                        if(SegundoNombre!= " " || SegundoNombre == null)
                        {
                            SegundoNombre = "No Tiene";
                            if(Nacionalidad != " " || Nacionalidad == null)
                            {
                                Nacionalidad = "MX";
                                if (Telefono != " " || Telefono == null)
                                {
                                    if (CorreoElectronio != " " || CorreoElectronio == null)
                                    {
                                        Pasajero pasajero = new Pasajero(PrimerNombre, SegundoNombre,
                                        PrimerApellido, SegundoApellido,
                                        Nacionalidad, Edad, Telefono, CorreoElectronio);
                                    }
                                }
                                else
                                {
                                    valido = 1;
                                }
                            }
                        }

                    }
                    else
                    {
                        valido = 1;
                    }
                }
                else
                {
                    valido = 1;
                }
            }
            else
            {
                valido = 1;
            }
            

            return valido;
        }
    }
}
