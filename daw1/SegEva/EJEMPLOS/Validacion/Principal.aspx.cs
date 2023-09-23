using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validacion
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEnviarDatos_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Response.Redirect("http://www.zabalburu.net");
            }
        }

      

        protected void cvCorreo_ServerValidate(object source, ServerValidateEventArgs args)
        {
            //Si validasemos en el Servidor. 
            //La propiedad EnableClientScript debe ir a False. Evidentemente no habrá
            //ningún valor en FunctionToValidate, ni funciones en un Script de JavaScript.
            string correo = args.Value;
            if (correo == "marta.torre@zabalburu.org" || correo == "inigo.chueca@zabalburu.org")
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void BtnValidaCorreo_Click(object sender, EventArgs e)
        {
            if (reCorreo.IsValid)
            {
                Response.Redirect("http://www.zabalburu.net");
            } 
        }
    }
}