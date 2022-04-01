using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, c = 0;
            int b;
            string lineA="", lineB = "";
            bool validaNumA = false, validaNumB = false;
            do
            {
                Console.WriteLine("INGRESE EL PRIMER NUMERO");
                lineA = Console.ReadLine();
                a = ValidaNumero(lineA);
                validaNumA = Valida(lineA);
            } while (validaNumA==false);

            do
            {
                Console.WriteLine("INGRESE EL SEGUNDO NUMERO");
                lineB = Console.ReadLine();
                b = ValidaNumero(lineB);
                validaNumB = Valida(lineB);
            } while (validaNumB == false);
            c = a + b;
            Console.WriteLine($"NUESTRO RESULTADO ES {c} FUE SU RESUTADO");
            Console.ReadKey();
        }

        static public int ValidaNumero(string numOriginal)
        {
            int numValidado = 0;
            if (int.TryParse(numOriginal, out numValidado))
            {
            }
            else
            {
                numValidado = 0;
            }
            return numValidado;
        }
        static public bool Valida(string num)
        {
            int numValidado = 0;
            bool numStatus = false;
            if (int.TryParse(num, out numValidado))
            {
                numStatus = true;
            }
            else
            {
                numStatus = false;
            }
            return numStatus;
        }
    }
}
