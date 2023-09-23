using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio18
{
    public partial class MisCompras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            char[] separador = { '-' };
            string[] cantidad = Session["cantidad"].ToString().Split(separador);
            for (int i = 0; i < cantidad.Count() - 1; i++)
            {
                lblCompras.Text += "<li>" + cantidad[i] + "</li>";
            }
            lblPrecio.Text = "Precio Total:" + Session["precio"] + " €";
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Server.Transfer("Autentificar.aspx");
        }
    }
}