using Obrero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcamenDOS
{
    public partial class Principal : System.Web.UI.Page
    {
        private string[] categorias = new string[] { "Programador", "Analista", "Jefe de Proyecto", "Programdor Junior",
                "Programador Junior-Senior", "Programador Senior", "Analista-Programador",
                "Analista Senior","Jefe de Proyecto" };
        private int[] sueldos = new int[] { 18000, 20000, 30000, 40000, 50000, 75000 };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["CodigoCliente"] = "1";
                txtnumeroE.Text = ViewState["CodigoCliente"].ToString();
                txtnombreE.Focus();
                pnlprogramador.Visible = false;
                pnlanalista.Visible = false;
                pnlsueldos.Visible = false;
                imgbsueldo.ImageUrl = "/IMAGENES/sueldo.jpg";
                txthorasextras.Visible = false;
                txtguardias.Visible = false;
                ViewState["cargo"] = "";

            }
        }

        protected void btnpesetas_Click(object sender, EventArgs e)
        {
            txtsueldobase.Text = Empleado.calculaPesetas(Convert.ToDecimal(txtsueldobase.Text));
        }

        protected void btneuros_Click(object sender, EventArgs e)
        {

        }

        protected void chklextras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txthorasextras_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtnombreE_TextChanged(object sender, EventArgs e)
        {
            txtdpto.Focus();
        }

        protected void txtdpto_TextChanged(object sender, EventArgs e)
        {
            if (txtdpto.Text == "Informatica")
            {
                txtsituacion.Text = "Zamudio Ed. 435";
                txttelefono.Text = "946541210";
            }
            else if (txtdpto.Text == "Administracion")
            {
                txtsituacion.Text = "Derio Ed. 2";
                txttelefono.Text = "946561112";
            }
            else if (txtdpto.Text == "Direccion")
            {
                txtsituacion.Text = "Derio Ed. 2";
                txttelefono.Text = "946561113";
            }
            else
            {
                txtdpto.Text = "";
                txtdpto.Focus();
            }
        }

        protected void rdblpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdblpuesto.SelectedIndex == 0)
            {
                pnlprogramador.Visible = true;
                pnlanalista.Visible = false;
                imgpuesto.ImageUrl = "/IMAGENES/programador.jpg";
            }
            else if (rdblpuesto.SelectedIndex == 1)
            {
                pnlanalista.Visible = true;
                pnlprogramador.Visible = false;
                imgpuesto.ImageUrl = "/IMAGENES/analista.jpg";
            }
            else if (rdblpuesto.SelectedIndex == 2)
            {
                pnlprogramador.Visible = false;
                pnlanalista.Visible = false;
                imgpuesto.ImageUrl = "/IMAGENES/jefe de proyecto.jpg";
            }
        }

        protected void imgbsueldo_Click(object sender, ImageClickEventArgs e)
        {
            if (rdblpuesto.SelectedIndex != -1 && (rdblprogramador.SelectedIndex != -1 || rdblanalista.SelectedIndex != -1))
            {
                pnlsueldos.Visible = true;
               
            }
        }

        protected void ObtenerSaldo ()
        {
            //Obtener el nombre del cargo
            string cargo ="";
            foreach (Control item in pnldatospersonales.Controls)
            {
                if (item is RadioButtonList)
                {
                    RadioButtonList rdbl = (RadioButtonList)item;
                    foreach (ListItem item2 in rdbl.Items)
                    {
                        if (item2.Selected)
                        {
                            cargo = item2.Value;
                        }
                    }
                }
            }

            //obtener la cantidad de saldo
            int dinero = 0;
            bool encontrado = false;
            int pos = 0;
            while (!encontrado && pos < categorias.Length)
            {
                if (categorias[pos] == cargo)
                {
                    encontrado = true;
                }
                else
                {
                    pos++;
                }
            }
            if (encontrado)
            {
                dinero = sueldos[pos];
            }

            //obtener retencion
            int retencion = 0;
            if (rdb17.Checked)
            {
                retencion = Convert.ToInt32(rdb17.Text);
                txtsueldobase.Text = dinero.ToString();
            }
            else if (rdb19.Checked)
            {
                retencion = Convert.ToInt32(rdb19.Text);
                txtsueldobase.Text = dinero.ToString();
            }
            else if (rdb21.Checked)
            {
                retencion = Convert.ToInt32(rdb21.Text);
                txtsueldobase.Text = dinero.ToString();
            }

            //obtener horasExtra
            int horasExtras = 0;
            int guardias = 0;
            //if (chkMusica.Checked)

            if (chklextras.SelectedIndex == 0)
            {
                horasExtras = Convert.ToInt32(txthorasextras.Text);
            }
            if (chklextras.SelectedIndex == 1)
            {
                guardias = Convert.ToInt32(txtguardias.Text);
            }

            txtretencion.Text = Empleado.CalcularRetencion(dinero.ToString(), retencion);

            //lblImc.Text = Calculos.IndiceMasaCorporal(Byte.Parse(txtPeso.Text), Single.Parse(txtAltura.Text)).ToString("0.##");




        }

        protected void btnreiniciar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
            int identificativo = Convert.ToInt32(ViewState["CodigoCliente"]);
            ViewState["CodigoCliente"] = identificativo + 1;
            txtnumeroE.Text = ViewState["CodigoCliente"].ToString();
            pnlanalista.Visible = false;
            pnlprogramador.Visible = false;
            pnlsueldos.Visible = false;
        }

        private void limpiarFormulario()
        {
            foreach(Control elemento in form2.Controls)
            {
                if (elemento is TextBox)
                {
                    TextBox txt = (TextBox)elemento;
                    txt.Text = "";
                }
                if (elemento is RadioButtonList)
                {
                    RadioButtonList rdbl = (RadioButtonList)elemento;
                    rdbl.SelectedIndex = -1;
                }
                if (elemento is RadioButton)
                {
                    RadioButton rdb = (RadioButton)elemento;
                    rdb.Checked = false;
                }
                if (elemento is CheckBoxList)
                {
                    CheckBoxList chk = (CheckBoxList)elemento;
                    chk.SelectedIndex = -1;
                }
                imgpuesto.ImageUrl = "";
                imgbsueldo.ImageUrl = "";
            }
        }
    }
}