using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoo_de_tutoria_D1
{
    class ArregloObjeto
    {
        public Objeto[] Arreglobjeto = new Objeto[10];
        public Objeto objeto = new Objeto();

        public bool SaveData(int num, string str)
        {
            bool guardado = false;
            if (str != null && str != " ")
            {
                objeto = new Objeto(num, str);
                for (int i = 0; i < Arreglobjeto.Length; i++)
                {
                    if (Arreglobjeto[i] == null)
                    {
                        Arreglobjeto[i] = objeto;
                        guardado = true;
                        break;
                    }

                }
            }
            return guardado;
        }
        public Objeto[] PrintObj()
        {
            Objeto[] arr = new Objeto[10];
            arr = Arreglobjeto;
            return arr;
        }
        public int BorrarTodo()
        {
            int funciono = 0;
            Objeto[] arr = new Objeto[10];
            Arreglobjeto = arr;
            for (int i = 0; i < Arreglobjeto.Length; i++)
            {
                if (Arreglobjeto[i] == null)
                {
                    funciono = 1;
                    break;
                }

            }
            return funciono;
        }
    }
}
