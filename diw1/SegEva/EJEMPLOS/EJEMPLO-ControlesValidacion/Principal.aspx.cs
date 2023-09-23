using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Principal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtNombre.Focus();
        }
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            Response.Write ("OK");
        }
    }

    protected void cvnumeroPAR_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (Convert.ToInt32(args.Value) %2==0)
        {
            args.IsValid = true;
        }
        else
        { args.IsValid = false; }     
    }
}