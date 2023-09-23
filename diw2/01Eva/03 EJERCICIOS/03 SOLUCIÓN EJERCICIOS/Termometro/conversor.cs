using System;
using System.Collections.Generic;
using System.Text;

namespace Termometro
{
    public static class conversor
    {
        public static double convertiraF(double gradosC)
        {
            return (gradosC * 9 / 5) + 32;

        }
        public static double convertiraC(double gradosF)
        {
            return (gradosF - 32) * 5 / 9;

        }
    }
}
