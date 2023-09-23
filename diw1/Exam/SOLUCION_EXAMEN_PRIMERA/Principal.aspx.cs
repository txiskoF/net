using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Principal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            //PANELES VISIBLES EN EL INCIO
            PnlOfertas.Visible = true;
            PnlMarcas.Visible = true;
            PnlFactura.Visible = false;
            //delcaro viewState para ir guardadno
            ViewState["precio"] = 0;
            ViewState["elementos"] = "";
            ViewState["Marca"] = "";
        }

        //DELCARO E INICIALIZO ESTAS VARIABLES
        double precio = 0;
        string elementos = "";
        byte contador = 0;
        //VIWESTATE LO GUARDO EN marca
        string marca = ViewState["Marca"].ToString();
        //el panel ofertas contiene todos los demas paneles del inicio
        foreach (Control item in PnlOfertas.Controls)
        {
            if (item is Panel)
            {
                //declaro un pnl Panel que va a ser item
                Panel pnl = (Panel)item;
                //recorro cada pnl u guardo en item2
                foreach (Control item2 in pnl.Controls)
                {
                    //si es una Checkboxlist
                    if (item2 is CheckBoxList)
                    {
                        CheckBoxList chkl = (CheckBoxList)item2;
                        //recorro cada chklist guardo en un item tipo listitem
                        foreach (ListItem item3 in chkl.Items)
                        {
                            //si esta selccionado en esa listitem
                            if (item3.Selected)
                            {
                                contador += 1;
                                precio += Convert.ToDouble(item3.Value);
                                elementos += item3.Text + "<BR>";
                                int espacio = item3.Text.IndexOf(" ");
                                string Nombre_Imagen = item3.Text.Substring(0, espacio);
                                Image ImgProducto = new Image();
                                //si el iddel panel es el de pnlojos
                                if (pnl.ID=="PnlOjos")
                                {
                                    ImgProducto.ImageUrl = "IMAGENES/OJOS/" + Nombre_Imagen + "_OJOS" + ".jpg";
                                    ImgProducto.Width = 50;
                                    ImgProducto.Height = 70;
                                    PhOjos.Controls.Add(ImgProducto);
                                    
                                }
                                else
                                {
                                    ImgProducto.ImageUrl = "IMAGENES/" + marca + "/" + Nombre_Imagen + "_" + marca + ".jpg";
                                    ImgProducto.Width = 50;
                                    ImgProducto.Height = 70;
                                    PhCompras.Controls.Add(ImgProducto);

                                }
                               
                              
                            }
                        }
                    }
                  

                }

            }
        }

        //guardo las variables en una ViewState
        ViewState["precio"] = precio;
        ViewState["elementos"] = elementos;
        ViewState["numeroproductos"] = contador;

    }



    protected void PasarFoco(object sender, EventArgs e)
    {
        //declaro variable TxtFoco de tipo TextBox
        TextBox TxtFoco = (TextBox)sender;
        //el txtfoco sera el que coja del id de cada txt
        switch (TxtFoco.ID)
        {
            case "TxtNombre":
                TxtCorreo.Focus();
                       break;
                //si esta en correo
            case "TxtCorreo":
                //celcaro un idexof para @
                int posicion = TxtCorreo.Text.IndexOf("@");
                if (posicion==-1)
                {
                    //si no hay texto en el cuadro mantengo en el el foco
                    TxtCorreo.Text = String.Empty;
                    TxtCorreo.Focus();
                    //si ahy texto paso el focus a movil
                }else
                {
                    TxtMovil.Focus();
                }
                //if (TxtCorreo.Text.Contains("@"))
                //{
                //    TxtMovil.Focus();
                //}else
                //{
                //    TxtCorreo.Text = String.Empty;
                //    TxtCorreo.Focus();
                //}
                break;
            case "TxtMovil":
                TxtDireccionE.Focus();
                break;
            case "TxtDireccionE":
                TxtCPE.Focus();
                break;
            case "TxtCPE":
                TxtPoblacionE.Focus();
                break;
            case "TxtPoblacionE":
                TxtProvinciaE.Focus();
                break;
        }
    }

    //delpanel marcas inicalmente visible una marca
    protected void RdblMarcas_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RdblMarcas.SelectedIndex==0)
        {
            //si esta marcada las otras ocultas y guardo en la viewstate
            PnlClarins.Visible = true;
            PnlLancome.Visible = false;
            PnlShiseido.Visible = false;
            ViewState["Marca"] = "CLARINS";
        }
        else if (RdblMarcas.SelectedIndex == 1)
        {
            PnlClarins.Visible = false;
            PnlLancome.Visible = true;
            PnlShiseido.Visible = false;
            ViewState["Marca"] = "LANCOME";
        }
        else if (RdblMarcas.SelectedIndex == 2)
        {
            PnlClarins.Visible = false;
            PnlLancome.Visible = false;
            PnlShiseido.Visible = true;
            ViewState["Marca"] = "SHISEIDO";
        }
        //panelojos siempre visible igual que comprar
        PnlOjos.Visible = true;
        BtnComprar.Visible = true;
    }

    //si esta visible el PanelClarins
    protected void ChklClarins_SelectedIndexChanged(object sender, EventArgs e)
    {
        //DECLARO UNA MATRIZ QUE TENDRA LA RUTA A CADA UNA DE LAS IAMGENS DEL PRODUCTO
    //    string[] rutaClarins = new string[] { "IMAGENES/CLARINS/Maquillaje_CLARINS.jpg", "IMAGENES//CLARINS/Colorete_CLARINS.jpg", "IMAGENES//CLARINS/Labios_CLARINS.jpg" };
        //DECLARO ESTA VARIABLE PARA GUARDAR LO QUE GUARDE EN LA VIESSTAtE
    //    string elementos = ViewState["elementos"].ToString();
    //    double precio =Convert.ToDouble( ViewState["precio"]);
            //RECORRO LA CHLIST
    //    for (int i = 0; i < ChklClarins.Items.Count; i++)
    //    {
    //      DE LO QUE ESTE SELECCIONADO
    //        if (ChklClarins.Items[i].Selected)
    //        {
    //          COJO SU VALUE Y LO UGARDO EN PRECIO
    //            precio += Convert.ToDouble(ChklClarins.Items[i].Value);
    //          COJO EL TEXT Y LO GUARDO EN ELEMENTOS
    //            elementos += ChklClarins.Items[i].Text;
    //                      CREO UNA VARIABLE DE TIPO IMAGE
    //            Image ImgProducto = new Image();
    //                  SEGUN SU POSICION GUARDOIMAGEURL DEIMGPRODUCTO
    //            ImgProducto.ImageUrl = rutaClarins[i];
    //            ImgProducto.Width = 50;
    //            ImgProducto.Height = 70;
    //                  AÑADO A PNLCOMPRAS LA IMG DEL PRODUCOT SELECIONADO
    //            PhCompras.Controls.Add(ImgProducto);
    //        }
    //    }
    //              ACTUALIZO LAS VIEWSTATE
    //    ViewState["precio"] = precio;
    //    ViewState["elementos"] = elementos;
       
    }

    protected void ChklLancome_SelectedIndexChanged(object sender, EventArgs e)
    {
        //string[] rutaLancome = new string[] { "IMAGENES/LANCOME/Maquillaje_LANCOME.jpg", "IMAGENES/LANCOME/Colorete_LANCOME.jpg", "IMAGENES/LANCOME/Labios_LANCOME.jpg" };

        //string elementos = ViewState["elementos"].ToString();
        //double precio = Convert.ToDouble(ViewState["precio"]);
        //for (int i = 0; i < ChklLancome.Items.Count; i++)
        //{
        //    if (ChklLancome.Items[i].Selected)
        //    {
        //        precio += Convert.ToDouble(ChklLancome.Items[i].Value);
        //        elementos += ChklClarins.Items[i].Text;
        //        Image ImgProducto = new Image();
        //        ImgProducto.ImageUrl = rutaLancome[i];
        //        ImgProducto.Width = 50;
        //        ImgProducto.Height = 70;
        //        PhCompras.Controls.Add(ImgProducto);
        //    }
        //}
        //ViewState["precio"] = precio;
        //ViewState["elementos"] = elementos;
    }

    protected void ChklOjos_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void BtnSeguirComprando_Click(object sender, EventArgs e)
    {
        //SI SIGO COMPRANDO SE SIGUE MOSTRANO EL PNLOFERTAS
        PnlFactura.Visible = false;
        PnlOfertas.Visible = true;
    }


    protected void BtnEnviarCompra_Click(object sender, EventArgs e)
    {
        
        //al enviar la compra limpio todo
        foreach (Control item in form1.Controls)
        {
            if (item is TextBox)
            {
                TextBox TxtCuadro = (TextBox)item;
                TxtCuadro.Text = String.Empty;
            }

        }
        TxtNombre.Focus();
        ChklClarins.ClearSelection();
        ChklLancome.ClearSelection();
        ChklOjos.ClearSelection();
        ChklShiseido.ClearSelection();
        RdblMarcas.ClearSelection();
        PnlOfertas.Visible = true;
        PnlMarcas.Visible = true;
        PnlFactura.Visible = false;
        PnlClarins.Visible = false;
        PnlLancome.Visible = false;
        PnlShiseido.Visible = false;
        PnlOjos.Visible = false;
        ViewState["precio"] = 0;
        ViewState["elementos"] = "";
        ViewState["Marca"] = "";
        PhRegalo.Controls.Clear();
        PhCompras.Controls.Clear();
        PhOjos.Controls.Clear();

    }

    protected void BtnComprar_Click(object sender, EventArgs e)
    {
        //cuadno voy a comprar todo lo que he guardado en la viesste lo paso a una varible
        double precio =Convert.ToDouble( ViewState["precio"]);
        //hago visible factura oculto ofertas
        PnlFactura.Visible = true;
        PnlOfertas.Visible = false;
        Label viesster de productos la paso a vaiable
        byte NumProductos = Convert.ToByte(ViewState["numeroproductos"]);
        //condiciones de la compra
        if (precio<60)
        {
            LblCompra.Style["color"] = "red";
            LblCompra.Style["font-weigth"] = "bold";
            LblCompra.Text = "El precio de los productos es: " + precio + "€. <BR>";
            LblCompra.Text += "Si supera los 60€ le obsequiaremos con un lipstick rouge totalmente gratis.";
        }
        else if (precio>=60 && precio<100)
        {
            LblCompra.Style["color"] = "red";
            LblCompra.Style["font-weigth"] = "bold";
            LblCompra.Text = "El precio de los productos es: " + precio + "€. <BR>";
            LblCompra.Text += "Si supera los 100€ le obsequiaremos con el perfume La vie est belle totalmente gratis.";

        }
        else
	    {
            LblCompra.Style["color"] = "black";
            LblCompra.Style["font-weigth"] = "normal";
            LblCompra.Text = "Sus productos son:";
            LblCompra.Text += ViewState["elementos"].ToString();
            if (NumProductos==12)
            {

                LblCompra.Text += "El precio de los productos es:" + precio*0.90 + "€.";
                precio=precio*0.90;
            }
            else { LblCompra.Text += "El precio de los productos es:" + precio + "€."; }
       
        }
        ViewState["precio"] = precio;

    }

    protected void BtnFinalizarCompra_Click(object sender, EventArgs e)
    {
        string elementos = ViewState["elementos"].ToString();
        double precio = Convert.ToDouble(ViewState["precio"]);
        //creo la factura en ejecucion
        PnlFactura.Visible = true;
        PnlOfertas.Visible = false;
        LblCompra.Text = "CLIENTE <hr>";
        LblCompra.Text += "<strong>Nombre:</strong>" + TxtNombre.Text;
        LblCompra.Text += "<strong>Teléfono:</strong>" + TxtMovil.Text;
        LblCompra.Text += "<strong>Dirección de Envío:</strong>" ;
        LblCompra.Text += "<hr>";
        LblCompra.Text += TxtDireccionE.Text + "<BR>";
        LblCompra.Text += TxtCPE.Text + "<BR>" + TxtPoblacionE.Text + "<BR>";
        LblCompra.Text += TxtProvinciaE.Text + "<BR>";
        LblCompra.Text += "<strong>Compras Realizadas:</strong>";
        LblCompra.Text += "<hr>";
        LblCompra.Text += elementos + "<BR>";
        LblCompra.Text += "IMPORTE TOTAL" + precio + "€.";

        if (precio>60 && precio<100)
        {
            Image ImgRegalo = new Image();
            ImgRegalo.ImageUrl = "IMAGENES/REGALOS/Perfilador_labios.jpg";
            ImgRegalo.Width = 50;
            ImgRegalo.Height = 70;
            PhRegalo.Controls.Add(ImgRegalo);
        }
        else if (precio>100)
        {
            Image ImgRegalo = new Image();
            ImgRegalo.ImageUrl = "IMAGENES/REGALOS/Perfume_La_vie_est_Belle.jpg";
            ImgRegalo.Width = 50;
            ImgRegalo.Height = 70;
            PhRegalo.Controls.Add(ImgRegalo);

        }



    }
}