using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CALCULOS;
namespace Ejercicio12_SOLUCION
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HabilitarPaneles(pnldecimal, true);
                HabilitarPaneles(pnlhexadecimal, false);
                ViewState["baseactual"] = 10;
            }

        }

        protected void escribir(object sender, EventArgs e)
        {
            Button Btnnumero = (Button)sender;
            if (txtresultado.Text == "0." || txtresultado.Text == "0")
            {
                txtresultado.Text = Btnnumero.Text;
            }
            else
            {
                txtresultado.Text += Btnnumero.Text;
            }
        }

        protected void rdblBases_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                string baseanterior = ViewState["baseactual"].ToString();
                switch (rdblBases.SelectedIndex)
                {
                    case 0:
                        //Base Binaria
                        HabilitarPaneles(pnldecimal, false);
                        HabilitarPaneles(pnlhexadecimal, false);
                        btn1.Enabled = true;
                        break;
                    case 1:
                        //Base Octal
                        HabilitarPaneles(pnldecimal, true);
                        HabilitarPaneles(pnlhexadecimal, false);
                        btn8.Enabled = false;
                        btn9.Enabled = false;
                        break;
                    case 2:
                        //Base Decimal
                        HabilitarPaneles(pnldecimal, true);
                        HabilitarPaneles(pnlhexadecimal, false);
                        break;
                    case 3:
                        //Base Hexadecimal
                        HabilitarPaneles(pnldecimal, true);
                        HabilitarPaneles(pnlhexadecimal, true);
                        break;
                }
            ViewState["baseactual"] = rdblBases.SelectedValue;
            if (txtresultado.Text != "0." && txtresultado.Text != "0")
            {
                switch (baseanterior)
                {
                    case "10":
                        txtresultado.Text = Calculadora.convertirDecimalaBase(Convert.ToInt32(txtresultado.Text), Convert.ToInt32(rdblBases.SelectedValue));
                        break;
                    case "2":
                    case "8":
                    case "16":
                        long resultado = Calculadora.convertirBaseaDecimal(txtresultado.Text, Convert.ToInt32(baseanterior));
                        txtresultado.Text = Calculadora.convertirDecimalaBase(Convert.ToInt32(resultado), Convert.ToInt32(rdblBases.SelectedValue));
                        break;

                }
           


            }

        }

        protected void HabilitarPaneles(PlaceHolder panel, bool habilitar)
        {
           
            foreach (Control item in panel.Controls)
            {
                if (item is Button)
                {
                    Button BtnControl = (Button)item;
                    if (habilitar)
                    {
                        BtnControl.Enabled = true;
                    }
                    else
                    {
                        BtnControl.Enabled = false;
                    }
                }

            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "0.";
        }
    }
}