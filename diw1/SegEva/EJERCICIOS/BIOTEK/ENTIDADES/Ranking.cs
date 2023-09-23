using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Ranking
    {
        int idUsuario;
        DateTime fecha;
        int puntuacion;

        public Ranking()
        {
        }

        public Ranking(int idUsuario, DateTime fecha, int puntuacion)
        {
            this.idUsuario = idUsuario;
            this.fecha = fecha;
            this.puntuacion = puntuacion;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Puntuacion { get => puntuacion; set => puntuacion = value; }
    }
}
