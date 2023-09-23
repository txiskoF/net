using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data.SqlClient;

namespace ACCESO_A_DATOS
{
    public class DAOLineas_Pedido : Conexion
    {
        public void insertarLineaPedido(Linea_Pedido lp)
        {
            SqlCommand cmdLp = new SqlCommand("insert into [Order Details] values (@pedido,@producto,@precio,@cantidad,@descuento)", cnn);
            cmdLp.Parameters.AddWithValue("@pedido", lp.IdPedido);
            cmdLp.Parameters.AddWithValue("@producto", lp.IdProducto);
            cmdLp.Parameters.AddWithValue("@precio", lp.Precio);
            cmdLp.Parameters.AddWithValue("@cantidad", lp.Cantidad);
            cmdLp.Parameters.AddWithValue("@descuento", lp.Descuento);
            abrir();
            cmdLp.ExecuteNonQuery();
            cerrar();

        }
        public void actualizarStock(short cantidad, int idproducto)
        {
            SqlCommand cmdLp = new SqlCommand("update products set unitsinstock=@cantidad WHERE productId=@producto", cnn);
            cmdLp.Parameters.AddWithValue("@cantidad", cantidad);
            cmdLp.Parameters.AddWithValue("@producto", idproducto);
            abrir();
            cmdLp.ExecuteNonQuery();
            cerrar();

        }

        public void actualizarLineaPedido(int idLineaPedido, int idProducto, short cantidad, float descuento)
        {
            SqlCommand cmdLp = new SqlCommand("update [Order Details] set quantity=@cantidad,discount=@descuento WHERE productId=@producto AND orderId=@pedido", cnn);
            cmdLp.Parameters.AddWithValue("@pedido", idLineaPedido);
            cmdLp.Parameters.AddWithValue("@producto", idProducto);
            cmdLp.Parameters.AddWithValue("@cantidad", cantidad);
            cmdLp.Parameters.AddWithValue("@descuento", descuento);
            abrir();
            cmdLp.ExecuteNonQuery();
            cerrar();

        }

        public List<Linea_Pedido> mostrarDetallesOrdenPedido(int idLineaPedido)
        {
            List<Linea_Pedido> lineas = new List<Linea_Pedido>();
            SqlCommand cmdLp = new SqlCommand("SELECT * FROM [Order Details] WHERE orderId=@pedido", cnn);
            cmdLp.Parameters.AddWithValue("@pedido", idLineaPedido);
            abrir();
            SqlDataReader drlinea_orden = cmdLp.ExecuteReader();

            while (drlinea_orden.Read())
            {
                lineas.Add(new Linea_Pedido(Convert.ToInt32(drlinea_orden["OrderId"]),
                    Convert.ToInt32(drlinea_orden["ProductId"]), Convert.ToDecimal(drlinea_orden["unitprice"]),
                    Convert.ToInt16(drlinea_orden["quantity"]), Convert.ToSingle(drlinea_orden["Discount"])));
            }
            cerrar();
            return lineas;
        }

        public int eliminarLineaPedido(int idLineaPedido, int idProducto)
        {
            SqlCommand cmdLp = new SqlCommand("Delete [Order Details] WHERE  productId=@producto AND orderId=@pedido", cnn);
            cmdLp.Parameters.AddWithValue("@pedido", idLineaPedido);
            cmdLp.Parameters.AddWithValue("@producto", idProducto);
            abrir();
            int resultado = cmdLp.ExecuteNonQuery();
            cerrar();
            return resultado;
        }

        public void eliminarLineasOrden(int idLineaPedido)
        {
            SqlCommand cmdLp = new SqlCommand("Delete [Order Details] WHERE orderId=@pedido ", cnn);
            cmdLp.Parameters.AddWithValue("@pedido", idLineaPedido);
            abrir();
            cmdLp.ExecuteNonQuery();
            cerrar();
        }
    }
}
