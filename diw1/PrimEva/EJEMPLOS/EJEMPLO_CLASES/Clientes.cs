using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo_Clases
{
    public class Clientes
    {
        string nombre;
        string apellido;

        #region Constructor
        public Clientes()
        {
        }

        public Clientes(string nombre)
        {
            this.nombre = nombre;
        }

        public Clientes(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

#endregion
        #region Encupsalucion
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        #endregion

        #region Metodo
        public string Mostrar()
        {
            return (Nombre + "-" + Apellido);
        }
        #endregion
    }
}