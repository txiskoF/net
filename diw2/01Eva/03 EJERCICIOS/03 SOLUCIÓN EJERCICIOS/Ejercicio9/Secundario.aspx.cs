using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio9
{
    public partial class Secundario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RdbNivel1_CheckedChanged(object sender, EventArgs e)
        {
            string nivel1, nivel2, nivel3;
            nivel1 = "ON";
            nivel2 = "OFF";
            nivel3 = "OFF";
            Escribir
        }

        protected void RdbNivel2_CheckedChanged(object sender, EventArgs e)
        {
            string nivel1, nivel2, nivel3;
            nivel1 = "OFF";
            nivel2 = "ON";
            nivel3 = "OFF";
        }

        protected void RdbNivel3_CheckedChanged(object sender, EventArgs e)
        {
            string nivel1, nivel2, nivel3;
            nivel1 = "OFF";
            nivel2 = "OFF";
            nivel3 = "ON";
        }
    }
}