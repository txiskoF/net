using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VALIDACIONSERVIDOR : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnmostrar_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            lblresultado.Text = "EL número par es: " + txtnumero.Text;
        }
    }
    protected void cvpar_ServerValidate(object source, ServerValidateEventArgs args)
    {
        int numero=Convert.ToInt32(args.Value);
        if ( numero % 2 == 0)
        {
            args.IsValid = true;
        }
        else
        {
            args.IsValid = false;
        }

    }
}