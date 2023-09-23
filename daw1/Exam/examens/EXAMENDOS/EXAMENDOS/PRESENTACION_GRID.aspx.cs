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
    public partial class PRESENTACION_GRID : System.Web.UI.Page
    {
        DAL_Sale Dsale = new DAL_Sale();
        protected void Page_Load(object sender, EventArgs e)
        {
            String cargar = Session["cargar"].ToString();
            //si caragar es almacen
            if (cargar.Equals("almacen"))
            {   //recupero el storid
                String stor_id = Session["stor_id"].ToString();
                //Obtengo las ventas del almacen
                List<Sale> ventasGrid = Dsale.getSalesGrid(stor_id);

                /*
                 * CUANDO AutoGenerateColumns del grid sea false
                 * hay que generar las columnas a mano
                 * 
                BoundField boundfield = new BoundField();
                boundfield.DataField = "ord_num";
                boundfield.HeaderText = "Número de venta";
                gvDatos.Columns.Add(boundfield);

                boundfield = new BoundField();
                boundfield.DataField = "title_id";
                boundfield.HeaderText = "Código de libro";
                gvDatos.Columns.Add(boundfield);*/

                //Se las añado al gridview
                gvDatos.DataSource = ventasGrid; //tiene que ser una lista
                gvDatos.DataBind();
            } else
            {
                //llamr al dal y pintar en grid
                String ord_num = Session["ord_num"].ToString();
                List<Sale> ventasGrid = Dsale.getLibrosGid(ord_num);
            }
        }
    }
}