using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo_Clases
{

    // Marcamos la Clase como Serializable si queremos guardar un objeto de 
    //esta clase en una variable ViewState.
    [Serializable] 
    public class Empleado
    {
        //Propiedades (si no se pone nada en el ámbito es private)
        string nombre;
        string puesto;
        DateTime fechaContrato;

        //Constructores (Se hace con Botón derecho y Refactorizar)
        #region CONSTRUCTORES
        public Empleado()
        {
        }

        public Empleado(string nombre, string puesto, DateTime fechaContrato)
        {
            this.nombre = nombre;
            this.puesto = puesto;
            this.fechaContrato = fechaContrato;
        }
        #endregion

        //Métodos (Los construyes a medida)
        #region Metodos

        //Sobrecargas del método Mostrar (POLIFORMISMO) 
        //El nombre del método es el mismo, pero el número de los
        //parámetros varia o si usan el mismo número de parámetros
        //el tipo de los ellos varía.
        public string Mostrar()
        {
            return (nombre + "<BR>" + nombre + "<BR>" + puesto);

        }
        public string Mostrar(string nom)
        {
            return (nom);
        }
        public string Mostrar(string nom, string especialidad)
        {
            return (nom + "<BR>" + especialidad);
        }

        //Sobreescribir Métodos : se usa la palabra reservada override 
        //entre el ámbito y el tipo de datos a devolver.

        public override string ToString()
        {
            return ("<BR>" + nombre + "<BR>" + puesto);
        }


        #endregion
        //Encapsulación (Se hace con Botón derecho y Refactorizar)
        #region ENCAPSULACION
        public string Nombre { get => nombre; set => nombre = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public DateTime FechaContrato { get => fechaContrato; set => fechaContrato = value; }
        #endregion
    }
}