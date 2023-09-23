using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using ENTIDADES;

namespace DAL
{
    public class DAL_Ranking
    {
        DAO_Ranking dRanking = new DAO_Ranking();
        public void insertarPuntuacion(Ranking ranking)
        {
            dRanking.insertarPuntuacion(ranking);
        }

        public List<Ranking> obtenerRanking()
        {
            return dRanking.obtenerRanking();
        }
    }
}
