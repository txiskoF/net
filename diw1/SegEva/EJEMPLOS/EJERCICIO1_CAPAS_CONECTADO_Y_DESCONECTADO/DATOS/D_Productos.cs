using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data.SqlClient;

namespace DATOS
{
    public class D_Productos:Conexion
    {
        public List<Productos> mostrarProductos()
        {
            SqlCommand cmd = new SqlCommand("Select * FROM products", cnn);
            abrir();
            SqlDataReader drProductos = cmd.ExecuteReader();
            List<Productos> lproductos = new List<Productos>();
            while (drProductos.Read())
            {
                Productos prod = new Productos();
                prod.IdProducto = Convert.ToInt32(drProductos[0]);
                prod.Descripcion = drProductos[1].ToString();
                lproductos.Add(prod);
            }
            drProductos.Close();
            cmd.Dispose();
            cerrar();
            return lproductos;
        }

public Productos mostrarProducto(string descripcion)
        {
            SqlCommand cmd = new SqlCommand("Select * FROM products where productID=@producto", cnn);
	    cmd.Parameters.AddWithValue("@producto",descripcion);
            abrir();
            SqlDataReader drProductos = cmd.ExecuteReader();
           
            drProductos.Read();
            
                Productos prod = new Productos();
                prod.IdProducto = Convert.ToInt32(drProductos[0]);
                prod.Descripcion = drProductos[1].ToString();
		prod.Precio=Convert.ToDecimal(drProductos[5]);
		prod.Unidadesenpedido= Convert.ToInt32(drProductos[7]);
            prod.Unidadesenstock = Convert.ToInt32(drProductos[6]);
              
          
            drProductos.Close();
            cmd.Dispose();
            cerrar();
            return prod;
        }


public void actualizarProducto(string productID, int cantidad)
        {
            SqlCommand cmd = new SqlCommand("Update products set UnitsInStock=UnitsInStock-@cantidad WHERE productID=@producto", cnn);
	        cmd.Parameters.AddWithValue("@producto",productID);
            cmd.Parameters.AddWithValue("@cantidad",cantidad);

            abrir();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cerrar();
            
        }


    }
}
