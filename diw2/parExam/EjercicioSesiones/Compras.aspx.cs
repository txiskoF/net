using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Default2 : System.Web.UI.Page
{
    Image imglibro;
    Label lblproducto;
   // TextBox cantidad;
    Button btnagregar;
       
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            List<Productos> LLibros = new List<Productos>();
            List<Productos> LTablets = new List<Productos>();
            List<Productos> LAccesorios = new List<Productos>();
            LLibros.Add(new Productos("imagenes/libros/kindle.jpg", "Ebook Kindle by Amazon", 89));
            LLibros.Add(new Productos("imagenes/libros/bq_cervantes_touch.jpg", "BQ Cervantes Touch", 135));
            LLibros.Add(new Productos("imagenes/libros/sony.jpg", "Ebook Sony PRS-T2", 155));
            LAccesorios.Add(new Productos("imagenes/accesorios/cargador_rapido.jpg", "Cargador Rápido para Kindle",45));
            LAccesorios.Add(new Productos("imagenes/accesorios/funda_cervantes.jpg", "Funda para el BQ Cervantes Touch", 18));
            LAccesorios.Add(new Productos("imagenes/accesorios/funda_kindle.jpg", "Funda para el Ebook Kindle", 35));
            LAccesorios.Add(new Productos("imagenes/accesorios/funda_sony.jpg", "Funda para el Ebook Sony", 43));
            LAccesorios.Add(new Productos("imagenes/accesorios/luz_kindle.jpg", "Luz para el Ebook Kindle", 19));
            LTablets.Add(new Productos("imagenes/tablets/acer_iconia.jpg", "Tablet Acer Iconia",299));
            LTablets.Add(new Productos("imagenes/tablets/bq_curie.jpg", "Tablet BQ Curie", 169));
            LTablets.Add(new Productos("imagenes/tablets/galaxy.jpg", "Tablet PC Galaxy", 329));
            lblusuario.Text = "Bienvenido " + Session["nombre"];
            ViewState["LLibros"] = LLibros;
            ViewState["LAccesorios"] = LAccesorios;
            ViewState["LTablets"] = LTablets;
            Session["precio"] = 0;
            Session["elementos"] = "";
            cargar(LLibros);

        }
        else
        {
            lblusuario.Text = "Bienvenido " + Session["nombre"];
            hlcesta.Text = Convert.ToInt32(Session["cesta"]).ToString();
            switch (DropDownList1.SelectedIndex)
            {

                case 0:
                    cargar((List<Productos>)ViewState["LLibros"]);
                    ViewState["Lista"] = ViewState["LLibros"];
                    break;
                case 1:
                    cargar((List<Productos>)ViewState["LAccesorios"]);
                    ViewState["Lista"] = ViewState["LAccesorios"];
                    break;
                case 2:
                    cargar((List<Productos>)ViewState["LTablets"]);
                    ViewState["Lista"] = ViewState["LTablets"];
                    break;
            }
        }
    }
  protected void cargar(List<Productos> elementos)
    {
        int i = 0;
        foreach (Productos item in elementos)
       
            {
        int posiciony=i*150+150;

            Image imglibro = new Image();
            Label lblproducto = new Label();
            //TextBox cantidad = new TextBox();
            Button btnagregar = new Button();
                imglibro.Height = 112;
                imglibro.Width = 92; 
                imglibro.ImageUrl = item.Ruta;
                imglibro.Style["position"]="absolute";
                imglibro.Style["z-index"]="1";
                imglibro.Style["Left"] = "10px";
                imglibro.Style["Top"] = posiciony + "px";
                Form.Controls.Add(imglibro);
              
                lblproducto.Text = item.Descripcion;
                lblproducto.Style["position"] = "absolute";
                lblproducto.Style["z-index"] = "1";
                lblproducto.Style["Left"] = "100px";
                lblproducto.Style["Top"] = posiciony+50 + "px";
                Form.Controls.Add(lblproducto);
               
                //cantidad.Width = 25;
                
                //cantidad.Style["position"] = "absolute";
                //cantidad.Style["z-index"] = "1";
                //cantidad.Style["Left"] = "300px";
                //cantidad.Style["Top"] = posiciony+50 + "px";
                //Page.Form.Controls.Add(cantidad);
              
                btnagregar.Text = "Agregar a la Cesta";
                btnagregar.ID = "btnagregar" + i;
                btnagregar.Style["position"] = "absolute";
                btnagregar.Style["z-index"] = "1";
                btnagregar.Style["Left"] = "360px";
                btnagregar.Style["Top"] = posiciony+50 + "px";
                btnagregar.Click += agregar;
                Page.Form.Controls.Add(btnagregar);
            i += 1;
        }
       
        }

  

    public void agregar(object sender, EventArgs e)
    {
        Button elemento = (Button)sender;
        int posicion=Convert.ToInt32 (elemento.ID.Substring(elemento.ID.Length -1));
        Productos elem = ((List<Productos>)ViewState["Lista"]).ElementAt(posicion);
                Session["elementos"] += elem.Descripcion + "-";
                Session["precio"] =Convert.ToDecimal(Session["precio"])+Convert.ToDecimal(elem.Precio);
                      
        Session["cesta"] = Convert.ToInt32 (Session["cesta"]) + 1;
        hlcesta.Text = Session["cesta"].ToString();
        //Response.Write(ViewState["elementos"]);
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Server.Transfer("Autentificacion.aspx");
    }

   
}
