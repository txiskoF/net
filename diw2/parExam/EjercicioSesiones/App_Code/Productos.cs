using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Productos
/// </summary>
[Serializable]
public class Productos
{
    string ruta;
    string descripcion;
    decimal precio;
    public Productos()
    {
       
    }

    public Productos(string ruta, string descripcion, decimal precio)
    {
        this.Ruta = ruta;
        this.Descripcion = descripcion;
        this.Precio = precio;
    }

    public string Ruta
    {
        get
        {
            return ruta;
        }

        set
        {
            ruta = value;
        }
    }

    public string Descripcion
    {
        get
        {
            return descripcion;
        }

        set
        {
            descripcion = value;
        }
    }

    public decimal Precio
    {
        get
        {
            return precio;
        }

        set
        {
            precio = value;
        }
    }
}