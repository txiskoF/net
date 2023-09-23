using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Termometro;


namespace Ejercicio3A
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // El evento Page_Load se ejecuta cada vez que la página es enviada al servidor. 
            // Es el primer evento que se ejecuta cuando arrancamos el proyecto y también se ejecuta cuando realizamos cualquier otro evento
            // en muestra página. Por tanto debemos distinguir la primera vez que se ejecuta de las demás. Esto se hace con una condicional 
            // preguntando por la propiedad IsPostBack de la Pagina (Page). Si esta propiedad está a True significa que la página ya ha hecho 
            // por lo menos una ida y vuelta al servidor. Si está a False significa que es la primera vez que se va a ejecutar el evento.
            // Por eso preguntamos por  (! IsPostBack) o (! Page.IsPostBack).


            // if (!Page.IsPostBack){

            if (!IsPostBack)
            {
                
                txtCentigrados.Focus();

            }
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            //Comparación con == o distinto de con != 
            // También podemos comparar con el método Equals, aplicándolo al objeto que queramos comparar y pasándole como parámetro
            // el otro valor a comparar.

            if (txtCentigrados.Text != "" && txtFarenheit.Text == "")
            {
                txtFarenheit.Text = Conversor.convertirC_F(Double.Parse(txtCentigrados.Text)).ToString();

            }
            else if (txtCentigrados.Text.Equals("") && !txtFarenheit.Text.Equals(""))
            {

                txtCentigrados.Text = Conversor.convertirF_C(Convert.ToDouble(txtFarenheit.Text)).ToString();

            }
            else if (txtCentigrados.Text != "" && txtFarenheit.Text != "")
            {

                Limpiar();
                // Page.SetFocus(txtCentigrados);
            }
        }



        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Borrar el texto de un cuadro de texto es poner su propiedad al valor "" o asignar 
            // la propiedad Empty de la clase String, que es lo mismo.

            Limpiar();

        }

        protected void Limpiar()
        {
            txtCentigrados.Text = "";
            txtFarenheit.Text = String.Empty;
            txtCentigrados.Focus();
            //El foco también se puede pasar a través del método SetFocus de la clase Page.
            //Page.SetFocus(txtCentigrados);


        }


    }
}