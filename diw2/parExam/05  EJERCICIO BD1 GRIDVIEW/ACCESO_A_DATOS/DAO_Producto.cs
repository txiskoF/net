using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ENTIDADES;

namespace ACCESO_A_DATOS
{
   public  class DAO_Producto : Conexion
    {
        public List<Producto> mostrarProductos()
        {
            List<Producto> LProductos = new List<Producto>();
            SqlCommand cmdProducto = new SqlCommand("Select * From Products", cnn);
            abrir();
            SqlDataReader drProducto = cmdProducto.ExecuteReader();
            while (drProducto.Read())
            {
                LProductos.Add(new Producto(Convert.ToInt32(drProducto[0]), drProducto[1].ToString(), Convert.ToDecimal(drProducto[5]), Convert.ToInt16(drProducto[6]), Convert.ToInt16(drProducto[7]), Convert.ToBoolean(drProducto[9])));
            }
            drProducto.Close();
            cerrar();
            return LProductos;
        }

        public Producto mostrarDatosProducto(int idproducto)
        {
            SqlCommand cmdProducto = new SqlCommand("Select * From Products WHERE ProductId=@idProducto", cnn);
            cmdProducto.Parameters.AddWithValue("@idProducto",idproducto);
            abrir();
            SqlDataReader drProducto = cmdProducto.ExecuteReader();
            drProducto.Read();
            Producto p = new Producto(Convert.ToInt32(drProducto["ProductId"]), drProducto["ProductName"].ToString(),
                Convert.ToDecimal( drProducto["UnitPrice"]),Convert.ToInt16( drProducto["UnitsInStock"]),
                Convert.ToInt16( drProducto["UnitsOnOrder"]),Convert.ToBoolean( drProducto["Discontinued"]));
            drProducto.Close();
            cerrar();
            return p;
        }


     
    }

}
