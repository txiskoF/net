using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio16
{
    public class Empleado
    {
        int id;
        string nombre;
        DateTime fechaNacimiento;
        DateTime fechaContrato;
        string empleo;
        double baseCotizacion;

        public Empleado()
        {
        }

        #region Encapsulacion
        public double Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public DateTime FechaContrato { get => fechaContrato; set => fechaContrato = value; }
        public string Empleo { get => empleo; set => empleo = value; }
        public double BaseCotizacion { get => baseCotizacion; set => baseCotizacion = value; }
        #endregion

        /*
         public static string Age(DateTime birthday)
{
    DateTime now = DateTime.Today;
    int age = now.Year - birthday.Year;
    if (now &lt; birthday.AddYears(age)) age--;
 
    return age.ToString();
}* 
         */

        public int calcularAnios(DateTime FechaNacimiento)
        {
            int edad = DateTime.Today.AddTicks(-FechaNacimiento.Ticks).Year - 1;

        }

        public double calSalMens()
        {

        }

        public double calPagExtras()
        {

        }

        public double calSalNeto()
        {

        }
    }
}