using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Formulario_COMMAND : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            //La primera vez que se ejecuta el Page_Load() (es decir, al arrancar la ejecución de mi página) inicializamos la variable a FALSE.
            ViewState["botoncreado"] = false;
        }
        else
        {
            //El resto de veces que se ejecuta el Page_Load() (por la ejecución de cualquier otro evento) creamos el botón del 56% solo si hemos dicho que debe estar cargado (Variable ViewState["botoncreado"])
            bool botoncreado = Convert.ToBoolean(ViewState["botoncreado"]);
            if (botoncreado)
            {
                CrearBoton();
            }

        }
    }

    private void CrearBoton()
    {
        //Subrutina para crear el botón en ejecución del 56% y decirle que sobre él se puede ejecutar un evento COMMAND que resolverá la subrutina Calcular.
        Button btn56 = new Button();
        btn56.ID = "btn56";
        btn56.Text = "56%";
        btn56.CommandName = "56%";
        btn56.CommandArgument = "0,56";
        btn56.Command += Calcular;
        Panel1.Controls.Add(btn56);
       ViewState["botoncreado"] = true;
    }

   

    protected void Calcular(object sender, CommandEventArgs e)
    {
        //Subrutina que se ejecuta cada vez que hacemos click en un botón de Porcentaje (4%,8%,16%,21% e incluso 56%);
        double cantidad = Double.Parse(txtcantidad.Text);
        double iva = cantidad * Convert.ToDouble(e.CommandArgument);
        double total = cantidad + iva;
        lblIVA.Text = "IVA:" + iva+ " €";
        lblTotal.Text = "Total: " + total + " €";
        ViewState["IVA"] = lblIVA.Text;
        ViewState["Total"] = lblTotal.Text;
    }

    protected void txtcantidad_TextChanged(object sender, EventArgs e)
    {
        //Al introducir una cantidad en el cuadro de texto y pulsar Enter, 
        //          si la cantidad es superior a 100000 y el botón del 56% todavía no ha sido creado lo creará.
        //          y si la cantidad es inferior o igual a 100000 y el botón del 56% está creado lo eliminará.
        bool botoncreado =Convert.ToBoolean( ViewState["botoncreado"]);
        double cantidad = Double.Parse(txtcantidad.Text);
        if (cantidad>100000 && !botoncreado )
    
        {
            CrearBoton();
        }
        else if (cantidad<=100000 && botoncreado)
        {
            //La eliminación la hacemos con el método RemoveAt al que pasamos la posición del elemento a borrar. Como es el último 
            // que hemos creado será el Total de elementos de la colección -1 (siempre van los elementos desde la posición 0 hasta Count-1)
            Panel1.Controls.RemoveAt(Panel1.Controls.Count - 1);
            ViewState["botoncreado"] = false;


            //Eliminación con el método Remove que borra el objeto que tu le pases. En nuestro caso deberíamos buscar el botón56.
            // Esto se hace recorriendo la colección de controles de un panel/div/Form (control contenedor) y verificando el tipo de control que queremos encontrar con el
            // operador is y luego localizándolo por alguna otra característica como por su ID.
            //for (int i = 0; i < Panel1.Controls.Count; i++)
            //{
            //    if (Panel1.Controls[i] is Button)
            //    {
            //        Button btnporcentaje = (Button)Panel1.Controls[i];
            //        if (btnporcentaje.ID=="btn56")
            //        {
            //            Panel1.Controls.Remove(Panel1.Controls[i]);
            //            ViewState["botoncreado"] = false;
            //        }
            //    }
            //}

        }
    }

    protected void Marcar(object sender, CommandEventArgs e)
    {
        //Hemos colocado en las propiedades CommandName y CommandArgument de cada botón de etiquetas HTML las etiquetas de 
        // inicio y cierre del encabezado respectivamente.
        lblIVA.Text = e.CommandName + ViewState["IVA"] + e.CommandArgument;
        lblTotal.Text = e.CommandName + ViewState["Total"] + e.CommandArgument;


    }

    
}
