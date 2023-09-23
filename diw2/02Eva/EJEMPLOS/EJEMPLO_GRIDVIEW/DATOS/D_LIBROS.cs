using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ENTIDADES;

namespace DATOS
{
    public class D_LIBROS:Conexion
    {
        public List<Libros> getLibros()
        {
            decimal precio = 0;
            SqlCommand cmdLibros = new SqlCommand("Select * from titles", cnn);
            abrir();
            SqlDataReader drLibros = cmdLibros.ExecuteReader();
            List<Libros> listaLibros = new List<Libros>();
            while (drLibros.Read())
            {
                if (drLibros["price"]!=DBNull.Value)
                {
                    precio = Convert.ToDecimal(drLibros["price"]);
                }
                Libros l = new Libros(drLibros[0].ToString(), drLibros[1].ToString(), drLibros["type"].ToString(), precio, drLibros["pub_Id"].ToString(), Convert.ToDateTime(drLibros["pubdate"]));
                listaLibros.Add(l);
            }
            drLibros.Close();
            cmdLibros.Dispose();
            return listaLibros;
        }

        public List<Libros> getLibrosEditor(string editor)
        {
            decimal precio = 0;
            SqlCommand cmdLibros = new SqlCommand("Select * from titles WHERE pub_id=@editor", cnn);
            cmdLibros.Parameters.AddWithValue("@editor", editor);
            abrir();
            SqlDataReader drLibros = cmdLibros.ExecuteReader();
            List<Libros> listaLibros = new List<Libros>();
            while (drLibros.Read())
            {
                if (drLibros["price"] != DBNull.Value)
                {
                    precio = Convert.ToDecimal(drLibros["price"]);
                }
                Libros l = new Libros(drLibros[0].ToString(), drLibros[1].ToString(), drLibros["type"].ToString(), precio, drLibros["pub_Id"].ToString(), Convert.ToDateTime(drLibros["pubdate"]));
                listaLibros.Add(l);
            }
            drLibros.Close();
            cmdLibros.Dispose();
            return listaLibros;
        }

        /*PARA EL ORDEN DE LOS CAMPOS*/
        public List<Libros> getLibros(string orden)
        {
            decimal precio = 0;
            SqlCommand cmdLibros = new SqlCommand("Select * from titles ORDER BY " + orden, cnn);
            abrir();
            SqlDataReader drLibros = cmdLibros.ExecuteReader();
            List<Libros> listaLibros = new List<Libros>();
            while (drLibros.Read())
            {
                if (drLibros["price"] != DBNull.Value)
                {
                    precio = Convert.ToDecimal(drLibros["price"]);
                }
                Libros l = new Libros(drLibros[0].ToString(), drLibros[1].ToString(), drLibros["type"].ToString(), precio, drLibros["pub_Id"].ToString(), Convert.ToDateTime(drLibros["pubdate"]));
                listaLibros.Add(l);
            }
            drLibros.Close();
            cmdLibros.Dispose();
            return listaLibros;
        }






        public void actualizarLibro(Libros l)
        {
            SqlCommand cmdLibros = new SqlCommand("Update Titles set title=@title,type=@type,price=@price,pub_id=@pub_id,pubdate=@pubdate WHERE title_ID=@title_ID", cnn);
            cmdLibros.Parameters.AddWithValue("@title_ID", l.Title_Id);
            cmdLibros.Parameters.AddWithValue("@title", l.Title);
            cmdLibros.Parameters.AddWithValue("@type", l.Type);
            cmdLibros.Parameters.AddWithValue("@price", l.Price);
            cmdLibros.Parameters.AddWithValue("@pub_id", l.Pub_id);
            cmdLibros.Parameters.AddWithValue("@pubdate", l.Pubdate);
            abrir();
            cmdLibros.ExecuteNonQuery();
            cmdLibros.Dispose();
        }

        public void insertarLibro(Libros l)
        {
            SqlCommand cmdLibros = new SqlCommand("Insert INTO Titles(title_id,title,type,price,pub_id,pubdate) VALUES (@title_id,@title,@type,@price,@pub_id,@pubdate)", cnn);
            cmdLibros.Parameters.AddWithValue("@title_ID", l.Title_Id);
            cmdLibros.Parameters.AddWithValue("@title", l.Title);
            cmdLibros.Parameters.AddWithValue("@type", l.Type);
            cmdLibros.Parameters.AddWithValue("@price", l.Price);
            cmdLibros.Parameters.AddWithValue("@pub_id", l.Pub_id);
            cmdLibros.Parameters.AddWithValue("@pubdate", l.Pubdate);
            abrir();
            cmdLibros.ExecuteNonQuery();
            cmdLibros.Dispose();
        }

        public void eliminarLibro(string l)
        {
            SqlCommand cmdLibros = new SqlCommand("DELETE FROM Titles WHERE title_ID=@title_id", cnn);
            cmdLibros.Parameters.AddWithValue("@title_ID", l);
            abrir();
            cmdLibros.ExecuteNonQuery();
            cmdLibros.Dispose();
        }

    }
}
