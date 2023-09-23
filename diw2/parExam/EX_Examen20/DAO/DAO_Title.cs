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
        //OBTENER LOS VALORES DE UN LIBRO
        public Title GetTitle(string title_id)
        {
           //creo una variable
            Title t = new Title();
            //hago select segun lo que me pasan
            SqlCommand cmdTitle = new SqlCommand("Select title_id, title, type, price From " +
                "titles where title_id=@title_id", cnn);
            cmdTitle.Parameters.AddWithValue("@title_id", title_id);
            abrir();
            SqlDataReader drTitle = cmdTitle.ExecuteReader();
            if (drTitle.Read())
            {
                //coloco en t los valores de la select
                t = new Title(drTitle[0].ToString(), drTitle[1].ToString(), drTitle[2].ToString(),
                    Convert.ToDouble(drTitle[3]));
            }
            drTitle.Close();
            cmdTitle.Dispose();
            cerrar();
            //devuelvo los datos del libro seleccionado
            return t;
        }

    }
}
