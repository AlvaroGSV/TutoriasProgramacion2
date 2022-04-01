using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_U1_prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            ArregloMotos arreglo = new ArregloMotos();
            int op = 0;
            do 
            {
                Console.WriteLine("      ");
                Console.WriteLine("Menu");
                Console.WriteLine("1 - LLenado");
                Console.WriteLine("2 - Buscar duplicados");
                Console.WriteLine("3 - Buscar por ID");
                Console.WriteLine("4 - Cambiar marca");
                Console.WriteLine("5 - salir");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        arreglo.llenado();
                        break;
                    case 2:
                        int nDUplicados = arreglo.NumMotosDuplicadas();
                        string[] arr = new string[nDUplicados];
                        arr = arreglo.MotosDuplicadas();
                        for(int i = 0; i < arr.Length; i++)
                        {
                            if(arr[i] != null)
                            {
                                Console.WriteLine(arr[i]);
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el id que ocupa buscar");
                        int idABuscar = 0;
                        idABuscar = int.Parse(Console.ReadLine());
                        int PosicionMoto = arreglo.BuscarIdMoto(idABuscar);
                        if(PosicionMoto != -1)
                        {
                            Console.WriteLine($"La moto se encuentra en {PosicionMoto}");
                        }
                        else
                        {
                            Console.WriteLine("La moto no existe");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el id que ocupa buscar");
                        int idUsuario = 0;
                        idUsuario = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la nueva marca");
                        string marcaUsuario = "";
                        marcaUsuario = Console.ReadLine();
                        bool res = arreglo.UpdateBrandMoto(idUsuario, marcaUsuario);
                        if (res == true)
                        {
                            Console.WriteLine("Se cambio con exito");
                        }
                        else
                        {
                            Console.WriteLine("No se cambio ni papa");
                        }
                        break;
                    case 5:
                        Console.ReadKey();
                        break;
                }
            }
            while (op != 5);
        }
    }
}
