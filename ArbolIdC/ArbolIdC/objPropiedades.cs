using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolIdC
{
    public class objPropiedades
    {
        string prop1;
        string prop2;
        string prop3; 
        string prop4;
        string decision;

        public objPropiedades() { }

        public objPropiedades(string Decision, string Prop1, string Prop2, string Prop3, string Prop4)
        {
            decision = Decision;
            prop1 = Prop1;
            prop2 = Prop2;
            prop3 = Prop3;
            prop4 = Prop4;
        }

        public string getDecision()
        {
            return decision;
        }
        public void setDecision(string prop)
        {
            decision = prop;
        }

        public string getProp1()
        {
            return prop1;
        }
        public void setProp1(string prop)
        {
            prop1 = prop;
        }

        public string getProp2()
        {
            return prop2;
        }
        public void setProp2(string prop)
        {
            prop2 = prop;
        }

        public string getProp3()
        {
            return prop3;
        }
        public void setProp3(string prop)
        {
            prop3 = prop;
        }

        public string getProp4()
        {
            return prop4;
        }
        public void setProp4(string prop)
        {
            prop4 = prop;
        }
    }
}
