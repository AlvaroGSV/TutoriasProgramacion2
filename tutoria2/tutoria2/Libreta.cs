using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutoria2
{
    public class Libreta
    {
        int NumeroDePaginas;
        string Marca;
        bool TipoDePasta;
        double Precio;
        public Libreta() { }
        public Libreta(int numPaginas, double precio)
        {
            NumeroDePaginas = numPaginas;
            Precio=precio;
        }
        public Libreta(int numPaginas, double precio, string marca)
        {
            NumeroDePaginas = numPaginas;
            Precio = precio;
            Marca = marca;
        }
        public Libreta(int numPaginas, double precio, string marca, bool pasta)
        {
            NumeroDePaginas = numPaginas;
            Precio = precio;
            Marca = marca;
            TipoDePasta=pasta;
        }
        public int GetNumPaginas()
        {
            return NumeroDePaginas;
        }
        public void SetNumPaginas(int nPag)
        {
            NumeroDePaginas = nPag;
        }
        public double GetPrecio()
        {
            return Precio;
        }
        public void SetPrecio(double precio)
        {
            Precio = precio;
        }
    }
}
