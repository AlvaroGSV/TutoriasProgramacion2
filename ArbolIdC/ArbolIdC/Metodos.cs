using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolIdC
{
	public class ContOp
    {
		string opciones;
		int repeticiones;
		public ContOp(string Op, int Rep)
        {
			opciones = Op;
			repeticiones = Rep;
        }
		public string propOpciones
        {
			get { return opciones; }
			set { opciones = value; }
        }
		public int propRepeticiones
        {
			set { repeticiones = value;}
			get { return repeticiones; }
        }
    }
    class Metodos
    {
		Tabla tabla;
		public Metodos(Tabla table) 
		{
			tabla = table;
		}
		public double log2(double N)
		{
			double logRes = 0;
			logRes = (Math.Log(N) / Math.Log(2));
			return logRes;
		}
		public double EntropiaPorOpcion(int nOpciones, int nTotal)
		{
			double ent = 0, toMultiply=0;
			toMultiply = Convert.ToDouble(nOpciones)/ Convert.ToDouble(nTotal);
			ent = -(toMultiply) * (log2(toMultiply));
			return ent;
		}
		public double EntropiaGlobal(List<int> num, int op)
		{
			double res = 0;
			for (int i = 0; i < num.Count; i++)
			{
				res += EntropiaPorOpcion(num[i], op);
			}
			return res;
		}
		public int nOpcionesDecisiones()
        {
			List<objPropiedades> dataset = tabla.data();
			int op = 0;
			List<string> opciones = new List<string>();
			for(int i=0; i < dataset.Count; i++)
            {
				for (int j = 0; j < dataset.Count; j++)
				{
					if(dataset[i].getDecision() == dataset[j].getDecision())
                    {
                        if (!opciones.Contains(dataset[i].getDecision()))
						{
							opciones.Add(dataset[i].getDecision());
                        }
                    }
				}
			}
			op = opciones.Count;
			return op;
        }
		public List<ContOp> opcionDeDecision()
		{
			List<objPropiedades> dataset = tabla.data();
			string op = "";
			List<ContOp> opciones = new List<ContOp>();
			for (int i = 0; i < dataset.Count; i++)
			{
				for (int j = 0; j < dataset.Count; j++)
				{
					if (dataset[i].getDecision() == dataset[j].getDecision())
					{
                        if (opciones[i].propOpciones != dataset[i].getDecision())
                        {
							ContOp opcion = new ContOp(dataset[i].getDecision(), 1);
							opciones.Add(opcion);
						}
						
					}
					else
					{
						foreach (ContOp opcionAsumar in opciones)
						{
							if (opcionAsumar.propOpciones == dataset[i].getDecision())
							{
								opcionAsumar.propRepeticiones = opcionAsumar.propRepeticiones + 1;
							}
						}
					}
				}
			}
			return opciones;
		}
		public void NeuData(string decision, string prop1, string prop2, string prop3, string prop4)
        {
			decision = decision.ToUpper();
			prop1 = prop1.ToUpper();
			prop2 = prop2.ToUpper();
			prop3 = prop3.ToUpper();
			prop4 = prop4.ToUpper();
			objPropiedades obj = new objPropiedades(decision,prop1,prop2,prop3,prop4);
			tabla.neuData(obj);
        }
		public void printData()
        {
			List<objPropiedades> data = tabla.data();
			for(int i = 0; i<data.Count; i++)
            {
				Console.WriteLine($"{data.ElementAt(i).getProp1()} | {data.ElementAt(i).getProp2()} | {data.ElementAt(i).getProp3()} | {data.ElementAt(i).getProp4()} | {data.ElementAt(i).getDecision()}");
            }
        }
	}
}
