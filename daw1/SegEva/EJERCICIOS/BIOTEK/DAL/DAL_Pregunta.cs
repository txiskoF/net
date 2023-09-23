using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using ENTIDADES;

namespace DAL
{
    public class DAL_Pregunta
    {
        DAO_Pregunta DPregunta = new DAO_Pregunta();
        public Pregunta GetPregunta(int idPregunta)
        {
            return DPregunta.GetPregunta(idPregunta);
        }
    }
}
