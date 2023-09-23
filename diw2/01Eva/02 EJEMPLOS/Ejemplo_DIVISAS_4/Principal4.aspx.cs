using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo_DIVISAS_4
{
    public partial class Principal4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calcular(object sender, CommandEventArgs e)
        {
            double moneda = Convert.ToDouble(TxtMonedas.Text);
            double cambio = Convert.ToDouble(e.CommandArgument);
            LblCambio.Text = e.CommandName + " - " + Divisas.convertirMoneda(moneda, cambio); 
        }
    }
}