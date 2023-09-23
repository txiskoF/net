using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTIDADES;
using NEGOCIO;

namespace SOLUCION_Ejercicio1
{
    public partial class EliminarPedidos : System.Web.UI.Page
    {
        DAL_Lineas_Pedidos nlp = new DAL_Lineas_Pedidos();
        DAL_Pedido np = new DAL_Pedido();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtBuscar_Click(object sender, EventArgs e)
        {
            LstDetalles.Items.Clear();
            List<Linea_Pedido> lineas=nlp.mostrarDetallesOrdenPedido(Convert.ToInt32(txtordenID.Text));
            foreach (var item in lineas)
            {
                LstDetalles.Items.Add(item.IdProducto + "-" + item.Precio + "-" + item.Cantidad + "-" + item.Descuento);
            }


        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (LstDetalles.SelectedIndex!=-1)
            {
                //BorrarLineaPedido
                string[] datosLinea = LstDetalles.SelectedItem.Text.Split('-');
                //int guion = LstDetalles.SelectedItem.Text.IndexOf('-');
                //int producto= Convert.ToInt32(LstDetalles.SelectedItem.Text.Substring(0,guion));
                int resultado= nlp.eliminarLineaPedido(Convert.ToInt32(txtordenID.Text), Convert.ToInt32(datosLinea[0]));
                if (resultado==1)
                {
                    LstDetalles.Items.RemoveAt(LstDetalles.SelectedIndex);
                }
                 
            }
            else
            {
                //Eliminar LineasPedido de la Orden
                int orden = Convert.ToInt32(txtordenID.Text);
                //Eliminar Orden de Pedido
                nlp.eliminarLineasOrden(orden);
                //Actualizar Presentación
                int resultado=np.eliminarPedido(orden);
                if (resultado==1)
                {
                    LstDetalles.Items.Clear();
                    txtordenID.Text = String.Empty;
                }
              
            }
        }
    }
}