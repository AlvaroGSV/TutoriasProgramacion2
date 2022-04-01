using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoo_de_tutoria_D1
{
    class Program
    {
        ArregloObjeto arreglo;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.arreglo = new ArregloObjeto();

            Manejadora manejadora = new Manejadora(p.arreglo);
            int op = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Guardar datos");
                Console.WriteLine("2 - Presentar datos");
                Console.WriteLine("3 - Eliminar tal dato");
                Console.WriteLine("4 - Elminar todos los datos");
                Console.WriteLine("5 - Salir");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        int num;
                        string str;
                        Console.WriteLine("Ingrese un nuemro entero");
                        num = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese una letra");
                        str = Console.ReadLine();
                        bool seGuardo = manejadora.SaveData(num, str);
                        if (seGuardo == true)
                        {
                            Console.WriteLine("Se guardo con exito");
                        }
                        else
                        {
                            Console.WriteLine("No se guardo");
                        }
                        break;
                    case 2:
                        manejadora.PresentarDatos();
                        break;
                    case 3:
                        break;
                    case 4:
                        string res = manejadora.DeleteAll();
                        Console.WriteLine(res);
                        break;
                    case 5:
                        Console.ReadKey();
                        break;
                }
            } while (op != 5);
        }
    }
}
