using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ENTITY;

namespace ACCESO_DATOS
{
    public class DAO_Libros:Conexion
    {
        public List<Libro> getLibros( string expresion)
        {
            decimal precio = 0;
            List<Libro> Llibros = new List<Libro>();
            SqlCommand cmdLibros = new SqlCommand("select * from titles order by " + expresion , cnn);
            //cmdLibros.Connection = cnn;
            abrir();
            SqlDataReader drLibros = cmdLibros.ExecuteReader();
            while (drLibros.Read())
            {
                if (drLibros["price"]!= DBNull.Value )
                {
                    precio = Convert.ToDecimal(drLibros["price"]);
                }
                Llibros.Add(new Libro(drLibros["title_Id"].ToString(),drLibros["Title"].ToString(),
                    drLibros["type"].ToString(), drLibros["pub_id"].ToString(),precio,
                    Convert.ToDateTime(drLibros["pubdate"])));
            }
            drLibros.Close();
            cerrar();
            return Llibros;
        }






        public List<string> mostrarTitulos() {

            List<string> Llibros = new List<string>();
            SqlCommand cmdLibros = new SqlCommand("select title from titles",cnn);
            //cmdLibros.Connection = cnn;
            abrir();
            SqlDataReader drLibros=cmdLibros.ExecuteReader();
            while (drLibros.Read())
            {
                Llibros.Add(drLibros["title"].ToString());
            }
            drLibros.Close();
            cerrar();
            return Llibros;
        }

        public List<string> buscarTitulos(string texto)
        {

            List<string> Llibros = new List<string>();
            SqlCommand cmdLibros = new SqlCommand("select title from titles WHERE title like @patron ORDER BY title", cnn);
            //cmdLibros.Connection = cnn;
            abrir();
            cmdLibros.Parameters.AddWithValue("@patron", "%" + texto + "%");
            SqlDataReader drLibros = cmdLibros.ExecuteReader();
           
            while (drLibros.Read())
            {
                Llibros.Add(drLibros["title"].ToString());
            }
            drLibros.Close();
            cerrar();
            return Llibros;
        }

        public int contarlibros()
        {
            SqlCommand cmdLibros = new SqlCommand("select count(*) from titles", cnn);
            //cmdLibros.Connection = cnn;
            abrir();
            int numeroLibros = Convert.ToInt32(cmdLibros.ExecuteScalar());
            cerrar();
            return numeroLibros;

        }

        public Libro mostrarDatosLibro(string titulo)
        {
            SqlCommand cmdLibros = new SqlCommand("select * from titles WHERE title=@titulo", cnn);
            //cmdLibros.Connection = cnn;
            abrir();
            cmdLibros.Parameters.AddWithValue("@titulo", titulo);
            //SqlParameter ptitulo = new SqlParameter("@titulo", System.Data.SqlDbType.VarChar, 80);
            //ptitulo.Value = titulo;
            //cmdLibros.Parameters.Add(ptitulo);

            SqlDataReader drLibros = cmdLibros.ExecuteReader();
            drLibros.Read();
            Libro Lbuscado = new Libro(drLibros["title_id"].ToString(), 
                drLibros["title"].ToString(),drLibros["type"].ToString(),
                drLibros["pub_id"].ToString(),Convert.ToDecimal(drLibros["price"]),Convert.ToDateTime(drLibros["pubdate"]));
            drLibros.Close();
            cerrar();
            return Lbuscado;
        }

        public void InsertarLibro(Libro linsertar)
        {
            SqlCommand cmdLibros = new SqlCommand("insert into titles(title_id,title,type,pub_id,price,pubdate) " +
                "values (@title_id,@title,@type,@pub_id,@price,@pubdate)", cnn);
            //cmdLibros.Connection = cnn;
            abrir();
            cmdLibros.Parameters.AddWithValue("@title_id", linsertar.Title_id);
            cmdLibros.Parameters.AddWithValue("@title", linsertar.Title);
            cmdLibros.Parameters.AddWithValue("@type", linsertar.Type);
            cmdLibros.Parameters.AddWithValue("@pub_id", linsertar.Pub_id);
            cmdLibros.Parameters.AddWithValue("@price", linsertar.Price);
            cmdLibros.Parameters.AddWithValue("@pubdate", linsertar.Pubdate);
            cmdLibros.ExecuteNonQuery();
            cerrar();
        }

        //borrado para el GRIDVIEW
        public void EliminarLibro(string title_id)
        {
            SqlCommand cmdLibros = new SqlCommand("Delete from titles WHERE title_id=@title_id", cnn);
            //cmdLibros.Connection = cnn;
            abrir();
            cmdLibros.Parameters.AddWithValue("@title_id", title_id);
            cmdLibros.ExecuteNonQuery();
            cerrar();


        }
        //hacer actualizacion para el GRIDVIEW
        public void ActualizarLibro(Libro linsertar)
        {
            SqlCommand cmdLibros = new SqlCommand("update titles set title=@title,type=@type,pub_id=@pub_id,price=@price,pubdate=@pubdate WHERE title_id=@title_id" , cnn);
            //cmdLibros.Connection = cnn;
            abrir();
            cmdLibros.Parameters.AddWithValue("@title_id", linsertar.Title_id);
            cmdLibros.Parameters.AddWithValue("@title", linsertar.Title);
            cmdLibros.Parameters.AddWithValue("@type", linsertar.Type);
            cmdLibros.Parameters.AddWithValue("@pub_id", linsertar.Pub_id);
            cmdLibros.Parameters.AddWithValue("@price", linsertar.Price);
            cmdLibros.Parameters.AddWithValue("@pubdate", linsertar.Pubdate);
            cmdLibros.ExecuteNonQuery();
            cerrar();
        }
    }
}

