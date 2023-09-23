using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo1
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblNombre.Attributes.Add("onmouseover", "PonerFoco('TxtNombre')");
            LblCorreo.Attributes.Add("onmouseover", "PonerFoco('TxtCorreo')");
            BtnImprimir.Attributes.Add("onmouseover", "CambiarFondo('BtnImprimir')");
            BtnImprimir.Attributes.Add("onmouseout","InicializarFondo('BtnImprimir')");
            BtnLimpiar.Attributes.Add("onmouseover", "CambiarFondo('BtnLimpiar')");
            BtnLimpiar.Attributes.Add("onmouseout", "InicializarFondo('BtnLimpiar')");
        }

        protected void BtnImprimir_Click(object sender, EventArgs e)
        {
            Label LblResultado = new Label
            {
                Text = TxtNombre.Text + "-" + TxtCorreo.Text
            };
            LblResultado.Style["display"] = "block";
            contenido.Controls.Add(LblResultado);
        }
    }
}