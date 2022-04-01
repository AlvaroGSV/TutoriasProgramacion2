using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoyoDDay
{
    class ArregloCuadrados
    {
        Cuadrado cuadrado = new Cuadrado();
        Cuadrado[] arreglo = new Cuadrado[10];

        public bool GuardarCuadrado(int lado, string dato)
        {
            bool seGuardo = false;
            if(dato != null && dato != " ")
            {
                cuadrado=new Cuadrado(lado,dato);
                for(int i = 0; i < arreglo.Length; i++)
                {
                    if (arreglo[i] == null)
                    {
                        arreglo[i] = cuadrado;
                        seGuardo = true;
                        break;
                    }
                }
            }
            return seGuardo;
        }
        public Cuadrado[] getArreglo()
        {
            Cuadrado[] arr = new Cuadrado[arreglo.Length];
            arr = arreglo;
            return arr;
        }
        public bool DeleteAll()
        {
            bool seBoorro = false;
            Cuadrado[] arr = new Cuadrado[arreglo.Length];
            arreglo = arr;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == null)
                {
                    seBoorro = true;
                }
            }
            return seBoorro;
        }
        public bool BorrarCuadrado(int lado, string dato)
        {
            bool seBoorro = false;
            if (dato != null && dato != " ")
            {
                cuadrado = new Cuadrado(lado, dato);
                for (int i = 0; i < arreglo.Length; i++)
                {
                    if (arreglo[i] == cuadrado)
                    {
                        arreglo[i] = null;
                        seBoorro = true;
                        break;
                    }
                }
            }
            return seBoorro;
        }
        public int GetArea(int lado, string dato)
        {
            int area = 0;
            if (dato != null && dato != " ")
            {
                cuadrado = new Cuadrado(lado, dato);
                for (int i = 0; i < arreglo.Length; i++)
                {
                    if (arreglo[i] == cuadrado)
                    {
                        area = (arreglo[i].getLado()) * 4;
                        break;
                    }
                }
            }
            return area;
        }
        public int GetPerimetro(int lado, string dato)
        {
            int perimetro = 0;
            if (dato != null && dato != " ")
            {
                cuadrado = new Cuadrado(lado, dato);
                for (int i = 0; i < arreglo.Length; i++)
                {
                    if (arreglo[i] == cuadrado)
                    {
                        int LadoCuadrado = arreglo[i].getLado();
                        perimetro = LadoCuadrado * LadoCuadrado;
                        break;
                    }
                }
            }
            return perimetro;
        }
    }
}
