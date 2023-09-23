using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ENTIDADES;

namespace DATOS
{
    public class Conexion
    {
        public SqlConnection cnn;
        public static SqlDataAdapter daOrder, daOrderDetails;
        public static SqlCommandBuilder cbOrderDetails, cbOrder;
        public static DataTable dtOrders, dtOrderDetails;
        public static DataSet ds;
        public static DataRow[] filas;
        public Conexion()
        {
            cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindC"].ConnectionString);
        }
        public void abrir()
        {
            if (cnn.State== ConnectionState.Closed || cnn.State== ConnectionState.Broken)
            {
                cnn.Open();
            }
           
        }
        public void cerrar()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        public DataRow[] cargarDataSet(int ordenID)
        {

            daOrder = new SqlDataAdapter("Select * from Orders", cnn);
            daOrderDetails = new SqlDataAdapter("Select * from [Order Details]", cnn);
            cbOrder = new SqlCommandBuilder(daOrder);
            cbOrderDetails = new SqlCommandBuilder(daOrderDetails);
            ds = new DataSet();
            daOrder.Fill(ds, "Orders");
            daOrderDetails.Fill(ds, "OrderDetails");
            dtOrders = ds.Tables["Orders"];
            dtOrderDetails = ds.Tables["OrderDetails"];
        
           filas = dtOrderDetails.Select("orderId=" + ordenID);
            return filas;
        }
    }
}
