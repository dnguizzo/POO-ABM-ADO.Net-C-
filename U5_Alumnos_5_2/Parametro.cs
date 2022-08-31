using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5_Alumnos_5_2
{
    class Parametro
    {
        public Parametro(string nombre, Object valor)
        {
            Nombre = nombre;
            Valor = valor;
        }
        public string Nombre { get; set; }
        public Object Valor { get; set; }
    }
}
