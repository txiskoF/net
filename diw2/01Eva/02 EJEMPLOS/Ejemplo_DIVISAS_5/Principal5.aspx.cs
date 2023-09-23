using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Calculadora;

namespace Ejemplo_DIVISAS_5
{
    public partial class Principal5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Calcular(object sender, CommandEventArgs e)
        {
            double monedas = Convert.ToDouble(TxtMonedas.Text);
            double cambio = Convert.ToDouble(e.CommandArgument);
            LblCambio.Text = e.CommandName + " - " + superdivisas.convertir(monedas, cambio);
        }
    }
}