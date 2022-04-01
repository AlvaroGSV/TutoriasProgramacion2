using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolIdC
{
    class Tabla
    {
        List<objPropiedades> table = new List<objPropiedades>();

        public void neuData(objPropiedades prop)
        {
            table.Add(prop);
        }
        public List<objPropiedades> data()
        {
            return table;
        }

    }
}
