using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace Obrero
{
    public static class Empleado
    {
        public static int CalcularRetencion(int dinero, int retencion)
        {
            return (dinero * (retencion/100));

        }

        public static double CalcularSalarioNeto(int dinero, int retencion, int horasExtras, int guardias)
        {
            double ret = (retencion / 100);
            int hE = horasExtras * 30;
            int guar = guardias * 30;
            return (dinero - ret) + hE + guar;
        }

        public static double calculaPesetas(double sueldo)
        {
            return sueldo / 166.386;
        }

    }
}
