using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlesValidacion
{
    public partial class Principal4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtFecha.Text = DateTime.Today.ToLongDateString();
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Response.Redirect("https://www.km77.com/");
            }
        }
    }
}