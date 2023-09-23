using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Transporte;

public partial class Compras : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Pongo el foco en el boton que deseo
        //los radiobuton y los paneles que no queir que se vean a false
        //creo la viewState para la fecha, cogiendo el acutal
        
        if (!Page.IsPostBack)
        {
            //ponog el foco en el correo el resto a false
            txtcorreo.Focus();
            
            rdbfrutas.Checked = false;
            rdbplatos.Checked = false;
            rdbverduras.Checked = false;

            pnlfrutas.Visible = false;
            pnlplatos.Visible = false;
            pnlverduras.Visible = false;

            lblmensaje.Visible = false;

            ViewState["tiempo"] = DateTime.Now;
        }

    }




    protected void txtcorreo_TextChanged(object sender, EventArgs e)
    {
        //guardo en variables el que va a ser el item de separacion
        int guion = txtcorreo.Text.IndexOf("_");
        int arroba = txtcorreo.Text.IndexOf("@");
        int punto = txtcorreo.Text.IndexOf(".");
        //hago la operacion de lo que quiero obtener
        String nombre = txtcorreo.Text.Substring(0,guion);
        String apellido = txtcorreo.Text.Substring(guion+1, arroba-guion-1);
        String organizacion = txtcorreo.Text.Substring(arroba+1,punto-arroba-1);
        //guardar en le cuador de texto el nombre como quiero
        txtnombre.Text = nombre + " " + apellido;
        txtorganizacion.Text = organizacion;
        //poner el foco donde quiero
        txtdireccion.Focus();

    }

    protected void txtdireccion_TextChanged(object sender, EventArgs e)
    {
        txtpoblacion.Focus();
    }

    //hago los paneles visibles solo como deseo que aparezcan
    protected void rdbfrutas_CheckedChanged(object sender, EventArgs e)
    {
        //muestro solo frutas
        pnlfrutas.Visible = true;
        pnlplatos.Visible = false;
        pnlverduras.Visible = false;
        //creo una viewstate en la que guardo el texto qu eme interesa 
        //que se corresponbde con la fruta
        ViewState["Clase"] = rdbfrutas.Text;
        limpiarPaneles();
    }

    protected void rdbverduras_CheckedChanged(object sender, EventArgs e)
    {
        pnlfrutas.Visible = false;
        pnlplatos.Visible = false;
        pnlverduras.Visible = true;
        ViewState["Clase"] = rdbverduras.Text;
        limpiarPaneles();
    }

    protected void rdbplatos_CheckedChanged(object sender, EventArgs e)
    {
        pnlfrutas.Visible = false;
        pnlplatos.Visible = true;
        pnlverduras.Visible = false;
        ViewState["Clase"] = "platos";
        limpiarPaneles();
    }

    //con limpiar panales limpio las selecciones
    protected void limpiarPaneles() {
        rdblfrutas.ClearSelection();
        rdblverduras.ClearSelection();
        rdblplatos.ClearSelection();
    }

    //creo un onSelectIndexChanged comun para todos los productos 
    protected void Seleccion(object sender, EventArgs e)
    {
        //una variable para la ruta con lo guardado en la anterior viestate
        string ruta = ViewState["Clase"].ToString();
        //Creo una radiobutton list
        RadioButtonList lista = (RadioButtonList)sender;
        txtcantidad.Focus();
        //del elemento seleccionado de la lista cojo el texto
        string elemento = lista.SelectedItem.Text;
        //del item seleccionado cojo el texto
        ViewState["elemento"] = lista.SelectedItem.Text;
        // Del item seleccionado cojo el value
        ViewState["valor"] = lista.SelectedValue;
        // Aimgproducto le asigno la imagen con la ruta cogida de las variable creadas
        imgproducto.ImageUrl = "IMAGENES/" + ruta + "/" +  elemento + ".jpg";
    }

   

   
    //al hacer clic en la imagen del producto
    protected void imgproducto_Click(object sender, ImageClickEventArgs e)
    {
        // La viewState que tenia con el texto del producto seleccionada la guardo en una String
        String texto = ViewState["elemento"].ToString();
        // El valor que tenia en la VieswStet lo multipiclo por la cantidad que decido y lo guaro en un double
        double valorNumerico=Convert.ToDouble(ViewState["valor"])*Convert.ToDouble(txtcantidad.Text);
        //Convierto el valor a un String
        String valor = valorNumerico.ToString() ;

        //crear una lista de item con texto y valor      
        ListItem item = new ListItem(texto, valor);
        //Cfreo una lista para buscar en la listaCesta por el valor del campo texto
        ListItem elementoBuscado=lstcesta.Items.FindByText(texto);
        //Si no esta el elemento buscacdo
        if (elementoBuscado==null)
      
        {
            //lo añado a la lista
            lstcesta.Items.Add(item);
        }
        else {
            //Al elementoBuscado el sumo su valor mas el valor numerico
            elementoBuscado.Value=(Convert.ToDouble(elementoBuscado.Value) + valorNumerico).ToString();   
        }

        txtcantidad.Text = "";
    }
   
    //habilitar  las lista de multiples selecciones o de unica seleccion
    protected void chkmultiple_CheckedChanged(object sender, EventArgs e)
    {
        // Si esta chequeada como multiple
        if (chkmultiple.Checked)
        {
            lstcesta.SelectionMode = ListSelectionMode.Multiple;
        }
        // si no esta checked como single
        else {
            lstcesta.SelectionMode = ListSelectionMode.Single;
        }
    }

    //Borrar productos
    protected void btnborrarP_Click(object sender, EventArgs e)
    {
        //Si multiples esta checked
        if (chkmultiple.Checked)
        {
            //Si hay algo seleccionado
            if (lstcesta.SelectedIndex != -1)
            {
                //Recorro la lista
                for (int i = 0; i < lstcesta.Items.Count; i++)
                {
                    //El item seleccionado 
                    if (lstcesta.Items[i].Selected)
                    {
                        //lo borro
                        lstcesta.Items.RemoveAt(i);
                        //decremento la i de la lsita
                        i--;
                    }
                }
            }
        }
        // Si no esta checked multiple
        else {
            // Hay cosas en la lista
            if (lstcesta.SelectedIndex != -1)
            {
                //Borro lo seleccionado
                lstcesta.Items.RemoveAt(lstcesta.SelectedIndex);
            }
        }
    }

    //Finalizar pedido
    protected void btnfinalizar_Click(object sender, EventArgs e)
    {
        //Duble a 0 para clacular el importe
        double importeFinal = 0;
        //por cada item que haya en la listacesta
        foreach (ListItem item in lstcesta.Items)
        {
            //Convierto el valor a double y lo agrego a la variable
            importeFinal += Convert.ToDouble(item.Value);
        }

        //Declaro una ViewState total igual al importe Final calculado
        ViewState["importeTotal"] = importeFinal;
        //en lblPrecio guardo como texto y moneda local el improte
        lblprecio.Text = importeFinal.ToString("c");
        //Uso la ViewState del principio y la guardo en duna DateTime
        DateTime antiguo = (DateTime) ViewState["tiempo"];
        //Resto el tiempo acutal del antiguo
        int tiempo = DateTime.Now.Subtract(antiguo).Seconds;
        //Guardo el tiempo qeu ha durado el pedido
        if (tiempo < 60)
        {
            lbltiempoPedido.Text = tiempo.ToString() + " segundos." ;
        }
        else if (tiempo < 3599)
        {
            lbltiempoPedido.Text = (tiempo / 60).ToString() + " minutos y " + (tiempo % 60).ToString() + " segundos.";
        }
        else {
           
               
            //Asigno a la ViewState ahora la fecha de Hoy
            ViewState["tiempo"] = DateTime.Today;

            //Dejo limpio todo lo seleccionado
            txtcorreo.Text = "";
            txtdireccion.Text = "";
            txtpoblacion.Text = "";
            txtnombre.Text = "";
            txtorganizacion.Text = "";

            rdbfrutas.Checked = false;
            rdbverduras.Checked = false;
            rdbplatos.Checked = false;

            pnlfrutas.Visible = false;
            pnlplatos.Visible = false;
            pnlverduras.Visible = false;
            limpiarPaneles();

            imgproducto.ImageUrl = "IMAGENES/Logo.jpg";

            lstcesta.Items.Clear();

            chkmultiple.Checked = false;
            lblmensaje.Visible = false;

            txtcorreo.Focus();
        }
    }

    //Al seleccionar transopte
    protected void chktransporte_CheckedChanged(object sender, EventArgs e)
    {
        //Si esta seleccionado
        if (chktransporte.Checked)
        {
            //Declaro una clase ESTATICA llamada PORTES con un metodo estatico CALCULO PORTES. Le paso la
            //poblacion y el importe total
            double importe = PORTES.Calculo_Portes(txtpoblacion.Text, Convert.ToDouble(ViewState["importeTotal"]));
            //En la viesState guardo el importe
            ViewState["importeTotal"] = importe;
            if (importe == -1)
            {
                lblmensaje.Text = "Llame al teléfono 94 6787878";
            }
            else
            //en lblmensaje pongo el importe
            {
                lblmensaje.Text = importe.ToString("c");
            }
            //hago el mensaje visible
            lblmensaje.Visible = true;
        }
        else
        {
            //Si desmarco resto los portes
            double importe = PORTES.Restar_Portes(txtpoblacion.Text, Convert.ToDouble(ViewState["importeTotal"]));
            ViewState["importeTotal"] = importe;
            if (importe == -1)
            {
                lblmensaje.Text = "";
                lblmensaje.Visible = false;
            }
            else
            {
                lblmensaje.Text = importe.ToString("c");
            }

        }
    }

    
}
    