using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) {
            ViewState["CodigoCliente"] = "1";
            pnlTicket.Visible = false;
            txtCodigo.Text = ViewState["CodigoCliente"].ToString();
            txtRutaFotografia.Text = "Imagenes/";
            txtNombre.Focus();
        
        }
    }
    protected void txtNombre_TextChanged(object sender, EventArgs e)
    {
        int espacio = txtNombre.Text.IndexOf(" ");
        string nombre = txtNombre.Text.Substring(0, espacio);
        string Apellido = txtNombre.Text.Substring(espacio + 1);
        txtRutaFotografia.Text += nombre + "_" + Apellido + ".jpg";
        imgFotografia.ImageUrl = txtRutaFotografia.Text;
        txtFechaNacimiento.Focus();
    }
    protected void btnLimpiar_Click(object sender, EventArgs e)
    {
        limpiarFormulario();
    }
    protected void limpiarFormulario()
    {
        foreach (Control elemento in pnlDatosPersonales.Controls)
        {
            if (elemento is TextBox)
            {
                TextBox txt = (TextBox)elemento;
                txt.Text = "";
            }
            txtCodigo.Text = ViewState["CodigoCliente"].ToString();
            txtRutaFotografia.Text = "Imagenes/";
            rdbHombre.Checked = false;
            rdbMujer.Checked = false;
            chkmenores.Checked = false;
            chkmayores.Checked = false;
            chklActividades.SelectedIndex = -1;
            rdblEntradas.SelectedIndex = -1;
            chkTicket .Checked=false;
            imgFotografia.ImageUrl = "";
        }
    }
    protected void btnGenerar_Click(object sender, EventArgs e)
    {
         DateTime fechaNcto=Convert.ToDateTime(txtFechaNacimiento.Text);
        string sexo;
	int cargosMenores,cargosMayores;
        sexo=(rdbHombre.Checked)? "Hombre" : "Mujer";
        if (txtCargosMenores.Text != "")
            cargosMenores = Convert.ToInt32(txtCargosMenores.Text);
        else
            cargosMenores = 0;
        if (txtCargosMayores.Text != "")
            cargosMayores=Convert.ToInt32(txtCargosMayores.Text);
        else
            cargosMayores = 0;
        string actividades="";
        int numeroactividades=0;
        foreach (ListItem elemento in chklActividades.Items)
        {
            if (elemento.Selected)
            {
                actividades += elemento.Value  + " ";
                numeroactividades += 1;
            }
        }
        int entrada=Convert.ToInt32(rdblEntradas.SelectedValue);
        Cliente cli = new Cliente(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, fechaNcto, sexo, cargosMenores, cargosMayores, actividades, entrada);
        if (!chkTicket.Checked)
            btnGenerar.Text = cli.calcularTarifa().ToString("c");
        else
            pnlactividades.Visible = false;
        pnlDatosPersonales.Visible = false;
        pnlTicket.Visible = true;
        string tipo="";
        DateTime fechaCaducidad=DateTime.Today;
          
            switch (cli.TipoEntrada) {
                case 0:
                    tipo = "ENTRADA DE DIA";
                    fechaCaducidad=DateTime.Today; 
                    break;
                case 1:
                    tipo = "BONO 5";
                    fechaCaducidad=DateTime.Today.AddMonths (3); 
                    break;
                case 2:
                    tipo = "BONO 10";
                    fechaCaducidad=DateTime.Today.AddMonths (6); 
                    break;
                case 3:
                    tipo = "BONO MENSUAL";
                    fechaCaducidad=DateTime.Today.AddMonths (1);  
                    break;
                case 4:
                    tipo = "BONO ANUAL";
                    fechaCaducidad=DateTime.Today.AddYears (1); 
                    break;
            
            
            }
            txtTicket.Text = "MODALIDAD - " + cli.Actividades.PadRight(10) + tipo.PadLeft(40) + "\n\n";
            txtTicket.Text += cli.Nombre.ToUpper().PadRight(20) + "Número Beneficiarios " + (cli.CargosMenores + cli.CargosMayores).ToString ().PadLeft(5) + "\n\n";
            txtTicket.Text +=  "Fecha Caducidad".PadRight (20) + fechaCaducidad.ToLongDateString ().PadLeft (5) + "\n\n" ;
            txtTicket.Text += "Precio del Ticket: ".PadLeft(55) + (cli.calcularTarifa() * numeroactividades).ToString("c") + "\n";
            txtTicket.Text +=  "\n";

    }
    protected void btnImprimir_Click(object sender, EventArgs e)
    {
        limpiarFormulario();
        int identificativo=Convert.ToInt32(ViewState["CodigoCliente"]);
        ViewState["CodigoCliente"] = identificativo + 1;
        txtCodigo.Text = ViewState["CodigoCliente"].ToString();
        pnlDatosPersonales.Visible = true;
        pnlactividades.Visible = true;
        txtTicket.Text = "";
        pnlTicket.Visible = false;
    }
    protected void agregar(object sender, EventArgs e)
    {
        chklActividades.Items.Add(txtnuevaActividad.Text);
    }
}
  