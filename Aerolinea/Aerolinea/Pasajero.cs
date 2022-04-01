using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea
{
    class Pasajero
    {
        string primerNombre, segundoNombre;
        string primerApellido, segundoApellido;
        string nacionalidad;
        int edad;
        string telefono, correoElectronio;
        public Pasajero() { }
        public Pasajero(string PrimerNombre,string SegundoNombre,
            string PrimerApellido,string SegundoApellido,
            string Nacionalidad,int Edad, string Telefono,string CorreoElectronio)
        {
            primerApellido = PrimerApellido;
            segundoApellido = SegundoApellido;
            primerNombre = PrimerNombre;
            segundoNombre = SegundoNombre;
            nacionalidad = Nacionalidad;
            edad = Edad;
            telefono = Telefono;
            correoElectronio = CorreoElectronio;
        }
        public string propPrimerApellido
        {
            get { return primerApellido; }
            set { primerApellido = value;}
        }
        public string propSegundoApellido
        {
            get { return segundoApellido;}
            set { segundoApellido = value;}
        }
        public string propPrimerNombre
        {
            get { return primerNombre; }
            set { primerNombre = value;}
        }
        public string propSegundoNombre
        {
            get { return segundoNombre; }
            set { segundoNombre = value; }
        }
        public string propNacionalidad
        {
            get { return nacionalidad;}
            set { nacionalidad = value; }
        }
        public int propEdad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string propTel
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string propEmail
        {
            get { return correoElectronio; }
            set { correoElectronio = value; }
        }
    }
}
