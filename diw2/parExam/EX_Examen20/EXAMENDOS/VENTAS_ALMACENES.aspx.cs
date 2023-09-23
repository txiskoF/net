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

        //HAGO BUSQUEDA POR NOMBRE QUE INTRODUZCA
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

        private Store rellenarComboAlmacenes(String textoAlamacen)
        {
            //2º llamo al metodo del DAOStore
            // 3º guardo el resultdo del select del DAO
            List<Store> Stores = Dstore.getStores(textoAlamacen);
            //4º Recorro la lista obtenida
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

        //SELECCIONO EL ALMACEN
        protected void ddlAlmacenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtengo el value del almacen selecionado
            String idAlmacen = ddlAlmacenes.SelectedValue;
            //Llamo al metodo de DAOSale para obtener las ventas
            List<Sale> sales = Dsale.getSales(Convert.ToInt32(idAlmacen));
           
            ddlVentas.Items.Clear();
            //por cada linea de la lista guardo una linea de la ddl de ventas
            foreach(Sale sale in sales)
            {
                ListItem item = new ListItem(sale.Ord_num, sale.Ord_num);
                //Rellenao la lista con las ventas
                ddlVentas.Items.Add(item);
            }
        }

        //SELECCIONO LA ORDEN DE VENTA QUE QUIERA VER SUS LISBROS
        protected void ddlVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpio estos campos
            lstLibros.Items.Clear();
            librosVenta.Clear();
            //Obtengo el VAlue de la lista seleccionada obtengo el value
            String idVentaSeleccionada = ddlVentas.SelectedValue;
            //Llamo a rellenar y pinto en pantalla
            rellenarListadoLibros(idVentaSeleccionada);
            //Llamo al emtodo de DAOSale
            Sale venta = Dsale.GetSale(idVentaSeleccionada);
            //pinto la fecha de venta
            lblFechaVenta.Text = venta.Ord_date.ToString();
            //llamo al metodo calcularTotal para saber la suma de todo paso idAlmacen e idVenta
            double total = calcularTotalVenta(ddlAlmacenes.SelectedValue, idVentaSeleccionada);
            //pinto la cantidad total de venta
            lblTotalVenta.Text = total.ToString();
        }

                //LISTADO DE LIBROS DE UNA ORDEN DE VENTA
                private void rellenarListadoLibros(String ordNum)
                {
                    //Con el dato qeu me han dado llamo al metodo de DAOSale
                    //el listado que me devuelve lo cuardo en idtitles
                    List<String> idTitles = Dsale.getTitleIds(ordNum);
                    //Recorro la lista
                    foreach (String id in idTitles)
                    {
                        //segun id obtengo el titulo
                        Title libro = Dtitle.GetTitle(id);
                        //Crear elementos de la lista de pantalla
                        //Se crea 1 listiem se pasa el texto y el value que sera el titleid
                        ListItem liLibro = new ListItem(libro.Titulo, libro.Title_id);
                        //Se añade alos items del elemento delapantalla
                        lstLibros.Items.Add(liLibro);
                        //Añadir elementos a unalista de memoria
                        librosVenta.Add(libro);
                    }
                }
                            //CALCULAR EL TOTAL DE LA VENTA
                            //recibo el idAlmacen y el idVenta
                            private double calcularTotalVenta(String stor_id, String ord_num)
                            {
                                    //inicializo a 0
                                double totalVenta = 0;
                                    //de la lista librosVeenta la recorro
                                    //por cada libro de la lista obtengo
                                foreach (Title libro in librosVenta)
                                {
                                        //llamo al DAOSale catidadlibros de cada libro
                                    int cantidad = Dsale.cantidadLibros(stor_id, ord_num, libro.Title_id);
                                        //actualizo
                                    totalVenta += libro.Price * cantidad;
                                }
                                //devuelvo la cantiad total
                                return totalVenta;
                            }
        //SELECCIONO UN LIBRO DE LA LISTA DE LIBROS
        protected void lstLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            //De la lista de libros obtener el valu del seleccionado
            String idLibroSeleccion = lstLibros.SelectedValue;
            //obtner el value seleccionado del almacen
            String idAlmacenSeleccionado = ddlAlmacenes.SelectedValue;
            //obtener el value de la venta selecionada
            String idVentaSeleccionada = ddlVentas.SelectedValue;
            //Llamo al metodo DAOSale y le paso los valores
            //Obtengo la cantiad de libros vendidos
            int cantidad = Dsale.cantidadLibros(idAlmacenSeleccionado, idVentaSeleccionada,
                idLibroSeleccion);
            //Le asigno al txt la cantidad vendida
            txtCantidad.Text = cantidad.ToString();
            //Llamo al metodo para obtener titulo Libro
            Title libro = Dtitle.GetTitle(idLibroSeleccion);
            //Del Libro obtengo el precio y lo asigno al txt
            txtPrecio.Text = libro.Price.ToString();
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

        //borrar un libro de orden de venta
        protected void btnBorrarOV_Click(object sender, EventArgs e)
        {
            //cojo el value de lo seleccionado
            String stor_id = ddlAlmacenes.SelectedValue;
            String ord_num = ddlVentas.SelectedValue;
            String title_id = lstLibros.SelectedValue;
            //llamo a este metodo y paso los datos
            Dsale.borrarLibro(stor_id, ord_num, title_id);
            //limpio
            lstLibros.Items.Clear();
            librosVenta.Clear();
            //rellenar listado de libros
            rellenarListadoLibros(ord_num);
            //hago el calculo de como queda la nueva venta
            Double total = calcularTotalVenta(stor_id, ord_num);
            //pongo los datos
            lblTotalVenta.Text = total.ToString();
            txtPrecio.Text = "";
            txtCantidad.Text = "";

        }


        //PARA MOSTRAR EN EL GRID LOS DATOS
        protected void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            //Si selecciono Alamcen
            if (RdbLMostrarDatos.SelectedIndex == 0)
            {
                //Cojo el valu del Almacen seleccionado de la ddl
                String stor_id = ddlAlmacenes.SelectedValue;
                //En sesion guardo "almacen"  para hacer una u otra cosa necdesitare pasarlo
                Session["cargar"] = "almacen";
                //En sesionguardo el storid del almacen necesitare pasarlo
                Session["stor_id"] = stor_id;
                Server.Transfer("PRESENTACION_GRID.aspx");
            } else
            {
                //si selecciono ordeventa guardo venta para pasarlo
                String ord_num = ddlVentas.SelectedValue;
                Session["cargar"] = "venta";
                ////guardo el orderVenta
                Session["ord_num"] = ord_num;
                Server.Transfer("PRESENTACION_GRID.aspx");
                //Cargar los datos de la venta
            }
        }

        
    }
}