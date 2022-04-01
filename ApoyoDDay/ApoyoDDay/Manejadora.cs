using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoyoDDay
{
    class Manejadora
    {
        ArregloCuadrados arreglo;

        public Manejadora(ArregloCuadrados arregloCuadrados)
        {
            arreglo = arregloCuadrados;
        }
        public void GuardarCuadrado(int lado, string dato)
        {
            bool respuesta = arreglo.GuardarCuadrado(lado, dato);
            if(respuesta == true)
            {
                Console.WriteLine("Se guardo con exito");
            }
            else
            {
                Console.WriteLine("No se guardo");
            }
        }
        public void ImprimirCuadrado()
        {
            Cuadrado[] arr = arreglo.getArreglo();
            foreach(Cuadrado cuadrado in arr)
            {
                if (cuadrado.getDato()!=null)
                {
                    Console.WriteLine($"El cuadro mide {cuadrado.getLado()} y gurda el dato de {cuadrado.getDato()}");
                }
            }
        }
        public void DelteAll()
        {
            bool respuesta = arreglo.DeleteAll();
            if (respuesta == true)
            {
                Console.WriteLine("Se borro con exito");
            }
            else
            {
                Console.WriteLine("No se borro");
            }
        }
        public void BorrarCuadrado(int lado, string dato)
        {
            bool respuesta = arreglo.BorrarCuadrado(lado, dato);
            if (respuesta == true)
            {
                Console.WriteLine("Se borro con exito");
            }
            else
            {
                Console.WriteLine("No se borro");
            }
        }
        public void Area(int lado, string dato)
        {
            int area = arreglo.GetArea(lado, dato);
            Console.WriteLine($"El area del cuadro es {area}");
        }
        public void Perimetro(int lado, string dato)
        {
            int perimetro = arreglo.GetPerimetro(lado, dato);
            Console.WriteLine($"El perimetro del cuadro es {perimetro}");
        }
    }
}
