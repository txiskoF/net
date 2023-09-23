using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FUNCIONES_DE_CADENA_STRINGS
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            string abecedario = "abcdefghijklmnñopqrstuvwxyz";
            string correo = "marta.torre@zabalburu.org";
            string correoalumno = "andres.sanjuan.martiartu@zabalburu.org";

            //Para comprobar si comienza por un símbolo (StartsWith)
            bool empiezaPor=abecedario.StartsWith("a");
            //Para comprobar si acaba en un símbolo (EndsWith)
            bool acabaPor = abecedario.EndsWith("z",StringComparison.OrdinalIgnoreCase );
            //Para comprobar si contiene por un símbolo (Contains)
            bool contiene=abecedario.Contains("j");

            //Eliminar por el principio y final el símbolo * (Trim)
            Label1.Text=abecedario.Trim('*');
            //Eliminar por el principio y final los espacios en blanco (Trim)
            Label1.Text = abecedario.Trim();
            //Eliminar por el principio los espacios en blanco (TrimStart)
            Label1.Text = abecedario.TrimStart();
            //Eliminar por el final los espacios en blanco (TrimEnd)
            Label1.Text = abecedario.TrimEnd();
            //Eliminar por el medio de una cadena los espacios en blanco (Replace)
            Label1.Text = abecedario.Replace(" ", "");

            //Rellena con espacios por la izquierda hasta 40 caracteres (PadLeft)
            Label1.Text = abecedario.PadLeft(40);
            //Rellena con espacios por la derecha hasta 40 caracteres (PadRight)
            Label1.Text = abecedario.PadRight(40);
            //Rellena con guiones por la izquierda hasta 40 caracteres (PadLeft)
            Label1.Text = abecedario.PadLeft(40,'-');

            //Busca la posición del caracter punto (.) (IndexOf)
            int punto = correo.IndexOf(".");
            //Muestra desde la posición 0 has la posición punto (Substring (2 parametros)
            Label1.Text = correo.Substring(0, punto); //NOMBRE
            //  //Busca la posición del caracter arroba (@) (IndexOf)
            int arroba = correoalumno.IndexOf("@"); // APELLIDO
            Label1.Text = correo.Substring(punto + 1, arroba-punto-1);

            //Busca la posición del caracter punto a partir de la posición 0 y durante 3 posiciones (IndexOf(3 parametros))
            //int ultimopunto = correo.IndexOf(".",0,3);
            int segundopunto = correo.IndexOf(".", correo.IndexOf(".") + 1);
            //Busca el último punto que aparezca en la cadena (LastIndexOf)
            int ultimopunto = correo.LastIndexOf(".");
            //Muestra desde la posición siguiente a ultimopunto hasta el final (Substring (1 parametro))
            // Label1.Text = correo.Substring(ultimopunto + 1);
             //Saca el dominio Secundario (zabalburu)
            //Label1.Text = correo.Substring(arroba + 1, ultimopunto - arroba - 1);
            //int punto = correoalumno.IndexOf(".");
            //int arroba = correoalumno.IndexOf("@");
            //int segundopunto = correoalumno.IndexOf(".", punto + 1);
            //Label1.Text = correoalumno.Substring(segundopunto + 1, arroba - segundopunto - 1);

            char[] simbolos = new char[] { '.', '@' };
            string[] elementos = correoalumno.Split(simbolos);


            foreach (string item in elementos)
            {
                Label1.Text += item + "*****";
            }

            Label1.Text = abecedario.Insert(0, ".");
            Label1.Text = abecedario.Remove(0, 4);

            Label1.Text += "a";
            Label1.Text = "a" + Label1.Text;


        }
    }
}