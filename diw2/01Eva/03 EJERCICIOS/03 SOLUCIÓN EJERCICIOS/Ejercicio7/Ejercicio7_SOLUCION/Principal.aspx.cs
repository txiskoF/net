using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio7_SOLUCION
{
    public partial class Principal : System.Web.UI.Page
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {
	//Al arrancar la página el foco estará en el cuadro de texto de empleado.
            if (!IsPostBack)
            {
                txtEmpleado.Focus();
            }
        }

        protected void txtEmpleado_TextChanged(object sender, EventArgs e)
        {

            string[] empleados = new string[] { "F11", "F12", "F13", "F14", "F15", "F16", "F17", "F18", "F19", "F20" };
            // verificamos si está o no el valor introducido en el cuadro de texto de empleado en la matriz que acabamos de declarar e inicializar.


            //for (int i = 0; i < empleados.Length; i++)
            //{
            //    if (empleados[i] == txtEmpleado.Text.ToUpper())
            //    {
            //        encontrado = true;
            //        break;
            //    }
            //}
            /************ HECHO CON UN WHILE (Si encuentra el elemento en la matriz sale del BUCLE *********/
            bool encontrado = BuscarEmpleado(empleados,txtEmpleado.Text);
            /***************************************************************************************************/
            /******* HECHO CON UN FOR (Obligado a recorrer toda la matriz, aunque lo haya encontrado ya.********/
            //for (int i = 0; i < empleados.Length; i++)
            //{
            //    if (txtEmpleado.Text.Equals(empleados[i], StringComparison.OrdinalIgnoreCase){
            //        encontrado = true;

            //    }
            //}
            /***************************************************************************************************/
            if (encontrado)
            {
                txtImporte.Focus();

            }
            else
            {
                txtEmpleado.Text = String.Empty;
                //txtEmpleado.Text = "";
                txtEmpleado.Focus();
            }
        }

        private bool BuscarEmpleado(string[] empleados,string empleado)
        {
            bool encontrado = false;
            int j = 0;
            while (j < empleados.Length && (!encontrado))
            {
                if (empleado.Equals(empleados[j], StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = true;
                }
                j += 1;
            }

            return encontrado;
        }

        protected void txtImporte_TextChanged(object sender, EventArgs e)
        {
	//Calculamos los importes ivas y totales y guardamos la variable total en una ViewState, porque necesitamos acceder a ese valor en otro evento.

            double importe = Double.Parse(txtImporte.Text);
            double iva = importe * 0.21;
            double total = importe + iva;
            txtIVA.Text = iva.ToString("c");
            txtTotal.Text = total.ToString("c");
            ViewState["total"] = total;
            txtRecibido.Focus();
        }

        protected void txtRecibido_TextChanged(object sender, EventArgs e)
        {
            int[] Monedas = new int[] {500,200,100,50,20,10,5,2,1 };
            string[] ImgMonedas = new string[] { "IMAGENES/500.jpg", "IMAGENES/200.jpg", "IMAGENES/100.jpg", "IMAGENES/50.jpg", "IMAGENES/20.jpg", "IMAGENES/10.jpg", "IMAGENES/5.jpg", "IMAGENES/2.jpg", "IMAGENES/1.jpg" };
            int[] MonedaCambios = new int[9];
            //double ImporteTotal = Math.Truncate(Convert.ToDouble(ViewState["Total"));
            int ImporteTotal = Convert.ToInt32(ViewState["total"]);
            int Recibido = Int32.Parse(txtRecibido.Text);
            int cambios = Recibido - ImporteTotal;
            txtRecibido.Text += " €";
            int resultado = 0;
		//Si hemos metido un valor en Recibido menor al que debemos pagar, borrará el texto de Recibido y volver´ça a poner el foco en él.
            if (cambios<0)
            {
                txtRecibido.Text = "";
                txtRecibido.Focus();

            } //Si hay que devolver cambios......se va el cambio y sucesivos restos de las divisiones entre los tipos de billetes y monedas para ir quedándonos con los cocientes,
		//que serán los números de billetes o monedas que tenemos que devolver. Voy guardando esos cocientes en una matríz de cambios.
            else if (cambios>0)
            {
                txtCambios.Text = cambios.ToString("c");
                int j = 0;
                while (j<Monedas.Length && cambios!=0)
                {
                    resultado = cambios / Monedas[j];
                    cambios = cambios % Monedas[j];
                    MonedaCambios[j] = resultado;
                    j += 1;
                }

		//Tenemos que recorrer la matriz de cambios que acabamos de generar para ir creando tantas imágenes como monedas hayamos calculado que hay que deolver.
		//Para ello necesito hacer dos repetitivas una dentro de otra. La primera llevará la cuenta de cada una de las monedas que hay que devolver y la otra
		// repetitiva dentro será para dibujar el número que de cada una de las monedas debemos devolver.
                for (int i = 0; i < MonedaCambios.Length; i++)
                {
                    for (int k = 0; k < MonedaCambios[i]; k++)
                    {
                        Image ImgMoneda = new Image();
                        ImgMoneda.ImageUrl = ImgMonedas[i];
                        ImgMoneda.Width = 100;
                        ImgMoneda.Height = 50;
                        panelC.Controls.Add(ImgMoneda);
                    }
                }
            }


        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            ////1.- Cada uno de los Txt a ""
            //txtEmpleado.Text = "";
            //txtImporte.Text = String.Empty;
            //txtEmpleado.Focus();

            //2.- Recorremos un elemento contenedor, en este caso todos los controles de mi formulario (form1.Controls) y si son TextBox los borramos.
            //foreach (Control item in form1.Controls)
            //{
            //    if (item is TextBox)
            //    {

            //        TextBox TxtTexto = (TextBox)item;
            //        TxtTexto.Text = String.Empty;
            //       // ((TextBox)item).Text = "";
            //    }

            //}
            //txtEmpleado.Focus();

            //3.- Usando una expresion Lambda
            form1.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            txtEmpleado.Focus();
        }

     
        
      


        protected void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
}