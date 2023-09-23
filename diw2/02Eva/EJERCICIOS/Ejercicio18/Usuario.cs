﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio18
{
    [Serializable]
    public class  Usuario
    {
        String Nombre;
        String Contraseña;

        public Usuario()
        {
        }
        public Usuario(string nombre, string contraseña)
        {
            Nombre = nombre;
            Contraseña = contraseña;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }
    }
}