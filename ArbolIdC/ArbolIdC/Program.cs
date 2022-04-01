using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolIdC
{
    class Program
    {
		Tabla tabla;
        static void Main(string[] args)
        {
			Program program = new Program();
			program.tabla = new Tabla();
			Metodos met = new Metodos(program.tabla);
			List<int> list = new List<int>();
			int op = 0;
			Console.WriteLine(" !!! ES SOLO PARA UN DATASET CON 4 OPCIONES !!!");
            do 
			{
				Console.WriteLine("   ~~~   MENU   ~~~   ");
				Console.WriteLine("0 ~ Probar la entropia");
				Console.WriteLine("1 ~ Llenar tabla e imprimirla");
				Console.WriteLine("2 ~ Opciones de decisiones en el dataset");
				op = Convert.ToInt32(Console.ReadLine());
				switch (op)
                {
					case 0:
						int n1 = 0;
						int n2 = 0;
						int n3 = 0;
						int nOpciones = 0;
						Console.WriteLine("Ingrese el primer nuemro");
						n1 = int.Parse(Console.ReadLine());
						Console.WriteLine("Ingrese el segundo nuemro");
						n2 = int.Parse(Console.ReadLine());
						Console.WriteLine("Ingrese el tercer nuemro");
						n3 = int.Parse(Console.ReadLine());
						Console.WriteLine("Ingrese el nuemro de opcciones");
						list.Add(n1);
						list.Add(n2);
						list.Add(n3);
						nOpciones = int.Parse(Console.ReadLine());
						Console.WriteLine("EL resultado es " + met.EntropiaGlobal(list, nOpciones));
						Console.ReadKey();
						break;
					case 1:
						met.NeuData("Cinema","Rainy","YES","YES","HOT");
						met.NeuData("Tennis", "Rainy", "NO", "NO", "COOL");
						met.NeuData("Cinema", "Windy", "YES", "NO", "NORMAL");
						met.NeuData("Cinema", "Windy", "NO", "YES", "HOT");
						met.NeuData("Stay in", "Cloudy", "no", "no", "HOT");
						met.NeuData("Tennis", "Cloudy", "YES", "YES", "normal");
						met.NeuData("cinema", "cloudy", "yes", "no", "normal");
						met.NeuData("tennis", "rainy", "yes", "no", "normal");
						met.NeuData("Stay in", "windy", "no", "no", "cool");
						met.NeuData("cinema", "windy", "yes", "yes", "cool");
						met.printData();
						break;
					case 2:
						List<ContOp> aImprimir = met.opcionDeDecision();
						foreach(ContOp opc in aImprimir)
                        {
							Console.WriteLine($"{opc.propOpciones} | {opc.propRepeticiones}");
                        }
						Console.WriteLine(met.nOpcionesDecisiones());
						break;
                }
			}
			while (op!=3);
			
		}
    }
}
