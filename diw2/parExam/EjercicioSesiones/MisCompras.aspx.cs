using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LIBROS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
            char[] separador = { '-' };
        
            string[] elementos = Session["elementos"].ToString().Split(separador);
            lblcompras.Text = "<UL type='square'>";
            for (int i = 0; i < elementos.Count() - 1; i++)
            {
                lblcompras.Text += "<LI>" + elementos[i] + "</LI>";
            }
            lblcompras.Text += "</UL>";
            lblprecio.Text = "Precio Total:" + Session["precio"] + " €" ;
      
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Server.Transfer("Autentificacion.aspx");
    }
}