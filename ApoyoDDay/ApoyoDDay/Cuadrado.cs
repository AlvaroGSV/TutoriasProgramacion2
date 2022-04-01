using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoyoDDay
{
    public class Cuadrado
    {
        int Lado;
        string Dato;
        public Cuadrado() { }
        public Cuadrado(int lado,string dato)
        {
            Lado = lado;
            Dato = dato;
        }
        public int getLado()
        {
            return Lado;
        }
        public string getDato()
        {
            return Dato;
        }
        public void setLado(int lado)
        {
            Lado = lado;
        }
        public void setDato(string dato)
        {
            Dato = dato;
        }
    }
}
