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
        /
        if (!Page.IsPostBack) {
            //Declaro una ViewState a 1
            ViewState["CodigoCliente"] = "1";
            //El panel dede ticket la hago invisible
            pnlTicket.Visible = false;
            //guardo en el codigo el valor de la ViewState
            txtCodigo.Text = ViewState["CodigoCliente"].ToString();
            //En el txt de fotografia pongo la ruta inicial 
            txtRutaFotografia.Text = "Imagenes/";
            //foco al tctnombre
            txtNombre.Focus();
        
        }
    }
    //En le campo nombre cliente
    protected void txtNombre_TextChanged(object sender, EventArgs e)
    {
        //ÇDefino los valores que seran clave para obtener nombre
        int espacio = txtNombre.Text.IndexOf(" ");
        //calculo los nombres
        string nombre = txtNombre.Text.Substring(0, espacio);
        string Apellido = txtNombre.Text.Substring(espacio + 1);
        //contruyo la ruta a la fotografia con los datos obtenidos
        txtRutaFotografia.Text += nombre + "_" + Apellido + ".jpg";
        //conla ruta coloc la foto correspondiente
        imgFotografia.ImageUrl = txtRutaFotografia.Text;
        //foco a fecha nacimiento
        txtFechaNacimiento.Focus();
    }
    //btn limpoar llama a limpiar formularip
    protected void btnLimpiar_Click(object sender, EventArgs e)
    {
        limpiarFormulario();
    }

    protected void limpiarFormulario()
    {
        //recorro el pnlDatospersonalesy de sus controles
        foreach (Control elemento in pnlDatosPersonales.Controls)
        {
            //si es una textbox
            if (elemento is TextBox)
            {
                //lo poongo vacio
                TextBox txt = (TextBox)elemento;
                txt.Text = "";
            }
            //codigo de la view state
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
        //cojo el text de la fecha nacimiento lo convierto da datetime y lo guardo en fechaNcto
         DateTime fechaNcto=Convert.ToDateTime(txtFechaNacimiento.Text);
        //declaro
        string sexo;
        //declaro
	int cargosMenores,cargosMayores;
        //el que este seleccionado lo guardo
        sexo=(rdbHombre.Checked)? "Hombre" : "Mujer";
        //si esta seleccionado 
        if (txtCargosMenores.Text != "")
            //cojo el texto y lo guardo en variable
            cargosMenores = Convert.ToInt32(txtCargosMenores.Text);
        else
            // y mnores pongo a 0
            cargosMenores = 0;
        //lo guardo en menores
        if (txtCargosMayores.Text != "")
            cargosMayores=Convert.ToInt32(txtCargosMayores.Text);
        else
            cargosMayores = 0;
        //declaro un string y lo pongo vacio
        string actividades="";
        //declaro un int a 0
        int numeroactividades=0;
        //recorro la chklist de actividades
        foreach (ListItem elemento in chklActividades.Items)
        {
            //si hay elemento seleccionado
            if (elemento.Selected)
            {
                //actualizo la variable
                actividades += elemento.Value  + " ";
                //aumenot el numero actividades
                numeroactividades += 1;
            }
        }
        //recojo el value seleccionado en laradiobutonlist de entrada convertido a int32 en entrada
        int entrada=Convert.ToInt32(rdblEntradas.SelectedValue);
        //genero un nuevo cliente con laspropiedades recogidas del pnlDatos personales
        Cliente cli = new Cliente(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, fechaNcto, sexo, cargosMenores, cargosMayores, actividades, entrada);
        //Si no esta chekado chkticket
        if (!chkTicket.Checked)
            //muestro el precio del ticket en el boton generar
            btnGenerar.Text = cli.calcularTarifa().ToString("c");
        else
            //si esta marchado chkticket desparecen unos panls y se muetra otro
            pnlactividades.Visible = false;
        pnlDatosPersonales.Visible = false;
        pnlTicket.Visible = true;
        //declaro un String vacio
        string tipo="";
        //Obtengo la fecha de hoy y la meto en una Date Time
        DateTime fechaCaducidad=DateTime.Today;
          //Hago un switch con el Objeto cli
          //con el tipo de entrada ycalculo las combinaciones
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
        //Coloco el texto correspondiente al ticket recogiedno los datos de CLI y con los calculos recien hechos
            txtTicket.Text = "MODALIDAD - " + cli.Actividades.PadRight(10) + tipo.PadLeft(40) + "\n\n";
            txtTicket.Text += cli.Nombre.ToUpper().PadRight(20) + "Número Beneficiarios " + (cli.CargosMenores + cli.CargosMayores).ToString ().PadLeft(5) + "\n\n";
            txtTicket.Text +=  "Fecha Caducidad".PadRight (20) + fechaCaducidad.ToLongDateString ().PadLeft (5) + "\n\n" ;
            txtTicket.Text += "Precio del Ticket: ".PadLeft(55) + (cli.calcularTarifa() * numeroactividades).ToString("c") + "\n";
            txtTicket.Text +=  "\n";

    }
    protected void btnImprimir_Click(object sender, EventArgs e)
    {
        //Limpio le formulario
        limpiarFormulario();
        //Guardo el codigoCliente en un INT
        int identificativo=Convert.ToInt32(ViewState["CodigoCliente"]);
        //Aumento el codigoCleinte en 1
        ViewState["CodigoCliente"] = identificativo + 1;
        //Pongo en txtCodigo el codigo claculado
        txtCodigo.Text = ViewState["CodigoCliente"].ToString();
        //panles como al principio
        pnlDatosPersonales.Visible = true;
        pnlactividades.Visible = true;
        txtTicket.Text = "";
        pnlTicket.Visible = false;
    }
    protected void agregar(object sender, EventArgs e)
    {
        //Si pulso el boton agregar recojo lo que hay en el txtnuevaActivicd y lo añado a la chklist
        chklActividades.Items.Add(txtnuevaActividad.Text);
    }
}
  