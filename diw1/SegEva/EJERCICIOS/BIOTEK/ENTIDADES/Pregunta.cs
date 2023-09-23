using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    [Serializable]
    public class Pregunta
    {
        int idPregunta;
        string texto;
        DateTime fecha;
        string tipo;

        public Pregunta()
        {
        }

        public Pregunta(int idPregunta, string texto, DateTime fecha, string tipo)
        {
            this.idPregunta = idPregunta;
            this.texto = texto;
            this.fecha = fecha;
            this.tipo = tipo;
        }

        public int IdPregunta { get => idPregunta; set => idPregunta = value; }
        public string Texto { get => texto; set => texto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
