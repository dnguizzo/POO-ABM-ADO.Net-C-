using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace U5_Alumnos_5_2
{
    class Alumno
    {
        private string apellido, nombres, calle;
        private int tipoDocumento, documento, sexo, cantidad, numero,carrera;
        private bool actividad, casado, hijos;
        private DateTime fechaNacimiento;
        public Alumno()
        {
            apellido = nombres  = calle = string.Empty;
            tipoDocumento = documento = cantidad = numero = sexo = carrera = 0;
            actividad = casado = hijos = false;
            fechaNacimiento = DateTime.Now;
        }

        public Alumno(string apellido, string nombres, DateTime fechaNacimiento, int sexo, int tipoDocumento,
                       int documento, string calle, int numero, bool actividad, bool casado, bool hijos, int cantidad, int carrera)
        {
            this.apellido = apellido;
            this.nombres = nombres;
            this.fechaNacimiento = fechaNacimiento;
            this.sexo = sexo;
            this.tipoDocumento = tipoDocumento;
            this.documento = documento;
            this.calle = calle;
            this.numero = numero;
            this.actividad = actividad;
            this.casado = casado;
            this.hijos = hijos;
            this.cantidad = cantidad;
            this.carrera = carrera;
        }

        public string pApellido
        {
            set { apellido = value; }
            get { return apellido; }
        }

        public string pNombres
        {
            set { nombres = value; }
            get { return nombres; }
        }

        public int pTipoDocumento
        {
            set { tipoDocumento = value; }
            get { return tipoDocumento; }
        }

        public int pDocumento
        {
            set { documento = value; }
            get { return documento; }
        }

        public DateTime pFechaNacimiento
        {
            set { fechaNacimiento = value; }
            get { return fechaNacimiento; }
        }

        public int pSexo
        {
            set { sexo = value; }
            get { return sexo; }
        }

        public string pCalle
        {
            set { calle = value; }
            get { return calle; }
        }

        public int pNumero
        {
            set { numero = value; }
            get { return numero; }
        }


        public int pCantidad
        {
            set { cantidad = value; }
            get { return cantidad; }
        }


        public int pCarrera
        {
            set { cantidad = value; }
            get { return cantidad; }
        }


        public bool pActividad
        {
            set { actividad = value; }
            get { return actividad; }
        }


        public bool pCasado
        {
            set { casado = value; }
            get { return casado; }
        }


        public bool pHijos
        {
            set { hijos = value; }
            get { return hijos; }
        }
        override public string ToString()
        {
           string sexoStr = sexo == 1 ? "M" : "F"; // operador ternario
           // return apellido + ", " + nombres + "," + carrera + "(" + sexoStr + ")";

            return $" {apellido} , {nombres} , {carrera} , {sexoStr}"; // Interpolación de string
        }

    }
}
