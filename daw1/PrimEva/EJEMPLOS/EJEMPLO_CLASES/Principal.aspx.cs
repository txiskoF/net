using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo_Clases
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEmpleado_Click(object sender, EventArgs e)
        {
            //Creación de un empleado. Constructor Vacío. 
            //Nueva forma de escribir de C#
            Empleado emp = new Empleado
            {
                Nombre = "Marta",
                Puesto = "Profesor"
            };

            //Creación de un empleado. Constructor Vacío. 
            //Forma de siempre
            Clientes cli = new Clientes();
            cli.Nombre = "Pepe";
            cli.Apellido = "Reina";
            ;

            //Constructor con dos parámetros
           Clientes clie = new Clientes("Asier", "Rodriguez");

            ViewState["Empleado"] = emp;
            ViewState["Cliente"] = clie;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Tomar el empleado de una variable ViewState.
            //Se hace un casting sobre la clase
            Empleado emp = (Empleado)ViewState["Empleado"];
            
            //Uso del método Mostrar
            LblResultado.Text=emp.Mostrar();

            //Uso del método ToString() sobreescrito en la clase.
            LblResultado.Text = emp.ToString();
        }
    }
}