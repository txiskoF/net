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
    public partial class Formulario4 : System.Web.UI.Page
    {
        DAL_Respuesta dalRespuesta = new DAL_Respuesta();
        DAL_Pregunta dalPregunta = new DAL_Pregunta();
        RadioButtonList rblRespuestas;
        Label lblTitulo;

        protected void Page_Load(object sender, EventArgs e)
        {
            int idPregunta = Convert.ToInt32(Request.Params["idPregunta"]);

            Pregunta p = dalPregunta.GetPregunta(idPregunta);
            List<Respuesta> lResp = dalRespuesta.GetRespuestas(idPregunta);
            ViewState["listaRespuestas"] = lResp;
            ViewState["pregunta"] = p;

            Panel2.Visible = true;
            Panel3.Visible = false;
            Panel4.Visible = false;

            Label lblPregunta = new Label();
            lblPregunta.Text = p.Texto;
            Panel2.Controls.Add(lblPregunta);

            rblRespuestas = new RadioButtonList();
            rblRespuestas.AutoPostBack = true;
            rblRespuestas.SelectedIndexChanged += comprobarRespuestaCorrecta;

            foreach (Respuesta resp in lResp)
            {
                ListItem li;
                if (p.Tipo.Equals("imagen"))
                {
                    li = new ListItem(String.Format("<img width='375' height='50' src='" + resp.Texto + "'/>"), resp.IdRespuesta);
                }
                else
                {
                    li = new ListItem(resp.Texto, resp.IdRespuesta);
                }
                rblRespuestas.Items.Add(li);
            }
            Panel2.Controls.Add(rblRespuestas);

            Button btnAceptar = new Button();
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.Command += irFormularioTres;
            Panel4.Controls.Add(btnAceptar);
        }

        protected void comprobarRespuestaCorrecta(object sender, EventArgs e)
        {
            List<Respuesta> lRespuestas =(List<Respuesta>)( ViewState["listaRespuestas"]);
            bool encontrado = false;
            int i = 0;
            while (!encontrado && i < lRespuestas.Count)
            {
                Respuesta resp = lRespuestas.ElementAt(i);
                if (resp.IdRespuesta.Equals(rblRespuestas.SelectedValue))
                {
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }
            Respuesta respuestaSeleccionada = lRespuestas.ElementAt(i);
            string textoLabel = "";
            if (respuestaSeleccionada.Correcto == 1)
            {
                textoLabel = "VERDADERO";
                ((int[])Session["estadoPreguntas"])[respuestaSeleccionada.IdPregunta - 1] = 1;
            } else
            {
                textoLabel = "FALSO";
                ((int[])Session["estadoPreguntas"])[respuestaSeleccionada.IdPregunta - 1] = 2;
            }

            Panel2.Visible = false;
            Panel3.Visible = true;
            Panel4.Visible = true;

            lblTitulo = new Label();
            lblTitulo.Text = textoLabel;
            Panel3.Controls.Add(lblTitulo);

            Label lblEnunciado = new Label();
            Pregunta p = (Pregunta)ViewState["pregunta"];
            lblEnunciado.Text = p.Texto;
            Panel3.Controls.Add(lblEnunciado);
            
            if (p.Tipo.Equals("texto"))
            {
                Label lblTexto = new Label();
                lblTexto.Text = respuestaSeleccionada.Texto;
                Panel3.Controls.Add(lblTexto);
            } else
            {
                Image imagen = new Image();
                imagen.ImageUrl = respuestaSeleccionada.Texto;
                Panel3.Controls.Add(imagen);
            } 
            
            Label lblExplicacion = new Label();
            lblExplicacion.Text = respuestaSeleccionada.Explicacion;
            Panel3.Controls.Add(lblExplicacion);
        }

        private void irFormularioTres(object sender, CommandEventArgs e)
        {
            Response.Redirect("Formulario3.aspx");
        }

        
    }
}