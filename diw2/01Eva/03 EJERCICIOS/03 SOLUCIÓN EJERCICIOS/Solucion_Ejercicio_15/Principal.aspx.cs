using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Solucion_Ejercicio_17
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtCodigo.Focus();
                //Panel2.Visible = false;
            }
        }
        protected void txtCodigo_TextChanged(object sender, EventArgs e)
        {

            txtFechaFactura.Text = DateTime.Now.ToLongDateString();
           // txtFechaFactura.Text = DateTime.Today.ToLongDateString();
            txtImporteFactura.Focus();

        }
        protected void txtImporteFactura_TextChanged(object sender, EventArgs e)
        {
            ViewState["importe"] = txtImporteFactura.Text;
            //txtImporte.Text=Convert.ToDouble(txtImporte.Text).ToString("c");
            txtImporteFactura.Text += " €";
            btnCalcular.Focus();
        }
        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int euro = txtImporteFactura.Text.IndexOf("€");
            Factura f = new Factura
            {
                Codigo = txtCodigo.Text,
                Fecha = DateTime.Today,
                //1ªForma
               // Importe = Convert.ToDouble(txtImporteFactura.Text.Substring(0, euro - 2))
               //2ª Forma
                //Importe = Convert.ToDouble(txtImporteFactura.Text.Substring(0,txtImporte.Text.Length-2)
                //3ª Forma
                Importe = Convert.ToDouble(ViewState["importe"])
            };



            txtImporteIVA.Text = f.calcularImporte().ToString("c");

            //1ªFORMA
            //txtFechaPrimer.Text = f.calcularFecha(30).ToLongDateString();
            //txtSegundaFecha.Text = f.calcularFecha(60).ToLongDateString();
            //txtTerceraFecha.Text = f.calcularFecha(90).ToLongDateString();

            //txtPrimerImporte.Text = f.calcularPorcentaje(50).ToString("c");
            //txtSegundoImporte.Text = f.calcularPorcentaje(30).ToString("c");
            //txtTercerImporte.Text = f.calcularPorcentaje(20).ToString("c");
            
            DateTime[] resultado = f.calcularFecha();

            txtFechaPrimer.Text = resultado[0].ToLongDateString();
            txtSegundaFecha.Text = resultado[1].ToLongDateString();
            txtTerceraFecha.Text = resultado[2].ToLongDateString();

            Double[] importes = f.calcularPorcentaje();
            txtPrimerImporte.Text = importes[0].ToString("c");
            txtSegundoImporte.Text = importes[1].ToString("c");
            txtTercerImporte.Text = importes[2].ToString("c");

      


            //Panel2.Visible = true;

        }

        protected void Limpieza(Panel elPanel)
        {

            foreach (Control elemento in elPanel.Controls)
            {
                if (elemento is TextBox)
                {

                    TextBox txtelemento = (TextBox)elemento;
                    txtelemento.Text = "";

                }
            }

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            //txtCodigo.Text = "";
            // txtFechaFactura.Text = "";
            // txtImporteFactura.Text = "";
            // txtImporteIVA.Text="";
            //txtFechaPrimer.Text = "";
            // txtSegundaFecha.Text ="";
            // txtTerceraFecha.Text="";
            //txtPrimerImporte.Text = "";
            // txtSegundoImporte .Text = "";
            // txtTercerImporte.Text ="";
            // Panel2.Visible = false;

            Limpieza(Panel1);
            Limpieza(Panel2);
            txtCodigo.Focus();
        }

       

       
    }
}