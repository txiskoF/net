using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    [Serializable]
    public class Respuesta
    {
        int idPregunta;
        string idRespuesta;
        int correcto;
        string explicacion;
        string texto;

        public Respuesta()
        {
        }

        public Respuesta(int idPregunta, string idRespuesta, int correcto, string explicacion, string texto)
        {
            this.idPregunta = idPregunta;
            this.idRespuesta = idRespuesta;
            this.correcto = correcto;
            this.explicacion = explicacion;
            this.texto = texto;
        }

        public int IdPregunta { get => idPregunta; set => idPregunta = value; }
        public string IdRespuesta { get => idRespuesta; set => idRespuesta = value; }
        public int Correcto { get => correcto; set => correcto = value; }
        public string Explicacion { get => explicacion; set => explicacion = value; }
        public string Texto { get => texto; set => texto = value; }
    }
}
