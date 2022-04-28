using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_Ej_Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triang1 = new Triangulo();
            triang1.pA = 3;
            triang1.pB = 4;
            triang1.pC = 5;

            Console.WriteLine("Perimetro de un Triangulo de Lados  " + triang1.pA + "," + triang1.pB + "," + triang1.pC);
            Console.WriteLine("El Perimetro es :  " + triang1.perimetro());
            Console.ReadKey();




        }
    }
}
