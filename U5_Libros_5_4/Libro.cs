using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5_Libros_5_4
{
    class Libro
    {
        private int codigo;
        public int pCodigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string titulo;
        public string pTitulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        private string genero;
        public string pGenero
        {
            get { return genero; }
            set { genero = value; }
        }
        private double importe;
        public double pImporte
        {
            get { return importe; }
            set { importe = value; }
        }


        private int formato;
        public int pFormato
        {
            get { return formato; }
            set { formato = value; }
        }
        public Libro()
        {
            codigo = formato = 0;
            genero = titulo = "";
            importe = 0;
        }
        public Libro(int codigo, string titulo, string genero, double importe, int formato)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.genero = genero;
            this.importe = importe;
            this.formato = formato;
        }
        override public string ToString()
        {
            string format;
            if (formato == 1)
            { format = "I"; }
            else
            { format = "D"; }
            return " " + codigo.ToString() + " ," + titulo + " ," + genero.ToString() + "," + format.ToString();
        }
    }
}
