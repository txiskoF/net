using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio16
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                txtIdentificativo.Focus();
            }
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.setid(txtIdentificativo.text);


            int antiguedad = emp.calcularAnios();
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}