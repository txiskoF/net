using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    public static class Calculadora
    {
        public static float calcularIMC(byte peso,float altura) {
            return (peso / ((altura / 100) * (altura / 100)));
        }
        public static float calcularI(byte peso) {
            return (peso / 3);
        }
        public static float calcularP(byte peso) {
            return ((15 * peso) / 100);
        }
        public static float calcularAM(float altura1,float altura2,string sexo)
        {
            float altura = (altura1 + altura2) / 2;
            if (sexo=="niño")
            {
                altura += 6.5F;
            }else
            {
                altura -= 6.5F;
            }
            return altura;
        }
    }
}
