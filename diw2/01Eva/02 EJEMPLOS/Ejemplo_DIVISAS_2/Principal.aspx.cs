using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo_DIVISAS_2
{
    public partial class Principal : System.Web.UI.Page
    {
        private const double dUSA = 1.35;
        private const double dAUS = 1.43;
        private const double dCAN = 1.39;
        private const double pARG = 7.78;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calcular(object sender, EventArgs e)
        {
            double monedas = Convert.ToDouble(TxtMonedas.Text);
            Button BtnCambio = (Button)sender;
            double cambio = 0;
            switch (BtnCambio.ID)
            {
                case "BtnDolarUSA":
                    cambio = dUSA * monedas;
                    break;
                case "BtnDolarCAN":
                    cambio = dCAN * monedas;
                    break;
                case "BtnDolarAUS":
                    cambio = dAUS * monedas;
                    break;
                case "BtnPesoARG":
                    cambio = pARG * monedas;
                    break;
            }
            LblCambio.Text = BtnCambio.Text + " " + cambio.ToString();
        }
    }
}