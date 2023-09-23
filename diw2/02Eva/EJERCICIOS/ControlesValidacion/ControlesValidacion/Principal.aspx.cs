using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlesValidacion
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Response.Redirect("https://cdn.shopify.com/s/files/1/2494/7004/products/DW058PLCMT_1024x1024.jpg?v=1526579457");
            }
       
        }
    }
}