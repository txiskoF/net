using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ENTIDADES;

namespace DAO
{
    public class DAO_Libro:Conexion
    {

        public List<string> getLibros()
        {
            List<string> libros = new List<string>();
            SqlCommand cmdLibros = new SqlCommand();
            // Para acceder a todos los registros de una Tabla (Es un Select * from Tabla)
            //cmdLibros.CommandType = CommandType.TableDirect;
            //cmdLibros.CommandText = "Titles";
            //Para Acceder a un Procedimiento Almacenado
           // cmdLibros.CommandType = CommandType.StoredProcedure;
            //cmdLibros.CommandText = "NombreProcedimiento";
            cmdLibros.CommandType = CommandType.Text;
            cmdLibros.CommandText = "Select title FROM titles";
            cmdLibros.Connection = cnn;
            abrir();
            SqlDataReader drLibros = cmdLibros.ExecuteReader();
            while (drLibros.Read())
            {
                libros.Add(drLibros["title"].ToString());
               // libros.Add(drLibros[0].ToString());
            }
            cerrar();
            return libros;
          }
        public int totalLibros()
        {

           SqlCommand cmdtotal = new SqlCommand("Select count(*) FROM titles", cnn);
            abrir();
            int total = (int)cmdtotal.ExecuteScalar();
            cerrar();
            return total;

        }
        public Libro getLibro(string titulo)
        {
            SqlCommand cmdLibro = new SqlCommand("Select * From titles WHERE title=@title",cnn);
            cmdLibro.Parameters.AddWithValue("@title", titulo);
            abrir();
            SqlDataReader drLibro = cmdLibro.ExecuteReader();
            drLibro.Read();
            Libro l = new Libro(drLibro[0].ToString(), drLibro[1].ToString(),
            drLibro[2].ToString(),Convert.ToDecimal(drLibro[4]),
            Convert.ToDateTime(drLibro[9]));
            return l;

        }

        public void insertarLibro(Libro linsertar)
        {
            SqlCommand cmdinsertar = new SqlCommand("insert into titles" +
                "(title_id,title,type,price,pubdate) values" +
                " (@title_id,@title,@type,@price,@pubdate)", cnn);
            cmdinsertar.Parameters.AddWithValue("@title_id",linsertar.Title_id);
            cmdinsertar.Parameters.AddWithValue("@title", linsertar.Title);
            cmdinsertar.Parameters.AddWithValue("@type", linsertar.Type);
            cmdinsertar.Parameters.AddWithValue("@price", linsertar.Price);
            cmdinsertar.Parameters.AddWithValue("@pubdate", linsertar.Pubdate);
            abrir();
            cmdinsertar.ExecuteNonQuery();
            cerrar();
        }
        public void modificarLibro(Libro lmodificar)
        {
            SqlCommand cmdinsertar = new SqlCommand("update titles set title=@title," +
               "type=@type,price=@price,pubdate=@pubdate WHERE title_id=@title_id", cnn);
            cmdinsertar.Parameters.AddWithValue("@title_id", lmodificar.Title_id);
            cmdinsertar.Parameters.AddWithValue("@title", lmodificar.Title);
            cmdinsertar.Parameters.AddWithValue("@type", lmodificar.Type);
            cmdinsertar.Parameters.AddWithValue("@price", lmodificar.Price);
            cmdinsertar.Parameters.AddWithValue("@pubdate", lmodificar.Pubdate);
            abrir();
            cmdinsertar.ExecuteNonQuery();
            cerrar();
        }
        public void eliminarLibro(string leliminar)
        {
            SqlCommand cmdeliminar = new SqlCommand("delete from titles" +
                 " WHERE title_id=@title_id", cnn);
            cmdeliminar.Parameters.AddWithValue("@title_id",leliminar);
            abrir();
            cmdeliminar.ExecuteNonQuery();
            cerrar();

        }


    }
}
