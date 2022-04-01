using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutoria2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            claseRandom claseRandom = new claseRandom();
            int[] i = new int[10];//arreglo de 10 atributos
            List<int> randomNum = new List<int>();
            List<string> list = new List<string>();//Lista de string de abecedario
            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            Objeto item = new Objeto();//item de objeto vacio
            Objeto item2 = new Objeto();//item de objeto vacio que se va usar
            Libreta notebook = new Libreta();
            notebook.GetNumPaginas();
            int OpcionMenu = 0;
            do
            {
                double precio;
                string compra;
                Console.WriteLine("1 - Guardar Objeto de compra");
                Console.WriteLine("2 - Ver objeto de compra");
                Console.WriteLine("3 - Cambiar Objeto de compra");
                Console.WriteLine("4 - Ejemplo Foreach en lista");
                Console.WriteLine("5 - Arreglo con numeros random");
                Console.WriteLine("6 - Lista con numeros random");
                Console.WriteLine("7 - Lista con numeros random");
                Console.WriteLine("8 - Salir");
                OpcionMenu = int.Parse(Console.ReadLine());
                switch (OpcionMenu)
                {
                    case 1:
                        Console.WriteLine("ingrese precio");
                        precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese compra");
                        compra = Console.ReadLine();
                        item2 = new Objeto(precio, compra);
                        precio = 0;
                        compra = "";
                        break;
                    case 2:
                        precio = item2.GetPrecio();
                        compra = item2.GetCompra();
                        Console.WriteLine($"El precio de {compra} es $ {precio} MXN");
                        precio = 0;
                        compra = "";
                        break;
                    case 3:
                        precio = item2.GetPrecio();
                        compra = item2.GetCompra();
                        Console.WriteLine($"El precio de {compra} es $ {precio} MXN");
                        precio = 0;
                        compra = "";
                        Console.WriteLine("Ingrese el nuevo precio");
                        precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la nueva compra");
                        compra = Console.ReadLine();
                        item2.SetPecio(precio);
                        item2.SetCompra(compra);
                        precio = item2.GetPrecio();
                        compra = item2.GetCompra();
                        Console.WriteLine($"El precio de {compra} es $ {precio} MXN");
                        break;
                    case 4:
                        foreach(string abc in list)
                        {
                            Console.WriteLine($"La letra {abc}");
                        }
                        break;
                    case 5:
                        int nNum = 0;
                        for (int j = 0; j < 10; j++)
                        {
                            if (j == 0) 
                            {
                                i[j] = rnd.Next(20);
                            }
                            if (j != 0)
                            {
                                for(int k=0; k < j; k++)
                                {
                                    nNum = rnd.Next(20);
                                    if (claseRandom.ValidaNumeroRepetido(i[j], nNum) == false)
                                    {
                                    }
                                    else if (claseRandom.ValidaNumeroRepetido(i[j], nNum) == true)
                                    {
                                        nNum = rnd.Next(20);
                                    }
                                }
                                i[j] = nNum;
                                
                            }
                        }
                        foreach (int num in i)
                        {
                            Console.WriteLine(num);
                        }
                        break;
                    case 6:
                        int neuNum = 0;
                        if (randomNum.Count == 0)
                        {
                            randomNum.Add(rnd.Next(20));
                        }
                        if(randomNum.Count > 0)
                        {
                            do
                            {
                                for (int j = 0; j < randomNum.Count; j++)
                                {
                                    neuNum = rnd.Next(10);
                                    if (randomNum.Contains(neuNum))
                                    {
                                        neuNum = rnd.Next(10);
                                        randomNum.Add(neuNum);
                                    }
                                    else
                                    {
                                        randomNum.Add(neuNum);
                                    }
                                }
                            } while (randomNum.Count != 10);
                            
                        } 
                        
                        foreach (int num in randomNum)
                        {
                            Console.WriteLine(num);
                        }
                    break;
                    case 7:
                        i.DefaultIfEmpty<int>();
                        foreach (int num in randomNum)
                        {
                            Console.WriteLine(num);
                        }
                        break;
                    case 8:
                        Console.WriteLine("Presione cualquier letra para salir");
                        Console.ReadKey();
                    break;
                }
            } while (OpcionMenu != 6);
        }
    }
}
