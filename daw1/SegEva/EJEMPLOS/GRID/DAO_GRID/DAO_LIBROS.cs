using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES_GRID;
using System.Data.SqlClient;


namespace DAO_GRID
{
    public class DAO_LIBROS:CONEXION 
    {

        public List<LIBROS> getLibros()
        {
            List<LIBROS> Llibros = new List<LIBROS>();
            SqlCommand cmd = new SqlCommand("Select * from Titles", cnn);
            abrir();
            SqlDataReader drLibros=cmd.ExecuteReader();
            while (drLibros.Read())
            {
                Llibros.Add(new LIBROS(
                    drLibros[0].ToString(),
                    drLibros[1].ToString(),
                    drLibros["type"].ToString(),
                    Convert.ToDecimal(drLibros.IsDBNull(4)? 0 :drLibros["price"]),
                    drLibros["pub_ID"].ToString(),
                    Convert.ToDateTime(drLibros["pubdate"])));
            }
            drLibros.Close();
            cmd.Dispose();
            cerrar();
            return Llibros;
        }

       public List<LIBROS> getLibrosEditor(string editor)
        {
            List<LIBROS> Llibros = new List<LIBROS>();
            SqlCommand cmd = new SqlCommand("Select * from Titles WHERE pub_ID=@editor", cnn);
            cmd.Parameters.AddWithValue("@editor", editor);
            abrir();
            SqlDataReader drLibros = cmd.ExecuteReader();
            while (drLibros.Read())
            {
                Llibros.Add(new LIBROS(
                    drLibros[0].ToString(),
                    drLibros[1].ToString(),
                    drLibros["type"].ToString(),
                    Convert.ToDecimal(drLibros.IsDBNull(4) ? 0 : drLibros["price"]),
                    drLibros["pub_ID"].ToString(),
                    Convert.ToDateTime(drLibros["pubdate"])));
            }
            drLibros.Close();
            cmd.Dispose();
            cerrar();
            return Llibros;
        }

        public void updateLibros(LIBROS l)
        {
            SqlCommand cmd = new SqlCommand("Update titles set title=@title," +
                "type=@type,price=@price,pub_id=@pub_id,pubdate=@pubdate WHERE title_id=@id", cnn);
            cmd.Parameters.AddWithValue("@title", l.Title);
            cmd.Parameters.AddWithValue("@type", l.Type);
            cmd.Parameters.AddWithValue("@price", l.Price);
            cmd.Parameters.AddWithValue("@pub_id", l.Pub_ID);
            cmd.Parameters.AddWithValue("@pubdate", l.Pubdate);
            cmd.Parameters.AddWithValue("@id", l.Title_ID);
            abrir();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cerrar(); 

        }

        public void insertLibro(LIBROS l)
        {
            SqlCommand cmd = new SqlCommand("Insert INTO titles" +
                "(title_id,title,type,price,pub_id,pubdate) " +
                "VALUES" +
                "(@title_id,@title,@type,@price,@pub_id,@pubdate)", cnn);
            cmd.Parameters.AddWithValue("@title", l.Title);
            cmd.Parameters.AddWithValue("@type", l.Type);
            cmd.Parameters.AddWithValue("@price", l.Price);
            cmd.Parameters.AddWithValue("@pub_id", l.Pub_ID);
            cmd.Parameters.AddWithValue("@pubdate", l.Pubdate);
            cmd.Parameters.AddWithValue("@title_id", l.Title_ID);
            abrir();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cerrar();

        }





        
        public void deleteLibro(string id)
        {
            SqlCommand cmd = new SqlCommand("delete from titles WHERE title_id=@id", cnn);
            cmd.Parameters.AddWithValue("@id", id);
            abrir();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cerrar();

        }

        public List<LIBROS> seleccionLibros(string orden)
        {
            List<LIBROS> Llibros = new List<LIBROS>();
            SqlCommand cmd = new SqlCommand("Select * from Titles order by " + orden, cnn);
           // cmd.Parameters.AddWithValue("@orden", orden);
            abrir();
            SqlDataReader drLibros = cmd.ExecuteReader();
            while (drLibros.Read())
            {
                Llibros.Add(new LIBROS(
                    drLibros[0].ToString(),
                    drLibros[1].ToString(),
                    drLibros["type"].ToString(),
                    Convert.ToDecimal(drLibros.IsDBNull(4) ? 0 : drLibros["price"]),
                    drLibros["pub_ID"].ToString(),
                    Convert.ToDateTime(drLibros["pubdate"])));
            }
            drLibros.Close();
            cmd.Dispose();
            cerrar();
            return Llibros;
        }
    }

    }

