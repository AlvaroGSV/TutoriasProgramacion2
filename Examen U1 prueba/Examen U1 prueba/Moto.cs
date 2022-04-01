using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_U1_prueba
{
    public class Moto
    {
        private int ID;
        private string Marca;
        private double Precio, Kilometraje;
        public Moto (int id)
        {
            this.ID = id;
        }
        public Moto(int id, string marca, double kilometraje, double precio)
        {
            this.ID = id;
            this.Marca = marca;
            this.Precio = precio;
            this.Kilometraje = kilometraje;
        }
        public int getId()
        {
            return ID;
        }
        public double propiedadKilometraje
        {
            get
            {
                return Kilometraje;
            }
            set
            {
                Kilometraje = value;
            }
        }
        public double propiedadPrecio
        {
            get
            {
                return Precio;
            }
            set
            {
                Precio = value;
            }
        }
        public string propiedadMarca
        {
            get
            {
                return Marca;
            }
            set
            {
                Marca = value;
            }
        }
    }
}
