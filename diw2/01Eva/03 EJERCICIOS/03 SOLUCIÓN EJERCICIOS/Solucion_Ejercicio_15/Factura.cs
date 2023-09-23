using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solucion_Ejercicio_17
{
    public class Factura
    {
        string codigo;
        DateTime fecha;
        double importe;

        #region Constructores
        public Factura()
        {

        }

        public Factura(string codigo, DateTime fecha, double importe)
        {
            this.codigo = codigo;
            this.fecha = fecha;
            this.importe = importe;
        }

        #endregion

        #region Encapsulación
        public string Codigo { get => codigo; set => codigo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double Importe { get => importe; set => importe = value; }
        #endregion
        #region Métodos
        public double calcularImporte()
        {
            //double importeConIva = (importe * 0.21) + importe;
            //return importeConIva
            return importe*1.21;
        }

        public double calcularPorcentaje(int porcentaje)
        {
            double importeT = importe * 1.21;
            double porciento = (importeT * porcentaje) / 100;
            return porciento;
        }

        public double[] calcularPorcentaje()
        {
            double[] resultado = new double[3];
            double importeT = importe * 1.21;
            resultado[0] = importe * 0.5;
            resultado[1] = importe * 0.3;
            resultado[2] = importe * 0.2;
            return resultado;
        }
        public DateTime calcularFecha(int dias)
        {

            //DateTime fechaHoy = new DateTime();
            DateTime fecha = this.fecha.AddDays(dias);
            return fecha;

        }

        public DateTime[] calcularFecha()
        {
            DateTime[] fechasPago = new DateTime[] { fecha.AddDays(30), fecha.AddDays(60), fecha.AddDays(90) };
            return fechasPago;
        }
        #endregion
    }
}
