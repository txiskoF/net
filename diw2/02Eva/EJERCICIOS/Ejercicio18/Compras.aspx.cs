using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio18
{
    public partial class Compras : System.Web.UI.Page
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<Productos> Libros = new List<Productos>();
                List<Productos> Tablets = new List<Productos>();
                List<Productos> Accesorios = new List<Productos>();
                Libros.Add(new Productos("imagenes/libros/kindle.jpg", "Ebook Kindle by Amazon", 89));
                Libros.Add(new Productos("imagenes/libros/bq_cervantes_touch.jpg", "BQ Cervantes Touch", 135));
                Libros.Add(new Productos("imagenes/libros/sony.jpg", "Ebook Sony PRS-T2", 155));
                Accesorios.Add(new Productos("imagenes/accesorios/cargador_rapido.jpg", "Cargador Rápido para Kindle", 45));
                Accesorios.Add(new Productos("imagenes/accesorios/funda_cervantes.jpg", "Funda para el BQ Cervantes Touch", 18));
                Accesorios.Add(new Productos("imagenes/accesorios/funda_kindle.jpg", "Funda para el Ebook Kindle", 35));
                Accesorios.Add(new Productos("imagenes/accesorios/funda_sony.jpg", "Funda para el Ebook Sony", 43));
                Accesorios.Add(new Productos("imagenes/accesorios/luz_kindle.jpg", "Luz para el Ebook Kindle", 19));
                Tablets.Add(new Productos("imagenes/tablets/acer_iconia.jpg", "Tablet Acer Iconia", 299));
                Tablets.Add(new Productos("imagenes/tablets/bq_curie.jpg", "Tablet BQ Curie", 169));
                Tablets.Add(new Productos("imagenes/tablets/galaxy.jpg", "Tablet PC Galaxy", 329));
                lblUsuario.Text = "Bienvenido " + Session["nombre"];
                ViewState["listLibros"] = Libros;
                ViewState["listAccesorios"] = Accesorios;
                ViewState["listTablets"] = Tablets;
                Session["precio"] = 0;
                Session["cantidad"] = "";
                carga(Libros);
            }
            else
            {
                lblUsuario.Text = "Bienvenido " + Session["nombre"];
                hlCesta.Text = Convert.ToInt32(Session["cesta"]).ToString();
                switch (DropDownList1.SelectedIndex)
                {
                    case 0:
                        carga((List<Productos>)ViewState["listLibros"]);
                        ViewState["Lista"] = ViewState["listLibros"];
                        break;
                    case 1:
                        carga((List<Productos>)ViewState["listAccesorios"]);
                        ViewState["Lista"] = ViewState["listAccesorios"];
                        break;
                    case 2:
                        carga((List<Productos>)ViewState["listTablets"]);
                        ViewState["Lista"] = ViewState["listTablets"];
                        break;
                }
            }
        }
        protected void carga(List<Productos> cantidad)
        {
            int i = 0;
            foreach (Productos item in cantidad)
            {
                int pos = i * 100 + 100;
                Image imgLibro = new Image();
                Label lblProducto = new Label();
                Button btnAgregar = new Button();
                imgLibro.Height = 100;
                imgLibro.Width = 100;
                imgLibro.ImageUrl = item.Ruta;
                imgLibro.Style["position"] = "absolute";
                imgLibro.Style["Left"] = "50px";
                imgLibro.Style["Top"] = pos + "px";
                Form.Controls.Add(imgLibro);
                lblProducto.Text = item.Descripcion;
                lblProducto.Style["position"] = "absolute";
                lblProducto.Style["Left"] = "200px";
                lblProducto.Style["Top"] = pos + 50 + "px";
                Form.Controls.Add(lblProducto);
                btnAgregar.Text = "Agregar a la Cesta";
                btnAgregar.ID = "btnAgregar" + i;
                btnAgregar.Style["position"] = "absolute";
                btnAgregar.Style["Left"] = "300px";
                btnAgregar.Style["Top"] = pos + 50 + "px";
                btnAgregar.Click += agregar;
                Page.Form.Controls.Add(btnAgregar);
                i += 1;
            }
        }

        public void agregar(object sender, EventArgs e)
        {
            Button elemento = (Button)sender;
            int pos = Convert.ToInt32(elemento.ID.Substring(elemento.ID.Length - 1));
            Productos prod = ((List<Productos>)ViewState["Lista"]).ElementAt(pos);
            Session["cantidad"] += prod.Descripcion + "-";
            Session["precio"] = Convert.ToDecimal(Session["precio"]) + Convert.ToDecimal(prod.Precio);

            Session["cesta"] = Convert.ToInt32(Session["cesta"]) + 1;
            hlCesta.Text = Session["cesta"].ToString();
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Server.Transfer("Autentificar.aspx");
        }
    }
}
