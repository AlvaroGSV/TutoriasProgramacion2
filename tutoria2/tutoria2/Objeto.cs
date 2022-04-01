using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutoria2
{
    public class Objeto
    {
        double precio;
        string compra;
        public Objeto() { }
        public Objeto(double precio, string compra) 
        {
            this.compra = compra;
            this.precio = precio;
        }
        public double GetPrecio()
        {
            return precio;
        }
        public void SetPecio(double Precio) 
        {
            this.precio = Precio;
        }
        public string GetCompra()
        {
            return compra;
        }
        public void SetCompra(string Compra)
        {
            this.compra = Compra;
        }
    }
}
