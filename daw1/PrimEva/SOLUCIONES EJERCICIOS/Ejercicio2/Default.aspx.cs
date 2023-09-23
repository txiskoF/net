using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGoogle_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://www.google.es");
    }
    protected void btnCorreo_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://www.elcorreo.com");
    }

    protected void btnConfidencial_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://www.elconfidencial.com");
    }
    protected void btnMundo_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://www.elmundo.es");
    }
    protected void btnMarca_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://www.marca.com");
    }
    protected void btnYahoo_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://es.yahoo.com");
    }

    protected void btnBing_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://www.bing.com");
    }
    protected void btnHaxia_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://www.hakia.com");
    }
}