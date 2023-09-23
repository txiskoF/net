using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solucion_Ejercicio_16
{
    public class Empresa
    {
        #region Constructor
        public Empresa()
        {
        }
        #endregion
        private string identificativo;
        string nombre;
        DateTime fechaNacimiento;
        DateTime fechaContrato;
        double empleo;
        double cotizacion;

        #region Encapsulacion
        public string Identificativo { get => identificativo; set => identificativo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public DateTime FechaContrato { get => fechaContrato; set => fechaContrato = value; }
        public double Empleo { get => empleo; set => empleo = value; }
        public double Cotizacion { get => cotizacion; set => cotizacion = value; }
        #endregion


        #region Métodos
        public int calcularAnios(DateTime fecha)
        {
            int diferencia = DateTime.Now.Year - fecha.Year;
            if (fecha.AddYears(diferencia)>DateTime.Now)
            {
                diferencia--;
            }
            return diferencia;
        }

        public double salarioMensual()
        {
            double total = empleo - cotizacion;
            double totalSalarioMensual = total - (total * 0.24);
            return totalSalarioMensual;
        }

        public double calcularPagasExtras()
        {
            double paga = empleo - (empleo * 0.24);
            return paga;

        }

        public double calcularSalarioNeto()
        {
            return salarioMensual() * 12 + calcularPagasExtras() * 2;
        }

        #endregion

    }
}
