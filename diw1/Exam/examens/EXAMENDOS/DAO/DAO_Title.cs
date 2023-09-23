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

        public Title GetTitle(string title_id)
        {
           
            Title t = new Title();
            SqlCommand cmdTitle = new SqlCommand("Select title_id, title, type, price From " +
                "titles where title_id=@title_id", cnn);
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

    }
}
