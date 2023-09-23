using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SESIONES
{
    public partial class Compras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1ª FORMA RECOGER DATOS DE OTRO FORMULARIO (RESPONSE.Redirect("Pagina?variable=valor ----Recoge con Request.Params["variable"])
            //Response.Write("El nombre pasadop es: " + Request.Params["nombre"]);
            //Response.Write("El nombre pasadop es: " + Request.QueryString.Get("nombre"));
            //Response.Write("El apellido pasado es: " + Request.Params["apellidos"]);

            //2ªForma Recoger Datos (Server.Transfer)

            //Response.Write("El nombre pasadop es: " + Context.Items["nombre"]);
            //Response.Write("El apellido pasadop es: " + Context.Items["apellido"]);

            // Server.Transfer (....,true);

            //Response.Write("El nombre pasadop es: " + Request.Form["txtNombre"]);
            //Response.Write("El nombre pasadop es: " + Request.Form["txtApellido"]);


            //3ª FORMA -- Acceder
            //Response.Write("El nombre pasado es: " + ((TextBox)PreviousPage.FindControl("TxtNombre")).Text);
            //Response.Write("El nombre pasado es: " + ((TextBox)PreviousPage.FindControl("TxtApellido")).Text);

        
        
                LblPresentacion.Text = "Hola " + Session["Usuario"] + " " + Session["Apellido"] + "<BR/> El número de Compras(Session Compras) :" + Session["Compras"];
          
        

        }

        protected void BtnCompras_Click(object sender, EventArgs e)
        {
            int compras = (int)Session["Compras"];
            compras += 1;
            Session["Compras"] = compras;
            LblPresentacion.Text = "Hola " + Session["Usuario"] + " " + Session["Apellido"] + "<BR/> El número de Compras(Session Compras) :" + Session["Compras"];

        }
    }
}