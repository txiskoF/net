using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_Ranking : Conexion
    {
        public void insertarPuntuacion(Ranking ranking)
        {
            SqlCommand cmdinsertar = new SqlCommand("Insert INTO Ranking (idUsuario , fecha, puntuacion )" +
                "VALUES(@idUsuario, @fecha, @puntuacion)", cnn);
            cmdinsertar.Parameters.AddWithValue("@idUsuario", ranking.IdUsuario);
            cmdinsertar.Parameters.AddWithValue("@fecha", ranking.Fecha);
            cmdinsertar.Parameters.AddWithValue("@puntuacion", ranking.Puntuacion);
            abrir();
            cmdinsertar.ExecuteNonQuery();
            cerrar();

        }

        public List<Ranking> obtenerRanking()
        {
            List<Ranking> lRanking = new List<Ranking>();
            SqlCommand cmdRanking = new SqlCommand("Select * From Ranking Order By puntuacion desc, fecha desc", cnn);
            abrir();
            SqlDataReader drRanking = cmdRanking.ExecuteReader();
            while (drRanking.Read())
            {
                Ranking rank = new Ranking(Convert.ToInt32(drRanking[0]),
                    Convert.ToDateTime(drRanking[1]), Convert.ToInt32(drRanking[2]));
                lRanking.Add(rank);
            }

            drRanking.Close();
            cmdRanking.Dispose();
            cerrar();
            return lRanking;
        }
    }
}
