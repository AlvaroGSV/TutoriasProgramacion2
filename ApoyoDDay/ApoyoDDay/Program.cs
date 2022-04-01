using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoyoDDay
{
    class Program
    {
        ArregloCuadrados arreglo;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.arreglo = new ArregloCuadrados();
            Manejadora maneja = new Manejadora(p.arreglo);
            int op = 0;
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1- Guardar Cuadrado");
                Console.WriteLine("2- Imprimir cuadrados");
                Console.WriteLine("3- Eliminar cuadrado");
                Console.WriteLine("4- Eliminar todos los cuarados");
                Console.WriteLine("5- Calcular area");
                Console.WriteLine("6- calcular perimetro");
                Console.WriteLine("7- Salir");
                Console.WriteLine("ingrese su opcion");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        int lado;
                        string dato;
                        Console.WriteLine("ingrese un numero");
                        lado = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese un dato");
                        dato = Console.ReadLine();
                        maneja.GuardarCuadrado(lado, dato);
                        break;
                    case 2:
                        maneja.ImprimirCuadrado();
                        break;
                    case 3:
                        int lado2;
                        string dato2;
                        Console.WriteLine("ingrese un numero");
                        lado2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese un dato");
                        dato2 = Console.ReadLine();
                        maneja.BorrarCuadrado(lado2,dato2);
                        break;
                    case 4:
                        maneja.DelteAll();
                        break;
                    case 5:
                        int lado3;
                        string dato3;
                        Console.WriteLine("ingrese un numero");
                        lado3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese un dato");
                        dato3 = Console.ReadLine();
                        maneja.Area(lado3,dato3);
                        break;
                    case 6:
                        int lado4;
                        string dato4;
                        Console.WriteLine("ingrese un numero");
                        lado4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese un dato");
                        dato4 = Console.ReadLine();
                        maneja.Perimetro(lado4, dato4);
                        break;
                    case 7:
                        Console.ReadKey();
                        break;
                }
            } while (op != 7);
        }
    }
}