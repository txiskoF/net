using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public static class PORTES
    {
        public static double Calculo_Portes(String poblacion, double importe) {
            double portes = 0;

            switch (poblacion.ToLower())
            {
                case "bilbao":
                    portes = importe + 2;
                    break;

                case "etxebarri":
                    portes = importe + 3.50;
                    break;

                case "basauri":
                    portes = importe + 3.75;
                    break;

                case "arrigorriaga":
                    portes = importe + 3.75;
                    break;

                default:
                    portes = -1;
                    break;
            }


            return portes;
        }

        public static double Restar_Portes(String poblacion, double importe)
        {
            double portes = 0;

            switch (poblacion.ToLower())
            {
                case "bilbao":
                    portes = importe - 2;
                    break;

                case "etxebarri":
                    portes = importe - 3.50;
                    break;

                case "basauri":
                    portes = importe - 3.75;
                    break;

                case "arrigorriaga":
                    portes = importe - 3.75;
                    break;

                default:
                    portes = -1;
                    break;
            }


            return portes;
        }

    }
}
