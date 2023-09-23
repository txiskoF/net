using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ENTIDADES;
using System.Data;

namespace DATOS
{
    public class D_ORDER:Conexion
    {
        public void insertarOrder(ORDER or)
        {
            SqlCommand cmd = new SqlCommand("Insert into Orders (CustomerID,EmployeeId) values (@cliente,@empleado)", cnn);
            cmd.Parameters.AddWithValue("@cliente", or.IdCliente);
            cmd.Parameters.AddWithValue("@empleado", or.IdEmpleado);
            abrir();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cerrar();

        }
    public void borrarOrden(int or)
        {
            SqlCommand cmd = new SqlCommand("Delete FROM Orders WHERE OrderID=@orden", cnn);
            cmd.Parameters.AddWithValue("@orden", or);
            abrir();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cerrar();

            //DataColumn[] clave = new DataColumn[1];
            //clave[0] = dtOrders.Columns["OrderId"];
            //dtOrders.PrimaryKey = clave;
            //DataRow drborrar = dtOrders.Rows.Find(or);
            //daOrder.Update(dtOrders);
        }
	public int mostrarOrden(){

	    SqlCommand cmd = new SqlCommand("Select max(orderID) FROM Orders", cnn);
        abrir();
        int OrderID = Convert.ToInt32(cmd.ExecuteScalar());
 	    cmd.Dispose();
        cerrar();
	    return OrderID;
	}
    }
}
