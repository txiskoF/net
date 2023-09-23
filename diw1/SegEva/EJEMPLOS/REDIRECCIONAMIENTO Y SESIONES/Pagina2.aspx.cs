using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Principal
{
    public partial class Pagina2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*Usando método PostBackURLK de los BOTONES*/

            /*TextBox TxtNombre = (TextBox)PreviousPage.FindControl("TxtNombre");
             TextBox TxtCorreo = (TextBox)PreviousPage.FindControl("TxtCorreo");
                LblMensaje.Text = TxtNombre.Text + "-" + TxtCorreo.Text; */

            //  Response.Write("HOLA");

            /*Método 2: RESPONSE.REDIRECT*/
            //LblMensaje.Text = Request.Params["Nombre"] + "-" + Request.Params["Correo"];

            /*Método 3: Server.Transfer: SOLO para acceder a páginas de nuestra aplicación*/
            /*LblMensaje.Text = Context.Items["Nombre"].ToString() + Context.Items["Correo"].ToString();*/

            if (!IsPostBack)
            {
                LblMensaje.Text = "Hola " + Session["Usuario"];
            }
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            Session["Compras"] = (int)Session["Compras"] + 1;
            LblMensaje.Text = "Hola " + Session["Usuario"] + "<BR/>" + "Tus compras son " + Session["Compras"]
                + "<BR/>" + "Los usuarios que están actualmente en la aplicación son : " + Application["contadorUsuarios"];
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Server.Transfer("Pagina1.aspx");
            //Response.Redirect("Pagina1.aspx");
        }
    }
}