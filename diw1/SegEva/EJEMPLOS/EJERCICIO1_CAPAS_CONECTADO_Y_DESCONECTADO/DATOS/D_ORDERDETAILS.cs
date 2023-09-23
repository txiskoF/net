using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data.SqlClient;
using System.Data;

namespace DATOS
{
    public class D_ORDERDETAILS:Conexion
    {
        //DataRow[] filas;
        public void insertarOrderDetail(ORDERDETAILS or)
        {
            SqlCommand cmd = new SqlCommand("Insert into [Order Details] (OrderId,ProductId,UnitPrice,Quantity,Discount) values (@orden,@producto,@precio,@cantidad,@descuento)", cnn);
            cmd.Parameters.AddWithValue("@orden", or.OrderID);
            cmd.Parameters.AddWithValue("@producto", or.ProductID);
            cmd.Parameters.AddWithValue("@precio", or.Unitprice);
            cmd.Parameters.AddWithValue("@cantidad", or.Quantity);
            cmd.Parameters.AddWithValue("@descuento", or.Discount);
            abrir();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cerrar();

        }

       public short mostrarCantidad(ORDERDETAILS or)
        {
            SqlCommand cmd = new SqlCommand("Select quantity FROM [Order Details] WHERE orderID=@orden and productID=@producto", cnn);
            cmd.Parameters.AddWithValue("@orden", or.OrderID);
            cmd.Parameters.AddWithValue("@producto", or.ProductID);
            abrir();
            short resultado = Convert.ToInt16(cmd.ExecuteScalar()); 
            cmd.Dispose();
            cerrar();
            return resultado;
        }


       public void actualizarLineaPedido(ORDERDETAILS or)
        {
            SqlCommand cmd = new SqlCommand("Update [Order Details] set quantity=quantity+@cantidad,discount=@descuento WHERE orderID=@orden AND productID=@producto", cnn);
            cmd.Parameters.AddWithValue("@orden", or.OrderID);
            cmd.Parameters.AddWithValue("@producto", or.ProductID);
            cmd.Parameters.AddWithValue("@descuento", or.Discount);
            cmd.Parameters.AddWithValue("@cantidad", or.Quantity);
         
            abrir();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cerrar();
        }

        public void borrarOrden(int orden,int producto)
        {
            SqlCommand cmd = new SqlCommand("Delete FROM  [Order Details] WHERE orderID=@orden AND productID=@producto", cnn);
            cmd.Parameters.AddWithValue("@orden", orden);
            cmd.Parameters.AddWithValue("@producto", producto);
            abrir();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cerrar();

            //for (int i = 0; i < filas.Length; i++)
            //{
            //    filas[i].Delete();
            //}
            //daOrderDetails.Update(dtOrderDetails);
        }

        public void borrarOrden(int orden)
        {
            SqlCommand cmd = new SqlCommand("Delete FROM  [Order Details] WHERE orderID= :orden", cnn);
            cmd.Parameters.AddWithValue("@orden", orden);
            //SqlParameter p1 = new SqlParameter("@orden", SqlDbType.Int);
            //p1.Value = orden;
            //cmd.Parameters.Add(p1);

            abrir();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cerrar();

            //PROCEDIMIENTO ALMACENADO
            //SqlCommand cmdProcedimiento = new SqlCommand();
            //cmdProcedimiento.CommandType = CommandType.StoredProcedure;
            //cmdProcedimiento.CommandText = "NombreProcedimiento";
            //SqlParameter pp1 = new SqlParameter("@pepe", SqlDbType.NVarChar, 15);
            //pp1.Direction = ParameterDirection.Input;
            //pp1.Value = orden;
            //SqlParameter pp2 = new SqlParameter("@3453", SqlDbType.Int);
            //pp2.Direction =  ParameterDirection.ReturnValue;
            //SqlParameter pp3 = new SqlParameter("@erter", SqlDbType.Int);
            //pp3.Direction = ParameterDirection.Output;
            //cmdProcedimiento.Parameters.Add(pp1);
            //cmdProcedimiento.Parameters.Add(pp2);
            //cmdProcedimiento.Parameters.Add(pp3);
            //int resultado = cmdProcedimiento.ExecuteNonQuery();
            //int resFuncion = Convert.ToInt32(cmdProcedimiento.Parameters["3453"].Value);
            //int resPSalida = Convert.ToInt32(cmdProcedimiento.Parameters["erter"].Value);

            //for (int i = 0; i < filas.Length; i++)
            //{
            //    filas[i].Delete();
            //}
            //daOrderDetails.Update(dtOrderDetails);
        }
        public List<ORDERDETAILS> mostrarDetallesORden(int ordenID)
        {
            List<ORDERDETAILS> lDetalles = new List<ORDERDETAILS>();
                SqlCommand cmd = new SqlCommand("Select * FROM [Order Details] WHERE orderID=@orden", cnn);
                cmd.Parameters.AddWithValue("@orden",ordenID);
                abrir();
                SqlDataReader drResultado = cmd.ExecuteReader();
            while (drResultado.Read())
            {
                lDetalles.Add(new ORDERDETAILS(
                    Convert.ToInt32(drResultado["orderID"]),
                    Convert.ToInt32(drResultado["productID"]),
                    Convert.ToDecimal(drResultado["unitprice"]),
                     Convert.ToInt16(drResultado["quantity"]),
                     Convert.ToDouble(drResultado["discount"])));
            }
            drResultado.Close();
                cmd.Dispose();
                cerrar();
                return lDetalles;
           

            //filas = cargarDataSet(ordenID);
            //List<ORDERDETAILS> lod = new List<ORDERDETAILS>();
            //foreach (DataRow elemento in filas)
            //{
            //    ORDERDETAILS od = new ORDERDETAILS();
            //    od.OrderID = Convert.ToInt32(elemento["orderID"]);
            //    od.ProductID = Convert.ToInt32(elemento["productID"]);
            //    od.Unitprice = Convert.ToDecimal(elemento["UnitPrice"]);
            //    od.Quantity = Convert.ToInt16(elemento["Quantity"]);
            //    od.Discount = Convert.ToDouble(elemento["Discount"]);
            //    lod.Add(od);
            //}
            //return lod;

        }
    }
}
