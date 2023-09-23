using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJEMPLO_IMAGENES
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string[] textos = new string[] { "GOOGLE", "ZABALBURU", "CORREO" };
        string[] direcciones = { "http://www.google.es", "http://www.zabalburu.net", "http://www.elcorreo.es" };
        Button[] btn = new Button[3];
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["creados"] = false;
            }

            if ((Boolean)ViewState["creados"])
            {
                CrearBotones();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Propiedades de las imágenes
            ImgCiudad.ImageUrl = "IMAGENES/Bilbao.jfif";
            ImgCiudad.AlternateText = "Muestra Ciudad Barcelona";
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

            CrearBotones();
            ViewState["creados"] = true;
        }

        private void CrearBotones()
        {
            //Creación de una matriz de Botones en Ejecución
            for (int i = 0; i < btn.Length; i++)
            {
                int longitud = i * 100 + 20;
                btn[i] = new Button();
                btn[i].ID = "btn" + i;
                btn[i].Text = textos[i];
                btn[i].CommandArgument = direcciones[i];
                btn[i].Style["width"] = "100px";
                btn[i].Style["Height"] = "50px";
                btn[i].Style["left"] = longitud + "px";
                btn[i].Style["top"] = "250px";
                btn[i].Command += MostrarPagina;
                form1.Controls.Add(btn[i]);


            }
        }

        private void MostrarPagina(object sender, CommandEventArgs e)
        {
            Response.Redirect(e.CommandArgument.ToString());
        }

        protected void Button2_Click(object sender, EventArgs e)
        {


            // Tipos predefinidos en el sistema actuan con PASO POR VALOR
            // En una asignación de una variable a otra de un tipo predefinido, 
            //se crean dos espacios en memoria en donde cada variable apunta a su valor correspondiente.
            //Por tanto si cambio un valor en una variable no se cambiará la otra y viceversa.

            int a = 1;
            int b = a;
            Label1.Text = "A:" + a + "-B:" + b;
            b = 9;
            Label2.Text = "A:" + a + "-B:" + b;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Las matrices al igual que los objetos de una clase usan el PASO POr REFERENCIA
            // Si asignamos una matriz a otra las dos tomarán sus mismos valores,
            //pero no se reservan dos espacios en memoria para las dos matrices, sino uno.
            //Lo que se crean son dos referencias (apuntadores) al mismo espacio en memoria.
            //De tal forma que si varias los valores de una matriz estas variando los valores de la otra 
            //automáticamente y viceversa.
            //Si quieres crear varias copias de la matriz puedes usar el método matriz.CopyTo() o Array.Copy()
            //y genera un nuevo espacio en memoria con los 
            //mismo valores que tiene la matriz de la que estas copiando.

            int[] a = { 1, 1, 1, 1, 1 };
            int[] b = a;
            int[] c = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                Label1.Text += "A[" + i + "]:" + a[i] + "B[" + i + "]:" + b[i] + "<BR/>";
            }

            //for (int i = 0; i < b.Length; i++)
            //{
            //    b[i] = 9;
            //}

            //for (int i = 0; i < a.Length; i++)
            //{
            //    Label2.Text += "A[" + i + "]:" + a[i] + "B[" + i + "]:" + b[i] + "<BR/>"; ;
            //}

            a.CopyTo(c, 0);
            //Array.Copy(a, c, 5);
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = 7;
            }

            for (int i = 0; i < a.Length; i++)
            {
                Label2.Text += "A[" + i + "]:" + a[i] + "C[" + i + "]:" + c[i] + "<BR/>"; ;
            }

        }
    }
}