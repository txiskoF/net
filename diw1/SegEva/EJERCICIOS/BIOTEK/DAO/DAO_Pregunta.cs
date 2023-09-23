using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_Pregunta : Conexion
    {
        public Pregunta GetPregunta(int idPregunta)
        {
            SqlCommand cmdPregunta = new SqlCommand("Select * From Preguntas Where idPregunta=@idPregunta", cnn);
            cmdPregunta.Parameters.AddWithValue("@idPregunta", idPregunta);
            abrir();
            SqlDataReader drPregunta = cmdPregunta.ExecuteReader();
            drPregunta.Read();
            Pregunta p = new Pregunta(Convert.ToInt32(drPregunta[0]), drPregunta[1].ToString(),
                Convert.ToDateTime(drPregunta[2]), drPregunta[3].ToString());
            drPregunta.Close();
            cmdPregunta.Dispose();
            cerrar();
            return p;
        }
    }
}
