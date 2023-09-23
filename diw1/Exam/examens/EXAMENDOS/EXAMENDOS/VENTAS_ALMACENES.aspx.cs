using DAL;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXAMENDOS
{
    public partial class Pincipal : System.Web.UI.Page
    {
        DAL_Store Dstore = new DAL_Store();
        DAL_Sale Dsale = new DAL_Sale();
        DAL_Title Dtitle = new DAL_Title();
        // Lsita de libros en memoria
        List<Title> librosVenta = new List<Title>();

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack) Cuando tiene que cargar algo la primera vez que entra
        }


        protected void txtNombreAlmacen_TextChanged(object sender, EventArgs e)
        {
            ddlAlmacenes.Items.Clear();
            ddlVentas.Items.Clear();
            lstLibros.Items.Clear();

            //A Recojo lo escrito en el txt Se lo paso a rellenar y guardo en s
            Store s = rellenarComboAlmacenes(txtNombreAlmacen.Text);
            //B cojo el id del almacen priemro se lo paso a relleanr y voy al metodo
            Sale venta = rellenarComboVentas(s.Stor_id);
            //C de la venta obtengo el ordnum llamo al metodo
            rellenarListadoLibros(venta.Ord_num);

            lblFechaVenta.Text = venta.Ord_date.ToString();

            Double total = calcularTotalVenta(s.Stor_id.ToString(), venta.Ord_num);
            lblTotalVenta.Text = total.ToString();

        }

        protected void ddlAlmacenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtengo el value del almacen selecionado
            String idAlmacen = ddlAlmacenes.SelectedValue;
            //Llamo al metodo para obtener las ventas
            List<Sale> sales = Dsale.getSales(Convert.ToInt32(idAlmacen));
           
            ddlVentas.Items.Clear();
            foreach(Sale sale in sales)
            {
                ListItem item = new ListItem(sale.Ord_num, sale.Ord_num);
                //Rellenao la lista con las ventas
                ddlVentas.Items.Add(item);
            }
        }

        private Store rellenarComboAlmacenes(String textoAlamacen)
        {
                                  //2º llamo al metodo
               // 3º guardo el resultdo del select
            List<Store> Stores = Dstore.getStores(textoAlamacen);
            //4º Recorro la lista
            foreach (Store stor in Stores)
            {
                //5º Por cada fila del List, creo un nuevo listitem con textoo y value
                ListItem item = new ListItem(stor.Stor_name, (stor.Stor_id).ToString());
                //6º Lo añado a la ddl
                ddlAlmacenes.Items.Add(item);
            }
            //7º devulevo el primero y vuelvo al principio
            return Stores.First();
        }

        private Sale rellenarComboVentas(int storeId)
        {
                                    //1º llamo al metodo con lo que me vien de arriba
            //2º me devuelve una lista de las ventas
            List<Sale> sales = Dsale.getSales(storeId);
            foreach (Sale sale in sales)
            {
                ListItem item = new ListItem(sale.Ord_num, sale.Ord_num);
                ddlVentas.Items.Add(item);
            }
                                //3º De la lista de ventas obtengo la primera llamo al metodo
            //4º La venta que he obtenido con todos los datos lo guardno en la variable
            Sale ventaCompleta = Dsale.GetSale((sales.First()).Ord_num);
            //5º la devuelvo arriba
            return ventaCompleta;
        }

        private void rellenarListadoLibros(String ordNum)
        {
                                    //Con el dato qeu me han dado llamo al metodo
            //el listado que me devuelve lo cuardo en idtitles
            List<String> idTitles = Dsale.getTitleIds(ordNum);
            foreach (String id in idTitles)
            {
                Title libro = Dtitle.GetTitle(id);
                //Crear elementos de la lista de pantalla
                //Se crea listiem se pasa el texto y el value
                ListItem liLibro = new ListItem(libro.Titulo, libro.Title_id);
                //Se añade alos items del elemento delapantalla
                lstLibros.Items.Add(liLibro);
                //Añadir elementos a unalista de memoria
                librosVenta.Add(libro);
            }
        }
   
        private double calcularTotalVenta(String stor_id, String ord_num)
        {
            double totalVenta = 0;
            foreach(Title libro in librosVenta)
            {
                int cantidad = Dsale.cantidadLibros(stor_id, ord_num, libro.Title_id);
                totalVenta += libro.Price * cantidad;
            }
            return totalVenta;
        }

        protected void lstLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            //De la lista de libros Obtner uno y sus datos
            String idLibroSeleccion = lstLibros.SelectedValue;
            String idAlmacenSeleccionado = ddlAlmacenes.SelectedValue;
            String idVentaSeleccionada = ddlVentas.SelectedValue;
                    //Llamo al metodo y le paso los valores
            //Obtengo la cantiad
            int cantidad = Dsale.cantidadLibros(idAlmacenSeleccionado, idVentaSeleccionada,
                idLibroSeleccion);
            //Le asigno al txt la cantidad vendida
            txtCantidad.Text = cantidad.ToString();
            //Llamo al metodo para obtener un Libro
            Title libro = Dtitle.GetTitle(idLibroSeleccion);
            //Del Libro obtengo el precio y lo asigno al txt
            txtPrecio.Text = libro.Price.ToString();
        }

        protected void ddlVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpio estos campos
            lstLibros.Items.Clear();
            librosVenta.Clear();
            //Obtengo el VAlue de la lista seleccionada
            String idVentaSeleccionada = ddlVentas.SelectedValue;
            //Llamo a rellenar 
            rellenarListadoLibros(idVentaSeleccionada);
            Sale venta = Dsale.GetSale(idVentaSeleccionada);
            lblFechaVenta.Text = venta.Ord_date.ToString();
            double total = calcularTotalVenta(ddlAlmacenes.SelectedValue, idVentaSeleccionada);
            lblTotalVenta.Text = total.ToString();
        }

       

        protected void btnAgregarLOV_Click(object sender, EventArgs e)
        {

            String idVentaSeleccionada = ddlVentas.SelectedValue;
            String nuevoLibro = txtNuevoLibro.Text;
            int cantidad = Convert.ToInt32(txtNuevaCantidad.Text);
            String stor_id = ddlAlmacenes.SelectedValue;
            //No retorna nada e inserto un nuevo librooen la venta
            Dsale.insertarNuevoLibro(stor_id, idVentaSeleccionada, nuevoLibro, cantidad);
            lstLibros.Items.Clear();
            librosVenta.Clear();
            rellenarListadoLibros(idVentaSeleccionada);
            txtNuevoLibro.Text = "";
            txtNuevaCantidad.Text = "";
            Double total = calcularTotalVenta(stor_id, idVentaSeleccionada);
            lblTotalVenta.Text = total.ToString(); 


        }

        protected void btnBorrarOV_Click(object sender, EventArgs e)
        {
            String stor_id = ddlAlmacenes.SelectedValue;
            String ord_num = ddlVentas.SelectedValue;
            String title_id = lstLibros.SelectedValue;
            Dsale.borrarLibro(stor_id, ord_num, title_id);
            lstLibros.Items.Clear();
            librosVenta.Clear();
            rellenarListadoLibros(ord_num);
            Double total = calcularTotalVenta(stor_id, ord_num);
            lblTotalVenta.Text = total.ToString();
            txtPrecio.Text = "";
            txtCantidad.Text = "";

        }

        protected void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            //Si es el Priimero el seleccionado
            if (RdbLMostrarDatos.SelectedIndex == 0)
            {
                //Cojo el valu del Almacen
                String stor_id = ddlAlmacenes.SelectedValue;
                //En sesion guardo "almacen"
                Session["cargar"] = "almacen";
                //En sesionguardo el storid del almacen
                Session["stor_id"] = stor_id;
                Server.Transfer("PRESENTACION_GRID.aspx");
            } else
            {
                String ord_num = ddlVentas.SelectedValue;
                Session["cargar"] = "venta";
                Session["ord_num"] = ord_num;
                Server.Transfer("PRESENTACION_GRID.aspx");
                //Cargar los datos de la venta
            }
        }

        
    }
}