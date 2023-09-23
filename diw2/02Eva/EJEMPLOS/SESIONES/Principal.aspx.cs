using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SESIONES
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {

            //Response.Redirect("Compras.aspx");
            ////1ª FORMA ENVÍO DATOS (Response.Redirect("página?variable1=valor&variable2=valor&variable...") 
            ////El envío se hace a traves de GET (se envía en la URL...se ven los datos pasados...)
            //Response.Redirect("Compras.aspx?nombre=" + TxtNombre.Text + "&apellidos=" + TxtApellido.Text);


            //2ª FORMA DE ENVÍO
            //Context.Items.Add("nombre", TxtNombre.Text);
            //Context.Items.Add("Apellidos", TxtApellido.Text);
            // Server.Transfer("Compras.aspx",true);

            //3ª FORMA REDIRECCIONAR : (Propiedad de los botones PostBackUrl : Página a la que quieres navegar")


            Session["Usuario"] = TxtNombre.Text;
            Session["Apellido"] = TxtApellido.Text;
            Response.Redirect("Compras.aspx");

        }
    }
}