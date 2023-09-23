using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Principal : System.Web.UI.Page
{
      protected void Calcular(object sender, EventArgs e)
    {
           
        double iva=0,cantidad, totaliva, total;

        Button btn = (Button)sender;
        switch (btn.ID)
        {
            case "btn4":
                iva = 0.04;
                break;
            case "btn8":
                iva = 0.08;
                break;
            case "btn16":
                iva = 0.16;
                break;
            case "btn21":
                iva = 0.21;
                break;
            }
        cantidad = Double.Parse(txtcantidad.Text);
        totaliva = cantidad*iva;
       
        total = cantidad + totaliva;
        lblIVA.Text = totaliva.ToString();
        lblTotal.Text =  total.ToString();
        
       //Asignacion Variables ViewState
       //Las necesitamos para guardar los cálculos de IVA y totales a 
       //la hora de introducir los encabezados <H></H>
        
        ViewState["Iva"] = "IVA: " + totaliva + " €";
        ViewState["Total"] = "Total: " + total + " €";
        lblIVA.Text = ViewState["Iva"].ToString();
        lblTotal.Text =  ViewState["Total"].ToString();
    }

    protected void Marcar(object sender, EventArgs e)
    {
        string etiquetaI="";
        string etiquetaF="";
        Button btn = (Button)sender;
        switch (btn.ID)
        {
            case "btnh1":
                etiquetaI = "<H1 style='color:red'>";
                etiquetaF = "</H1>";
                break;
            case "btnh2":
                etiquetaI = "<H2 style='color:blue'>";
                etiquetaF = "</H2>";
                break;
            case "btnh3":
                etiquetaI = "<H3 style='color:yellow'>";
                etiquetaF = "</H3>";
                break;
            case "btnh4":
                etiquetaI = "<H4 style='color:gray'>";
                etiquetaF = "</H4>";
                break;
            case "btnh5":
                etiquetaI = "<H5 style='color:green'>";
                etiquetaF = "</H5>";
                break;
            case "btnh6":
                etiquetaI = "<H6 style='color:orange'>";
                etiquetaF = "</H6>";
                break;
        }

        lblIVA.Text = etiquetaI + ViewState["Iva"] + etiquetaF;
        lblTotal.Text = etiquetaI + ViewState["Total"] + etiquetaF;
    }

   
}