using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AccesoDatos;
using ENTITY;

namespace ACCESO_DATOS
{
    public class DAO_Libros:Conexion
    {
        public List<string> mostrarTitulos() {

            List<string> Llibros = new List<string>();
            SqlCommand cmdLibros = new SqlCommand("select title from titles", cnn);
            //cmdLibros.Connection = cnn;
            abrir();
            SqlDataReader drLibros = cmdLibros.ExecuteReader();
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
            SqlCommand cmdLibros = new SqlCommand("Select count(*) From titles", cnn);
            abrir();
            int numeroLibros = Convert.ToInt32(cmdLibros.ExecuteScalar());
            cerrar();
            return numeroLibros;
        }

        public Libro mostrarDatosLibro(string titulo)
        {
            SqlCommand cmdLibros = new SqlCommand("Select * From titles Where title = @titulo", cnn);
            abrir();
            cmdLibros.Parameters.AddWithValue("@titulo", titulo);
            SqlDataReader drLibros = cmdLibros.ExecuteReader();
            drLibros.Read();
            Libro lbuscado = new Libro(drLibros["title_id"].ToString(), drLibros["title"].ToString(), drLibros["type"].ToString(),
                drLibros["pub_id"].ToString(), Convert.ToDecimal(drLibros["price"]), Convert.ToDateTime(drLibros["pubdate"]));
            drLibros.Close();
            cerrar();
            return lbuscado;
        }

        public void InsertarLibro(Libro linsertar)
        {
            SqlCommand cmdLibros = new SqlCommand("insert into titles(title_id,title,type,pub_id,price,pubdate) " +
                "values (@title_id,@title,@type,@pub_id,@price,@pubdate)", cnn);
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

        public void EliminarLibro(string idLibro)
        {
            SqlCommand cmdLibros = new SqlCommand("Delete From titles Where title_id=@title_id", cnn);
            abrir();
            cmdLibros.Parameters.AddWithValue("@title_id", idLibro);
            cmdLibros.ExecuteNonQuery();
            cerrar();
        }

        public void ModificarLibro(Libro lmodificar, string lcodigo)
        {
            SqlCommand cmdLibros = new SqlCommand("UPDATE titles SET title_id=@title_id, title=@title, " +
                "type=@type, pub_id=@pubid, price=@price, pubdate=@pubdate WHERE title_id= title_id", cnn);
            abrir();
            cmdLibros.Parameters.AddWithValue("@title_id", lmodificar.Title_id);
            cmdLibros.Parameters.AddWithValue("@title", lmodificar.Title);
            cmdLibros.Parameters.AddWithValue("@type", lmodificar.Type);
            cmdLibros.Parameters.AddWithValue("@pub_id", lmodificar.Pub_id);
            cmdLibros.Parameters.AddWithValue("@price", lmodificar.Price);
            cmdLibros.Parameters.AddWithValue("@pubdate", lmodificar.Pubdate);
            cmdLibros.Parameters.AddWithValue("@lcodigo", lcodigo);
            cmdLibros.ExecuteNonQuery();
            cerrar();
        }


        
        public byte contarLibrosPorPrecio(decimal precio)
        {
            SqlCommand cmdLibros = new SqlCommand();
            cmdLibros.CommandType = System.Data.CommandType.StoredProcedure;
            cmdLibros.CommandText = "MyProc";
            cmdLibros.Connection = cnn;

            SqlParameter pprecio = new SqlParameter("@price", System.Data.SqlDbType.SmallInt);
            pprecio.Direction = System.Data.ParameterDirection.Input;
            pprecio.Value = precio;
            cmdLibros.Parameters.Add(pprecio);

            SqlParameter psalida = new SqlParameter("@out", System.Data.SqlDbType.SmallInt);
            psalida.Direction = System.Data.ParameterDirection.Output;
            cmdLibros.Parameters.Add(psalida);

            abrir();
            cmdLibros.ExecuteNonQuery();
            cerrar();
            return Convert.ToByte(cmdLibros.Parameters["@out"].Value);



            
        }
        

    }
}
