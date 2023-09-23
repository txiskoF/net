using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_Title : Conexion
    {

        //obtenr un titulo segun su id
        public Title GetTitle(string title_id)
        {
            Title t = new Title();
            SqlCommand cmdTitle = new SqlCommand("Select * From titles where title_id=@title_id", cnn);
            cmdTitle.Parameters.AddWithValue("@title_id", title_id);
            abrir();
            SqlDataReader drTitle = cmdTitle.ExecuteReader();
            if (drTitle.Read())
            {
                t = new Title(drTitle[0].ToString(), drTitle[1].ToString(), drTitle[2].ToString(),
                    Convert.ToDouble(drTitle[3]));
            }
            drTitle.Close();
            cmdTitle.Dispose();
            cerrar();
            return t;
        }

        //insertar un nuevo libro no de este ejercicio
        public void insertarLibro(Libro linsertar)
        {
            SqlCommand cmdinsertar = new SqlCommand("insert into titles" +
                "(title_id,title,type,price,pubdate) values" +
                " (@title_id,@title,@type,@price,@pubdate)", cnn);
            cmdinsertar.Parameters.AddWithValue("@title_id", linsertar.Title_id);
            cmdinsertar.Parameters.AddWithValue("@title", linsertar.Title);
            cmdinsertar.Parameters.AddWithValue("@type", linsertar.Type);
            cmdinsertar.Parameters.AddWithValue("@price", linsertar.Price);
            cmdinsertar.Parameters.AddWithValue("@pubdate", linsertar.Pubdate);
            abrir();
            cmdinsertar.ExecuteNonQuery();
            cerrar();
        }

        //eliminar un libro no de este ejercicio
        public void eliminarLibro(string leliminar)
        {
            SqlCommand cmdeliminar = new SqlCommand("delete from titles" +
                 " WHERE title_id=@title_id", cnn);
            cmdeliminar.Parameters.AddWithValue("@title_id", leliminar);
            abrir();
            cmdeliminar.ExecuteNonQuery();
            cerrar();

        }

    }
}
