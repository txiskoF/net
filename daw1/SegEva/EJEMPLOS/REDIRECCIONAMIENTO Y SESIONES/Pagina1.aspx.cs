using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Principal
{
    public partial class Pagina1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnENVIAR_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina2.aspx?Nombre=" + TxtNombre.Text + "&Correo=" + TxtCorreo.Text);
        }

        protected void btnENVIAR0_Click(object sender, EventArgs e)
        {
            Context.Items.Add("Nombre", TxtNombre.Text);
            Context.Items.Add("Correo", TxtCorreo.Text);
            Server.Transfer("Pagina2.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Application.Lock();
            Application["contadorUsuarios"] = (int)Application["contadorUsuarios"] + 1;
            Application.UnLock();
            Session["Usuario"] = TxtNombre.Text;
            Session["Compras"] = 0;
            Server.Transfer("Pagina2.aspx");       
        }
    }
}