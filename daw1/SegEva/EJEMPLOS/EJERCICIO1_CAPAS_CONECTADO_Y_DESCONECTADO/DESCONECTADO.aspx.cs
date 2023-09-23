using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using ENTIDADES;
using NEGOCIO;

public partial class DESCONECTADO : System.Web.UI.Page
{
    N_ORDER porder = new N_ORDER();
    N_ORDERDETAILS porderdetails = new N_ORDERDETAILS();
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }



    protected void txtBuscar_Click(object sender, EventArgs e)
    {

        List<ORDERDETAILS> lord = porderdetails.mostrarDetallesORden(Int32.Parse(txtordenID.Text));
        foreach (ORDERDETAILS elem in lord)
        {
            lstdatospedido.Items.Add(elem.ProductID + "-" + elem.Unitprice + "-" + elem.Quantity + "-" + elem.Discount);
        }
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {

        if (lstdatospedido.SelectedIndex!=-1)
        {
            char[] separador = new char[] { '-' };
            string[] datos = lstdatospedido.SelectedItem.Text.Split(separador);
            porderdetails.borrarOrden(Int32.Parse(txtordenID.Text),Convert.ToInt32(datos[0]));
            lstdatospedido.Items.RemoveAt(lstdatospedido.SelectedIndex);
        }
        else
        {
            porderdetails.borrarOrden(Int32.Parse(txtordenID.Text));
               
            porder.borrarOrden(Convert.ToInt32(txtordenID.Text.Trim()));
            lstdatospedido.Items.Clear();
            txtordenID.Text = String.Empty;
        }
        


       
       
    }
}
