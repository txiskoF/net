using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EJEMPLO_VIEWSTATES
{
    [Serializable]
    public class Alumno
    {
        int numero;
        string nombre;
        DateTime fechaNacimiento;

        public Alumno(int numero, string nombre)
        {
            this.numero = numero;
            this.nombre = nombre;
        }

        public Alumno(int numero, string nombre, DateTime fechaNacimiento)
        {
            this.numero = numero;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public int Numero { get => numero; set => numero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    }
}