using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data.SqlClient;

namespace DAO
{
     public class DAO_Respuesta:Conexion
    {
        
        public List<Respuesta> GetRespuestas(int idPregunta)
        {
            SqlCommand cmdRespueta = new SqlCommand("select * From Respuestas Where idPregunta=@idPregunta", cnn);
            cmdRespueta.Parameters.AddWithValue("@idPregunta", idPregunta);
            abrir();
            SqlDataReader drRespuesta = cmdRespueta.ExecuteReader();
            List<Respuesta> lRespuesta = new List<Respuesta>();
            while (drRespuesta.Read())
            {
                Respuesta r = new Respuesta(Convert.ToInt32(drRespuesta[0]), drRespuesta[1].ToString(),
               Convert.ToInt32(drRespuesta[2]), drRespuesta[3].ToString(), drRespuesta[4].ToString());
                lRespuesta.Add(r);
            }
            drRespuesta.Close();
            cmdRespueta.Dispose();
            cerrar();
            return lRespuesta;
        }



    }
}
