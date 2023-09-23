using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo_DIVISAS_4
{
    public static class Divisas
    {
        public static double convertirMoneda (double moneda, double cambio)
        {
            return moneda * cambio;
        }
    }
}