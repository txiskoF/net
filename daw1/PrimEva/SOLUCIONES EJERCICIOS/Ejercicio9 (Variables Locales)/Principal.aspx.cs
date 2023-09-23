using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Principal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            TxtPanel.Text = "RESUMEN: \n";
            TxtPanel.Text += "Musica: OFF"  + "\n";
            TxtPanel.Text += "Ratón: OFF" +  "\n";
            TxtPanel.Text += "Color: OFF" +  "\n";
            TxtPanel.Text += "Nivel1: OFF" +  "\n";
            TxtPanel.Text += "Nivel2: OFF" +  "\n";
            TxtPanel.Text += "Nivel3: OFF" +  "\n";
        }
    }

    protected void Escribir(object sender, EventArgs e)
    {
        string nivel1, nivel2, nivel3, musica, raton, color;
        if (RdbNivel1.Checked)
        {
            nivel1 = "ON";
            nivel2= "OFF";
            nivel3 = "OFF";
        }
        else if (RdbNivel2.Checked)
        {
            nivel1 = "OFF";
            nivel2 = "ON";
            nivel3 = "OFF";
        }
        else
        {
            nivel1 = "OFF";
            nivel2 = "OFF";
            nivel3 = "ON";
        }

        if (chkMusica.Checked)
        {
            musica = "ON";
        }else
        {
            musica = "OFF";
        }
        if (ChkRaton.Checked)
        {
            raton = "ON";
        }
        else
        {
            raton = "OFF";
        }
   
        if (ChkColor.Checked)
        {
            color = "ON";
        }else
        {
            color = "OFF";
        }
        TxtPanel.Text = "RESUMEN: \n";
        TxtPanel.Text += "Musica: " + musica + "\n";
        TxtPanel.Text += "Ratón: " + raton + "\n";
        TxtPanel.Text += "Color: " + color + "\n";
        TxtPanel.Text += "Nivel1: " + nivel1 + "\n";
        TxtPanel.Text += "Nivel2: " + nivel2 + "\n";
        TxtPanel.Text += "Nivel3: " + nivel3 + "\n";
    }
}