using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Solucion_Ejercicio_16
{
    public partial class Principal : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblCuadro.Visible = false;
            }
        }
        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            lblCuadro.Visible = true;
            Empresa emp = new Empresa();
            emp.Identificativo = txtIdentificativo.Text;
            emp.Nombre = txtNombre.Text;
            emp.FechaNacimiento = Convert.ToDateTime(txtNacimiento.Text);
            emp.FechaContrato = Convert.ToDateTime(txtContrato.Text);
            emp.Empleo = Convert.ToDouble(rdblPuesto.SelectedValue);
            emp.Cotizacion = Convert.ToDouble(rdblCotizacion.SelectedValue);

            //Empresa emp1 = new Empresa
            //{
            //    Identificativo = txtIdentificativo.Text,
            //    Nombre = txtNombre.Text,
            //    FechaNacimiento = Convert.ToDateTime(txtNacimiento.Text),
            //    FechaContrato = Convert.ToDateTime(txtContrato.Text),
            //    Empleo = Convert.ToDouble(rdblPuesto.SelectedValue),
            //    Cotizacion = Convert.ToDouble(rdblCotizacion.SelectedValue)
            //};
            int añosEdad = emp.calcularAnios(emp.FechaNacimiento);
            int añosContrato = emp.calcularAnios(emp.FechaContrato);



         
            double salarioMensual = emp.salarioMensual();
            double salarioNetoAnual = emp.calcularSalarioNeto();
            double pagas = emp.calcularPagasExtras();
           


            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            lblCuadro.Text = "<b>SALARIO  " + emp.Identificativo + "   EMPLEADO   - " + emp.Nombre + " - " + añosEdad + "(EDAD)  -  " + añosContrato + "(EMPRESA)</b>";

            for (int i = 0; i < meses.Length; i++)
            {
                if (i == 5 || i == 11)
                {
                    lblCuadro.Text += "<BR/>" +  "<b> EXTRA" + meses[i] + "</b>" + pagas.ToString("c") + " cantidad a pagar el " + "15 de " + meses[i] + " de  " + DateTime.Now.Year;
                }

                lblCuadro.Text += "</br><b>Salario " + meses[i] + "    </b>" + salarioMensual.ToString("c") + " cantidad a pagar el " + "28 de " + meses[i] + DateTime.Now.Year;

            }

            lblCuadro.Text += "<BR/>" + "<b>SALARIO NETO ANUAL: </b>" + salarioNetoAnual.ToString("c");


            if (añosEdad > 55 && añosContrato > 25)
            {
                double pagasContinuidad = pagas * 5;
                lblCuadro.Text += "<br /><b>PREMIO CONTINUIDAD</b>" + pagasContinuidad.ToString("c");
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtContrato.Text = "";
            txtIdentificativo.Text = "";
            txtNacimiento.Text = "";
            txtNombre.Text = "";
            lblCuadro.Visible = false;
        }

        protected void txtIdentificativo_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNacimiento.Focus();
        }

        protected void txtNacimiento_TextChanged(object sender, EventArgs e)
        {
            txtContrato.Focus();
        }

        protected void txtContrato_TextChanged(object sender, EventArgs e)
        {
            btnCalcular.Focus();
        }

        protected void rdblCotizacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}