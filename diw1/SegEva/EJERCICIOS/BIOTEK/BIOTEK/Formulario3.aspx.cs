using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using ENTIDADES;

namespace BIOTEK
{
    public partial class Formulario3 : System.Web.UI.Page
    {
        DAL_Ranking dalRanking = new DAL_Ranking();
        protected void Page_Load(object sender, EventArgs e)
        {  
            if (Session["estadoPreguntas"] == null)
            {
                int[] estadoPreguntas = new int[]
                {
                    0,0,0,0,0,0,0,0,0,0
                };
                Session["estadoPreguntas"] = estadoPreguntas;
            }
            crearPreguntas();
        }

        protected void crearPreguntas()
        {
            int[] estadoPreguntas = (int[])Session["estadoPreguntas"];
            for (int i = 0; i < 10; i++)
            {
                int estado = estadoPreguntas[i];
                if (estado == 0)
                {
                    ImageButton imgbPregunta = new ImageButton();
                    imgbPregunta.ImageUrl = "/IMAGENES/Pregunta" + (i + 1) + ".png";
                    imgbPregunta.CommandArgument = Convert.ToString(i + 1);
                    imgbPregunta.Width = 120;
                    imgbPregunta.Height = 120;
                    imgbPregunta.Command += MostrarPregunta;
                    Panel2.Controls.Add(imgbPregunta);
                }
                else if (estado == 1)
                {
                    Image imageAcertado = new Image();
                    imageAcertado.ImageUrl = "/IMAGENES/Acierto" + (i + 1) + ".png";
                    imageAcertado.Width = 120;
                    imageAcertado.Height = 120;
                    Panel2.Controls.Add(imageAcertado);
                } else if(estado == 2)
                {
                    Image imageError = new Image();
                    imageError.ImageUrl = "/IMAGENES/Error" + (i + 1) + ".png";
                    imageError.Width = 120;
                    imageError.Height = 120;
                    Panel2.Controls.Add(imageError);
                }
            }
        }

        private void MostrarPregunta(object sender, CommandEventArgs e)
        {
            string IdPregunta = Convert.ToString(e.CommandArgument);
            ViewState["IdPregunta"] = IdPregunta;
            Response.Redirect("Formulario4.aspx?IdPregunta=" + IdPregunta);
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            int[] estadoPreguntas = (int[])Session["estadoPreguntas"];
            int puntuacion = 0;
            foreach( int estado in estadoPreguntas)
            {
                if (estado == 1)
                {
                    puntuacion++;
                }
            }

            int idUsuario = (int)Session["idUsuario"];
            DateTime fecha = DateTime.Now;

            Ranking ranking = new Ranking(idUsuario, fecha, puntuacion);
            
            dalRanking.insertarPuntuacion(ranking);
            Session.Abandon();
            Response.Redirect("Principal.aspx");

        }
    }
}