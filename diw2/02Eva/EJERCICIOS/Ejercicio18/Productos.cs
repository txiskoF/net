using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio18
{
    [Serializable]
    public class Productos
    {
        string ruta;
        string descripcion;
        decimal precio;

        public Productos(string ruta, string descripcion, decimal precio)
        {
            this.Ruta = ruta;
            this.Descripcion = descripcion;
            this.Precio = precio;
        }

        public string Ruta { get => ruta; set => ruta = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Precio { get => precio; set => precio = value; }
    }

}