using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio8A
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Al inicio de la Aplicación marcamos los dos botones iniciales y escribimos en la etiqueta
            if (!IsPostBack)
            {
                RdbMasculino.Checked = true;
                RdbSoltero.Checked = true;
                LblEstado.Text = "Su estado civil es Soltero";
            }
        }

        protected void RdbMasculino_CheckedChanged(object sender, EventArgs e)
        {

            RdbSoltero.Text = "Soltero";
            RdbCasado.Text = "Casado";
            RdbViudo.Text = "Viudo";
            RdbDivoirciado.Text = "Divorciado";
            // Verificamos cual es el botón de estado que está marcado
            VerificarEstado();
        }

        protected void RdbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            RdbSoltero.Text = "Soltera";
            RdbCasado.Text = "Casada";
            RdbViudo.Text = "Viuda";
            RdbDivoirciado.Text = "Divorciada";
            // Verificamos cual es el botón de estado que está marcado
            VerificarEstado();
        }

        protected void CambioEstado(object sender, EventArgs e)
        {
            //Los cuatro botones de estado responden al mismo evento. Debemos saber cual nos ha llamado (sender) y 
            // poder acceder a su propiedad Text.	
            RadioButton BtnEstado = (RadioButton)sender;
            LblEstado.Text = "Su estado civil es: " + BtnEstado.Text;
        }

        protected void VerificarEstado()

        {   // Debemos verificar cual de los botones del panel está señalado para reescribir su texto, ahora 
            // con el nuevo género.




            //foreach (Control item in Panel2.Controls)
            //{
            //    if (item is RadioButton)
            //    {
            //        RadioButton RdbEstado = (RadioButton)item;
            //        if (RdbEstado.Checked)
            //        {
            //            LblEstado.Text = "Su estado civil es: " + RdbEstado.Text;
            //        }
            //    }


            //}
            
            if (RdbSoltero.Checked)
            {
                LblEstado.Text = "Su estado civil es: " + RdbSoltero.Text;
            }
            else if (RdbCasado.Checked)
            {
                LblEstado.Text = "Su estado civil es: " + RdbCasado.Text;
            }
            else if (RdbDivoirciado.Checked)
            {
                LblEstado.Text = "Su estado civil es: " + RdbDivoirciado.Text;
            }
            else
            {
                LblEstado.Text = "Su estado civil es: " +RdbViudo.Text;
            }
        }
    }
}