using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_Sale : Conexion
    {
        //OBTENGO LAS VENTAS DEL ALMACEN SELECCIONADO
        public List<Sale> getSales(int stor_id)
        {
            //Con lo que viene hago la select el distinct sirve para obtener solo 1 orden porcada venta
            SqlCommand cmdSale = new SqlCommand("Select distinct ord_num from sales Where stor_id=@stor_id", cnn);
            cmdSale.Parameters.AddWithValue("@stor_id", stor_id);
            abrir();
            SqlDataReader drSale = cmdSale.ExecuteReader();
            List<Sale> lSale = new List<Sale>();
            while (drSale.Read())
            {
                Sale s = new Sale(drSale[0].ToString());
                lSale.Add(s);
            }
            drSale.Close();
            cmdSale.Dispose();
            cerrar();
            return lSale;
        }

        //PARA OBTENER DE 1 VENTA TODOS SUS LIBROS
        public Sale GetSale(string ord_num)
        {
            //Creo una varible venta
            Sale s = new Sale();
            //Obtengo todos los datos
            SqlCommand cmdSale = new SqlCommand("Select stor_id, qty, title_id, ord_date, ord_num From" +
                " Sales Where ord_num=@ord_num", cnn);
            cmdSale.Parameters.AddWithValue("@ord_num", ord_num);
            abrir();
            SqlDataReader drSale = cmdSale.ExecuteReader();
            if (drSale.Read())
            {
                s = new Sale(drSale[0].ToString(), Convert.ToInt32(drSale[1]), drSale[2].ToString(),
                    Convert.ToDateTime(drSale[3]), drSale[4].ToString());
            }

            drSale.Close();
            cmdSale.Dispose();
            cerrar();
            return s;
        }

        //OBTENGO EL ID DEL LIBRO
        public List<String> getTitleIds (String ord_num)
        {
            //Obtengo un listado con los titelid
            List<String> titleIds = new List<string>();
            SqlCommand cmdTitles = new SqlCommand("Select title_id From Sales Where ord_num=@ord_num", cnn);
            cmdTitles.Parameters.AddWithValue("@ord_num", ord_num);
            abrir();
            SqlDataReader drTitles = cmdTitles.ExecuteReader();
            while (drTitles.Read())
            {
                titleIds.Add(drTitles[0].ToString());
            }
            drTitles.Close();
            cmdTitles.Dispose();
            cerrar();
            return titleIds;
        
        }

        //CALCULO LA CANTIDAD DE LIBROS VENDIDOS POR ORDENVENTA
        public int cantidadLibros (String stor_id, String ord_num, String title_id)
        {
            //Hago la select y asi obtengo la cantidad delibros por cadalibro porcadaventa
            int Cantidad = 0;
            SqlCommand cmd = new SqlCommand("Select qty From Sales Where stor_id=@stor_id and ord_num=@ord_num and" +
                " title_id=@title_id", cnn);
            cmd.Parameters.AddWithValue("@stor_id", stor_id);
            cmd.Parameters.AddWithValue("@ord_num", ord_num);
            cmd.Parameters.AddWithValue("@title_id", title_id);
            abrir();
            SqlDataReader drCantidad = cmd.ExecuteReader();
            if (drCantidad.Read())
            {
                Cantidad = Convert.ToInt32(drCantidad[0]);
            }
            drCantidad.Close();
            cmd.Dispose();
            cerrar();
            return Cantidad;
        }
        //public int cantidadLibros(String ord_num, String title_id, int cantidad)
        public void insertarNuevoLibro(String stor_id,String ord_num, String title_id, int qty)
        {
            SqlCommand cmd = new SqlCommand("Insert into Sales (stor_id, ord_num, ord_date, " +
                "qty, payterms, title_id) Values (@stor_id, @ord_num, @ord_date, @qty, @payterms, @title_id) ", cnn);
            cmd.Parameters.AddWithValue("@stor_id", stor_id);
            cmd.Parameters.AddWithValue("@ord_num", ord_num);
            cmd.Parameters.AddWithValue("@ord_date", DateTime.Now);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@payterms", "Net 60");
            cmd.Parameters.AddWithValue("@title_id", title_id);
            abrir();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cerrar();
        }

        //para borrar un libro con los datos pasados
        public void borrarLibro(String stor_id, String ord_num, String title_id)
        {
            SqlCommand cmd = new SqlCommand("Delete From Sales Where stor_id=@stor_id and " +
                "ord_num=@ord_num and title_id=@title_id", cnn);
            cmd.Parameters.AddWithValue("@stor_id", stor_id);
            cmd.Parameters.AddWithValue("@ord_num", ord_num);
            cmd.Parameters.AddWithValue("@title_id", title_id);
            abrir();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cerrar();
        }

        //PARA MOSTRAR LAS VENTAS EN EL GRID DEL ALMACEN
        public List<Sale> getSalesGrid(String stor_id)
        {
            SqlCommand cmdSale = new SqlCommand("Select stor_id, qty, title_id, ord_date, ord_num " +
                "from sales Where stor_id=@stor_id", cnn);
            cmdSale.Parameters.AddWithValue("@stor_id", stor_id);
            abrir();
            SqlDataReader drSale = cmdSale.ExecuteReader();
            List<Sale> lSale = new List<Sale>();
            while (drSale.Read())
            {
                Sale s = new Sale(drSale[0].ToString(), Convert.ToInt32(drSale[1]), drSale[2].ToString(), 
                    Convert.ToDateTime(drSale[3]), drSale[4].ToString());
                lSale.Add(s);
            }
            drSale.Close();
            cmdSale.Dispose();
            cerrar();
            return lSale;
        }

        //MOSTRAR SEGUN ORD_NUM
        public List<Sale> getLibrosGrid(String ord_num) {
            SqlCommand cmd = new SqlCommand("Select stor_id, qty, title_id, ord_date, ord_num" +
                "  FROM sales where ord_num=@ord_num", cnn);
            cmd.Parameters.AddWithValue("@ord_num", ord_num);
            abrir();
            SqlDataReader dr = cmd.ExecuteReader();
            List<Sale> lLibros = new List<Sale>();
            while (dr.Read())
            {
                Sale l = new Sale(dr[0].ToString(), Convert.ToInt32(dr[1]), dr[2].ToString(),
                    Convert.ToDateTime(dr[3]), dr[4].ToString());
                lLibros.Add(l);
            }
            dr.Close();
            cmd.Dispose();
            cerrar();
            return lLibros;
        }


        
    }
}
