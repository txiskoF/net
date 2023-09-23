using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTIDADES;

namespace Recuperacion
{
    public partial class VENTAS_ALMACENES : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL_Store DStore = new DAL_Store();
            DAL_Sale Dsale = new DAL_Sale();
            DAL_Title DTitle = new DAL_Title();

        }

        protected void txtNombreAlmacen_TextChanged(object sender, EventArgs e)
        {
            //limpiar la ddlalmacnes
            ddlAlmacenes.Items.Clear();
            //limpiarlas vebntas
            ddlVentas.Items.Clear();
            //coger le nombre del txtnomAL
            string nombre = txtNombreAlmacen.Text;
            //crear el list lstores  con los nombres del store
            List<Store> lStores = (List<Store>)DStore.getStores(nombre);
            foreach (Store stor in lStores)
            {
                ddlAlmacenes.Items.Add(stor.Stor_name);
            }
    }

        protected void ddlAlmacenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //limpor ddl ventas
            ddlVentas.Items.Clear();
                        //utilizar el DAL para obtner el titulo
            Sale libro = DTitle.GetTitle(title_id);
                        //utilizar el DAL para obtener la venta
            Sale sale = Dsale.GetSale();
                        //utilizar el DAL para obtener las ventas
            Sale sales = Dsale.getSales(ddlAlmacenes.Select);
            lblFechaVenta.Text = sale.Ord_date;
            //del libro poner su precio
            txtPrecio.Text = libro.
                //de las ventas poner la cantidad
            txtCantidad.Text = sales.Qty;
                //de sale poner su precio
            txtPrecio.Text = sale.
        }
    }