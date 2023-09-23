using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termometro
{
    public static class Conversor
    {
        public static double convertirC_F(double gradosC)
        {
            return (gradosC * 9 / 5) + 32;

        }
        public static double convertirF_C(double gradosF)
        {
            return (gradosF - 32)*5/9;

        }
    }
}
