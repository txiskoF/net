using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo_DIVISAS
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

        protected void BtnDolarUSA_Click(object sender, EventArgs e)
        {
            double monedas = Convert.ToDouble(TxtMonedas.Text);
            LblCambio.Text = BtnDolarUSA.Text + " " + (monedas * dUSA).ToString();
        }

        protected void BtnDolarCAN_Click(object sender, EventArgs e)
        {
            double monedas = Convert.ToDouble(TxtMonedas.Text);
            LblCambio.Text = BtnDolarCAN.Text + " " +(monedas * dCAN);
        }

        protected void BtnDolarAUS_Click(object sender, EventArgs e)
        {
            double monedas = Convert.ToDouble(TxtMonedas.Text);
            LblCambio.Text = BtnDolarAUS.Text + " " + (monedas * dAUS).ToString();
        }

        protected void BtnPesoARG_Click(object sender, EventArgs e)
        {
            double monedas = Convert.ToDouble(TxtMonedas.Text);
            LblCambio.Text = BtnPesoARG.Text + " " + (monedas * pARG).ToString();
        }
    }
}