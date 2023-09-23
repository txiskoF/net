using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Principal : System.Web.UI.Page
{

    //Evento Command de los Botones de Imagen
    protected void mostrar(object sender, CommandEventArgs e)
    {
        double[] latitud = new double[] { 43.324520, 42.852070, 42.472118, 43.475609,40.462341, 41.383530 };
        double[] longitud = new double[] { -1.984566, -2.681070,-2.429210,-3.792280,-3.615800,-2.109620 };
        double[] km = new double[] { 99.5, 62, 136, 102, 402, 609 };
        string[] nombres = new string[] { "Donosti", "Vitoria-Gasteiz", "Logroño", "Santander", "Madrid", "Barcelona" }


        imgCiudad.ImageUrl = e.CommandArgument.ToString();
        lblCiudad.Text = nombres[Convert.ToByte(e.CommandName)];
        LblLatitud.Text= latitud[Convert.ToByte(e.CommandName)].ToString();
        LblLongitud.Text= longitud[Convert.ToByte(e.CommandName)].ToString();
        txtkm.Text=km[Convert.ToByte(e.CommandName)].ToString();

        ClientScript.RegisterStartupScript(GetType(), "posicion", "GetMap()",
        false);
    }   

protected void Page_Load(object sender, EventArgs e)
    {
        //Cargar al inicio de la aplicación la imagen de Bilbao y el título
        //la Latitud y la Longitud inicales están colocadas en la propiedad text en diseño.
        if (!IsPostBack)
        {
            imgCiudad.ImageUrl = "Imágenes/Bilbao.jfif";
            lblCiudad.Text = "Bilbao";
          
        }
      
    }

    protected void btnIda_Click(object sender, EventArgs e)
    {
        //Calculo de precio del km de Ida
        lblTotal.Text = "Total: " + ViewState["resultado"] + " €";
          }

   

    protected void btnIdaVuelta_Click(object sender, EventArgs e)
    {
        //Calculo de precio del km de Ida y Vuelta
        double total = Convert.ToDouble(ViewState["resultado"]) * 2;
        lblTotal.Text = "Total: " + total + " €";
    }

         
    protected void txteuros_TextChanged(object sender, EventArgs e)
    {
        double euros = Double.Parse(txteuros.Text);
        double resultado;
        double km = Double.Parse(txtkm.Text);
        if (euros >= 0.7 && euros <= 0.95)
        {
            resultado = euros * km;
            ViewState["resultado"] = resultado;
            //Poner el número en negro y normal
            txteuros.Style["color"] = "black";
            txteuros.Style["font-weight"] = "normal";
        }
        else
        {
           //Poner el número en rojo y negrita
            txteuros.Style["color"] = "red";
            txteuros.Style["font-weight"] = "900";
            txteuros.Focus();
        }
    }
}