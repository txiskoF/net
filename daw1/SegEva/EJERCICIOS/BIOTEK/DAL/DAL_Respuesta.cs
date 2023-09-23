using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using ENTIDADES;

namespace DAL
{
    public class DAL_Respuesta
    {
        DAO_Respuesta DRespueta = new DAO_Respuesta();
        public List<Respuesta> GetRespuestas(int idPregunta)
        {
            return DRespueta.GetRespuestas(idPregunta);
        }

    }
}
