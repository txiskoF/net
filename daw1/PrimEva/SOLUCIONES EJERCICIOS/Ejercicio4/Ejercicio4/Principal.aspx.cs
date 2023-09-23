using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Calculos;

public partial class Principal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtaltura.Attributes.Add("onclick", "borrarTextos('txtaltura')");
        txtpeso.Attributes.Add("onclick", "borrarTextos('txtpeso')");
        txtsexo.Attributes.Add("onclick", "borrarTextos('txtsexo')");

        if (!IsPostBack)
        {
            pagina.Style["Height"] = "310px";
            field2.Visible = false;
            btnInicia.Visible = false;
        }
       
    }

    protected void btnCalcular_Click(object sender, EventArgs e)
    {
        if (btnCalcular.Text.Equals("Calcular"))
        {
                   
		// El método .ToString() puede admitir o no un un parámetro que es para dar formato al número.
		// Más adelante veremos las máscaras a poner. La que está utilizada en este ejercicio .ToString("0.##')
		// es para que en la parte entera del número siempre haya un dígito mínimo y la parte decimal como máximo tendrá
		// dos dígitos.

                lblIMC.Text = Calculadora.calcularIMC(Byte.Parse(txtpeso.Text), Single.Parse(txtaltura.Text)).ToString("0.##");
                lblIbuprofeno.Text = Calculadora.calcularI(Byte.Parse(txtpeso.Text)).ToString("0.##");
                lblParacetamol.Text = Calculadora.calcularP(Byte.Parse(txtpeso.Text)).ToString("0.##");             
            }
       
        else
        {
            lblIMC.Text = Calculadora.calcularAM(Single.Parse(txtaltura.Text), Single.Parse(txtpeso.Text), txtsexo.Text).ToString("0.##");
           
        }
        field2.Visible = true;
        pagina.Style["height"] = "620px";
        btnInicia.Visible = true;

    }

    protected void btnOtros_Click(object sender, EventArgs e)
    {
        lblIbuprofeno.Visible = false;
        lblParacetamol.Visible = false;
        lblIMC.Text = "Altura Media Adulto: ";
        field2.Visible = false;
        txtaltura.Text = "Altura del padre";
        txtpeso.Text = "Altura de la madre";
        btnCalcular.Text = "Calcular Altura Media";
        pagina.Style["height"] = "310px";
        btnInicia.Visible = false;

    }

    protected void btnInicia_Click(object sender, EventArgs e)
    {
        txtaltura.Text = "Introduzca la altura en cm.";
        txtpeso.Text = "Introduzca el peso en kg.";
        txtsexo.Text = "Introduzca el sexo del niñ@";
        btnCalcular.Text = "Calcular";
        lblIMC.Text = "IMC:";
        lblIbuprofeno.Visible = true;
        lblIbuprofeno.Text = "Ibuprofeno:";
        lblParacetamol.Visible = true;
        lblParacetamol.Text = "Paracetamol:";
        field2.Visible = false;
        pagina.Style["height"] = "310px";
        btnInicia.Visible = false;
        
    }

    protected void txtaltura_TextChanged(object sender, EventArgs e)
    {
        txtpeso.Focus();
       // Page.SetFocus(txtpeso);
    }

    protected void txtpeso_TextChanged(object sender, EventArgs e)
    {
        txtsexo.Focus();
    }

    protected void txtsexo_TextChanged(object sender, EventArgs e)
    {
        if (txtsexo.Text.ToLower() != "niño" && txtsexo.Text.ToLower() != "niña")
        {
            txtsexo.Text = "";
            //txtsexo.Text = String.Empty;
            txtsexo.Focus();
        }
        else
        {
            btnCalcular.Focus();

        }
       

    }
}