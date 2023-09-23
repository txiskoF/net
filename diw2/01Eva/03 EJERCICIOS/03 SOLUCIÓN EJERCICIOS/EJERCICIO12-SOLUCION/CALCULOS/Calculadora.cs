using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULOS
{
    public static class Calculadora
    {
        public static string convertirDecimalaBase(int numero, int baseNum)
        {
            string resto = "", resultado = "";

            do
            {
                resto = (numero % baseNum).ToString();
                if (baseNum == 16)
                {
                    switch (resto)
                    {
                        case "10":
                            resto = "A";
                            break;
                        case "11":
                            resto = "B";
                            break;
                        case "12":
                            resto = "C";
                            break;
                        case "13":
                            resto = "D";
                            break;
                        case "14":
                            resto = "E";
                            break;
                        case "15":
                            resto = "F";
                            break;
                    }

                }
                resultado = resto + resultado;
                numero = (numero / baseNum);

            } while (numero != 0);



            return resultado;
        }

        public static long convertirBaseaDecimal(string numero, int baseNum)
        {
            int posicion = numero.Length - 1;
            string digito;
            long resultado = 0;
            for (int i = 0; i < numero.Length; i++)
            {
                digito = numero.Substring(i, 1);
                if (baseNum == 16)
                {
                    switch (digito)
                    {
                        case "A":
                            digito = "10";
                            break;
                        case "B":
                            digito = "11";
                            break;
                        case "C":
                            digito = "12";
                            break;
                        case "D":
                            digito = "13";
                            break;
                        case "E":
                            digito = "14";
                            break;
                        case "F":
                            digito = "15";
                            break;
                    }

                }
                resultado += Convert.ToInt32(digito) * Convert.ToInt64(Math.Pow(baseNum, posicion));
                posicion--;
            }

            return resultado;
        }
    }
}
