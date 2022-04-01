using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_U1_prueba
{
    class ArregloMotos
    {
        Moto[] arreglo = new Moto[19];

        

        public void llenado()
        {
            Moto moto = new Moto(1, "Honda", 45.30, 500);
            arreglo[0] = moto;
            Moto moto1 = new Moto(2, "Yamaha", 45.30, 500);
            arreglo[1] = moto1;
            Moto moto2 = new Moto(2, "italika", 45.30, 500);
            arreglo[2] = moto2;
            Moto moto3 = new Moto(3, "Toyota", 45.30, 500);
            arreglo[3] = moto3;
        }
        public int NumMotosDuplicadas()
        {
            int nDuplicados = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = 0; j < arreglo.Length; j++)
                {
                    if (arreglo[i] != null && arreglo[j] != null)
                    {
                        if (arreglo[i].getId().ToString() == arreglo[j].getId().ToString())
                        {
                            if (i != j)
                            {
                                nDuplicados = nDuplicados + 1;
                            }
                        }
                    }
                }
            }
            return nDuplicados;
        }
        public string[] MotosDuplicadas()
        {
            int nDuplicados = NumMotosDuplicadas();
            string[] arr = new string[19];
            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = 0; j < arreglo.Length; j++)
                {
                    if (arreglo[i] != null && arreglo[j] != null)
                    {
                        if (arreglo[i].getId().ToString() == arreglo[j].getId().ToString())
                        {
                            if (i != j)
                            {
                                arr[i] = $"La moto con el id {arreglo[i].getId().ToString()} esta duplicada y se encuentra en {i}";
                            }
                        }
                    }
                }
            }
            return arr;
        }
        public int BuscarIdMoto (int idUser)
        {
            int respuesta = 0;
            for(int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i]!=null)
                {
                    if (arreglo[i].getId().ToString() == idUser.ToString())
                    {
                        respuesta = i;
                        break;
                    }
                    else
                    {
                        respuesta = -1;
                    }
                }
            }
            return respuesta;
        }

        public bool UpdateBrandMoto(int idUser, string neuBrand)
        {
            bool res = false;
            int posicionAModificar = BuscarIdMoto(idUser);
            if(posicionAModificar != -1)
            {
                string altBrand = arreglo[posicionAModificar].propiedadMarca.ToString();
                arreglo[posicionAModificar].propiedadMarca = neuBrand;
                if (altBrand.ToString() != arreglo[posicionAModificar].propiedadMarca.ToString())
                {
                    res = true;
                }
            }
            return res;
        }
    }
}
