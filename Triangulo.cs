using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_Ej_Triangulo
{
    class Triangulo
    {
        //Atributos
        private int a, b, c;

        //Propiedades
        public int pA
        {
            set { a = value; }
            get { return a; }

        }
        public int pB

        {
            set { b = value; }
            get { return b; }
        }
        public int pC
        {
            set { c = value; }
            get { return c; }

        }

        //Métodos Constructor

        public  Triangulo()
        {
            
        }


        //Métodos de control

        public int perimetro()
        { int per = (a+b+c);
            return per;
        }

    }
}