using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoo_de_tutoria_D1
{
    public class Objeto
    {
        int NumObjeto;
        string StrObjeto;

        public Objeto() { }

        public Objeto(int numObjeto, string strObjeto) 
        {
            NumObjeto = numObjeto;
            StrObjeto = strObjeto;
        }
         
        public int getNumObjeto()
        {
            return NumObjeto;
        }
        public void setNumObjeto(int num)
        {
            NumObjeto=num;
        }
        public string getStringObjeto()
        {
            return StrObjeto;
        }
        public void setStringObjeto(string str)
        {
            StrObjeto = str;
        }
    }
}
