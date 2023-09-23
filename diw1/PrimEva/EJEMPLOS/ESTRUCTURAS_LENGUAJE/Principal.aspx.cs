using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ESTRUCTURAS_LENGUAJE
{
    public partial class Principal : System.Web.UI.Page
    {
       
        protected void BtnIF_Click(object sender, EventArgs e)
        {
            bool valido=true;
            string a = "";

            //Condicional sencilla 
            if (valido)
            {
                Response.Write("VALIDO");
                a = "valido";
            }

            //Condicional Sencilla (Not)

            if (!valido)
            {
                Response.Write(" NO VALIDO");
                a = "no valido";
            }

            //Condicional con parte then y parte else
            if (valido)
            {
                Response.Write("VALIDO");
                a = "valido";
            }
            else
            {
                Response.Write("NO VALIDO");
                a = "no valido";
            }

            //Operador Condicional Ternario ? :
            a = valido ? "valido" : "no valido";
        }

        protected void BtnSwitch_Click(object sender, EventArgs e)
        {
            //Condicional Múltiple : Switch
            string sentencia = "";
            switch (TxtPalabra.Text.ToUpper())
            {
                case "IF":
                    sentencia = "condicional";
                    break;
                case "SWITCH":
                    sentencia = "condicional múltiple";
                    break;
                case "FOR":
                    sentencia = "repetitiva";
                    break;
                case "FOREACH":
                    sentencia = "repetitiva-estructuras";
                    break;
                default:
                    sentencia = "otra";
                    break;
            }
            LblSentencia.Text = sentencia;
        }

        protected void BtnFOR_Click(object sender, EventArgs e)
        {
            //Sentencia repetitiva FOR (sabemos el número de veces a recorrer)
            string[] palabras = { "IF", "SWITCH", "FOR", "FOREACH" };
           
            LblSentencia.Text = "Las palabras reservadas son: <BR/>";
            for (int i = 0; i < palabras.Length; i++)
            {
                LblSentencia.Text += palabras[i] + "<BR/>";
            }
        }

        protected void BtnForeach_Click(object sender, EventArgs e)
        {
            //Sentencia repetitiva FOREACH (Para recorrer estructuras)
            string[] palabras = { "IF", "SWITCH", "FOR", "FOREACH" };

            LblSentencia.Text = "Las palabras reservadas son: <BR/>";
            foreach (string elemento in palabras)
            {
                LblSentencia.Text += elemento + "<BR/>";
            }
        }

        protected void BtnWhile_Click(object sender, EventArgs e)
        {
            //Repetitiva de 0 a N veces
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int i = 0;
            while (i<=9)
            {
                LblNumeros.Text += numeros[i] + "<BR/>";
                i++;
            }

        }

        protected void BtnDoWhile_Click(object sender, EventArgs e)
        {
            // repetitiva de 1 a N veces
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int i = 0;
            do
            {
                LblNumeros.Text += numeros[i] + "<BR/>";
                i++;
            } while (i <= 9);
        }

       
    }
}