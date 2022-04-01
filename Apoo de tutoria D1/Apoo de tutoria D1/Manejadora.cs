using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoo_de_tutoria_D1
{
    class Manejadora
    {
        ArregloObjeto Arreglo;

        public Manejadora(ArregloObjeto arreglo)
        {
            Arreglo = arreglo;
        }
        public bool SaveData(int num, string str)
        {
            bool guardado = Arreglo.SaveData(num, str);
            return guardado;
        }
        public void PresentarDatos()
        {
            Objeto[] objArr = Arreglo.PrintObj();
            foreach (Objeto obj in objArr) 
            {
                Console.Out.WriteLine($"el numero es {obj.getNumObjeto()}, el string es {obj.getStringObjeto()}");
            }
        }
        public string DeleteAll()
        {
            string res = "-";
            int seBorro = Arreglo.BorrarTodo();
            if (seBorro == 1)
            {
                res = "Se borro con exito";
            }
            else
            {
                res = "No se borro nada";
            }
            return res;
        }
    }
}
