using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VALIDACIONCLIENTE : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnmostrar_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            lblresultado.Text = "El número par es: " + txtnumero.Text;
        }
    }
}