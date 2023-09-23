using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data.SqlClient;

namespace ACCESO_A_DATOS
{
   public  class DAO_Pedido:Conexion
    {
        //inserto un pedido con los datos pasados del pedido p
        public void insertarPedido(Pedido p)
        {
            SqlCommand cmdPedido=new SqlCommand("insert into Orders(CustomerId,EmployeeId) values (@cliente,@empleado)",cnn );
            cmdPedido.Parameters.AddWithValue("@cliente", p.IdCliente);
            cmdPedido.Parameters.AddWithValue("@empleado", p.IdEmpleado);
            abrir();
            cmdPedido.ExecuteNonQuery();
            cmdPedido.Dispose();
            cerrar();
        }


        public int mostrarNPedido()
        {
            //selecciono la OrderId mas alta de Orders 
            SqlCommand cmdPedido = new SqlCommand("Select MAX(OrderId) FROM Orders", cnn);
            abrir();
            int npedido=Convert.ToInt32(cmdPedido.ExecuteScalar());
            cerrar();
            return npedido;
        }

        public int eliminarPedido(int idPedido)
        {
            SqlCommand cmdPedido = new SqlCommand("delete Orders WHERE orderId=@pedido", cnn);
            cmdPedido.Parameters.AddWithValue("@pedido", idPedido);
            abrir();
           int resultado= cmdPedido.ExecuteNonQuery();
            cmdPedido.Dispose();
            cerrar();
            return resultado;
        }
    }
}
