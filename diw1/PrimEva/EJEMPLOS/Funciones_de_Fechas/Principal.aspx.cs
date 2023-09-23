using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Funciones_de_Fechas
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // DateTime fechancto = new DateTime(1971, 12, 10);
            DateTime fechancto = new DateTime(1971, 12, 10, 19, 30, 45);

            Response.Write("Fecha y Hora del Sistema " + DateTime.Now + "<BR/>");
            Response.Write("Fecha del Sistema " + DateTime.Today.ToShortDateString()+ "<BR/>");
            Response.Write("Hora del Sistema " + DateTime.Now.TimeOfDay + "<BR/>");
            Response.Write("FechaSistema:" + DateTime.Today.ToLongDateString() + "<BR/>");
            Response.Write("Fecha y hora dada " + fechancto.ToLongDateString() + "<BR/>");
            Response.Write("Fecha dada " + fechancto.Date  + "<BR/>");
            Response.Write("Hora dada " + fechancto.TimeOfDay  + "<BR/>");

            Response.Write("Día de la fecha dada " + fechancto.Date.Day + "<BR/>");
            Response.Write("Mes de la fecha dada " + fechancto.Date.Month + "<BR/>");
            Response.Write("Año de la fecha dada " + fechancto.Date.Year + "<BR/>");
            Response.Write("Día de la semana de la fecha dada " + fechancto.Date.DayOfWeek + "<BR/>");
            Response.Write("Día del año de la fecha dada " + fechancto.Date.DayOfYear + "<BR/>");
            Response.Write("Hora de la hora dada " + fechancto.TimeOfDay.Hours + "<BR/>");
            Response.Write("Minutos de la hora dada " + fechancto.TimeOfDay.Minutes + "<BR/>");
            Response.Write("Segundos de la hora dada " + fechancto.TimeOfDay.Seconds + "<BR/>");
            Response.Write("Milisegundos de la hora dada " + fechancto.TimeOfDay.Milliseconds + "<BR/>");
            Response.Write("Ticks de la hora dada " + fechancto.TimeOfDay.Ticks + "<BR/>");

            Response.Write("Convertida a Formato Largo: " + fechancto.ToLongDateString());
            Response.Write("Convertida a Formato Corto: " + fechancto.ToShortDateString());

            Response.Write("Convertida a Formato Largo: " + fechancto.ToLongTimeString());
            Response.Write("Convertida a Formato Corto: " + fechancto.ToShortTimeString());

            Response.Write("SUMAS DE FECHAS:  <BR/>");
            Response.Write("Sumando Días: " + fechancto + 3 + "<BR/>");
            Response.Write("Sumando Días: " + fechancto.AddDays(3) + "<BR/>");
            Response.Write("Sumando Meses: " + fechancto.AddMonths(3) + "<BR/>");
            Response.Write("Sumando Años: " + fechancto.AddYears(3) + "<BR/>");
            Response.Write("Sumando Horas: " + fechancto.AddHours(3) + "<BR/>");
            Response.Write("Sumando Minutos: " + fechancto.AddMinutes(3) + "<BR/>");
            Response.Write("Sumando Segundos: " + fechancto.AddSeconds(3) + "<BR/>");
            Response.Write("Sumando Milisegundos: " + fechancto.AddMilliseconds(3) + "<BR/>");
            Response.Write("Sumando Ticks: " + fechancto.AddTicks(3) + "<BR/>");

            //// TimeSpan (dias,horas,minutos,segundos)
            TimeSpan intervalo = new TimeSpan(3, 4, 5, 6);
            Response.Write("Sumando Intervalo de 3 dias, 4 horas,5 minutos y 6 segundos: " + fechancto.Add(intervalo) + "<BR/>");
            ////Subtract devuelve un intervalo de tiempo(Timespan:dias,horas,minutos,segundos) 
            Response.Write("Diferencia de Fechas- INTERVALO:" + DateTime.Now.Subtract(fechancto) + "<BR/>");
            Response.Write("Diferencia de Fechas - DIAS: " + DateTime.Now.Subtract(fechancto).Days + "<BR/>");
            Response.Write("Diferencia de Fechas - HORAS: " + DateTime.Now.Subtract(fechancto).Hours + "<BR/>");
            Response.Write("Diferencia de Fechas - MINUTOS: " + DateTime.Now.Subtract(fechancto).Minutes + "<BR/>");
            Response.Write("Diferencia de Fechas - SEGUNDOS: " + DateTime.Now.Subtract(fechancto).Seconds + "<BR/>");
            Response.Write("Diferencia de Fechas- MILISEGUNDOS: " + DateTime.Now.Subtract(fechancto).Milliseconds + "<BR/>");
            Response.Write("Diferencia de Fechas- TOTAL de SEGUNDOS: " + DateTime.Now.Subtract(fechancto).TotalSeconds + "<BR/>");
            Response.Write("Diferencia de Fechas- TOTAL de TICKS: " + DateTime.Now.Subtract(fechancto).Ticks + "<BR/>");
            //Calcular la edad
            int edad = DateTime.Today.AddTicks(-fechancto.Ticks).Year - 1;
            Response.Write(edad + "<BR/>"); 


            //COmpareTo
            Response.Write("COMPARACIÓN FECHA ACTUAL-NACIMIENTO: " + DateTime.Now.CompareTo(fechancto) + "<BR/>");
            Response.Write("COMPARACIÓN NACIMIENTO-FECHA ACTUAL: " + fechancto.CompareTo(DateTime.Now) + "<BR/>");

            ////Equals
            Response.Write("COMPARACIÓN FECHA ACTUAL-NACIMIENTO: " + DateTime.Now.Equals(fechancto) + "<BR/>");
            Response.Write("COMPARACIÓN NACIMIENTO-FECHA ACTUAL: " + fechancto.Equals(DateTime.Now) + "<BR/>");

        }
    }
}