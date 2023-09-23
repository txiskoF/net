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
            MostrarDatos();
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        MostrarDatos();
    }

    private void MostrarDatos()
    {
        //Usando los métodos IndexOf y Substring
        //string nombre = ddlnombres.SelectedItem.Text;
        //int coma = nombre.IndexOf(",");
        //lblnombre.Text = nombre.Substring(coma + 1);
        //lblapellidos.Text = nombre.Substring(0, coma);
        //lblnombrecompleto.Text = lblnombre.Text + " " + lblapellidos.Text;

        //Usando el método Split
        string nombre = ddlnombres.SelectedItem.Text;
        char separador = ',';
        char[] separadores = new char[] { ',' };
        string[] cadenas = nombre.Split(separador);
        lblnombre.Text = cadenas[1];
        lblapellidos.Text = cadenas[0];
        lblnombrecompleto.Text = cadenas[1] + " " + cadenas[0];
    }
}
