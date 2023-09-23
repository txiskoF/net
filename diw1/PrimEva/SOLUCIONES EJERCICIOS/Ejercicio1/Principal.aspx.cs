using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio1
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // Asignar a controles de servidor(<asp:.....>) eventos resuletos en Cliente (javascript)
            BtnEscribe.Attributes.Add("onmouseover", "cambiar1('BtnEscribe')");
            BtnEscribe.Attributes.Add("onmouseout", "cambiar2('BtnEscribe')");
            BtnColor.Attributes.Add("onmouseover", "cambiar1('BtnColor')");
            BtnColor.Attributes.Add("onmouseout", "cambiar2('BtnColor')");
            BtnLetra.Attributes.Add("onmouseover", "cambiar1('BtnLetra')");
            BtnLetra.Attributes.Add("onmouseout", "cambiar2('BtnLetra')");
            BtnFondo.Attributes.Add("onmouseover", "cambiar1('BtnFondo')");
            BtnFondo.Attributes.Add("onmouseout", "cambiar2('BtnFondo')");
            BtnLimpiar.Attributes.Add("onmouseover", "cambiar1('BtnLimpiar')");
            BtnLimpiar.Attributes.Add("onmouseout", "cambiar2('BtnLimpiar')");
        }

        protected void BtnEscribe_Click(object sender, EventArgs e)
        {
            //ASignar a la propiedad Text (escribe en la etiqueta) de LblMensaje 
            //el texto asignado a la derecha del signo =
            LblMensaje.Text = "Marta Torre - DAW 2º";
        }

        protected void BtnFondo_Click(object sender, EventArgs e)
        {
            //Cambiamos propiedades de estilo (css) -color de fondo -
            //de la Label LblMensaje
            //y de un div denominado etiqueta 
            LblMensaje.Style["background"] = "lightblue";
            etiqueta.Style["background"] = "lightblue";

        }

        protected void BtnLetra_Click(object sender, EventArgs e)
        {
            //Cambiamos Tipo de letra de la Label LblMensaje
            LblMensaje.Font.Name = "Calibri";
        }

        protected void BtnTamaño_Click(object sender, EventArgs e)
        {
            //Cambiamos Tamaño de letra de la Label LblMensaje
            LblMensaje.Font.Size = FontUnit.Point(14);
        }

        protected void BtnColor_Click(object sender, EventArgs e)
        {
            //Cambiamos estilo (css) - color de letra - de la Label LblMensaje
            LblMensaje.Style["color"] = "red";
        }

        protected void BtnLimpiar_Click(object sender, EventArgs e)
        {
            //Reiniciamos todo como estaba
            // Ponemos Texto inicial a la Label LblMensaje
            //Establecemos los colores de fondo iniciales
            //Establecemos el color de letra Inicial
           // Ponemos la fuente y el tamaño de la fuente Inicial 
            LblMensaje.Text = "Texto de Muestra";
            LblMensaje.Style["background"] = "#4b6c9e";
            etiqueta.Style["background"] = "#4b6c9e";
            LblMensaje.Style["color"] = "white";
            LblMensaje.Font.Size = FontUnit.Point(12);
            LblMensaje.Font.Name = "Arial";

        }
    }
}