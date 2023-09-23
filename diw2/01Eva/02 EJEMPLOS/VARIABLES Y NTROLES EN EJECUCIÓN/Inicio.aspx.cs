using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJEMPLO_VARIABLES
{
    public partial class Inicio : System.Web.UI.Page
    {
        //int numero = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["numero"] = 0;
                ViewState["creado"] = false;
                ViewState["creadaMatriz"] = false;
            }
            else { 
                if ((Boolean)ViewState["creado"])
                {
                   CrearBoton();
                }
                if ((Boolean)ViewState["creadaMatriz"])
                {
                    GenerarBotones();
                }
            }

        }


        protected void BtnIncremento_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(ViewState["numero"]);
            numero += 1;
            ViewState["numero"] = numero;
            LblResultado.Text = numero.ToString();

        }

        protected void BtnDecremento_Click(object sender, EventArgs e)
        {

            int numero = Convert.ToInt32(ViewState["numero"]);
            numero -= 1;
            ViewState["numero"] = numero;
            LblResultado.Text = numero.ToString();
        }

        
        /******************************************************************************
        // CREACIÓN Y BORRADO DE CONTROLES EN EJECUCIÓN
        // 1.- Creación de 1 Control en Ejecución
        // 2.- Creación de Varios Controles en Ejecución
        // 3.- Borrado de Controles en Ejecución
        //     3.1.- Borrado del Último control creado
        //     3.2.- Borrado de un determinado control (por su ID u otra propiedad) 
        ******************************************************************************/

        protected void BtnCrear_Click(object sender, EventArgs e)
        {
            if (!(Boolean)ViewState["creado"])
            {
                CrearBoton();
            }
        }
        private void CrearBoton()
        {
            Button BtnRedireccionamiento = new Button();
            BtnRedireccionamiento.Text = "Google";
            BtnRedireccionamiento.Click += BtnRedireccionamiento_Click;
            pnlBotones.Controls.Add(BtnRedireccionamiento);
            ViewState["creado"] = true;
        }

        private void BtnRedireccionamiento_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://www.google.es");
        }

     
        protected void BtnCrearMatriz_Click(object sender, EventArgs e)
        {
            if (!(Boolean)ViewState["creadaMatriz"])
            {
                GenerarBotones();
            }   
        }
            
        private void GenerarBotones()
        {
            Button[] BtnBotones = new Button[3];
            string[] nombre = new string[] { "Google", "Yahoo", "Bing" };

            for (int i = 0; i < BtnBotones.Length; i++)
            {
                BtnBotones[i] = new Button();
                BtnBotones[i].ID = "Btn" + nombre[i];
                BtnBotones[i].Text = nombre[i];
                BtnBotones[i].Style["Height"] = "40px";
                BtnBotones[i].Style["Width"] = "100px";
                BtnBotones[i].CommandName = nombre[i];
                BtnBotones[i].CommandArgument = "http://www." + nombre[i] + ".es";
                BtnBotones[i].Command += Navegador_Click;
                pnlBotones.Controls.Add(BtnBotones[i]);
                ViewState["creadaMatriz"] = true;
            }
        }

        private void Navegador_Click(object sender, CommandEventArgs e)
        {
            Response.Redirect(e.CommandArgument.ToString());
        }

        protected void BtnBorrar_Click(object sender, EventArgs e)
        {
            //Borrar el último control que ha sido creado o colocado en ejecución
            // pnlBotones.Controls.RemoveAt(pnlBotones.Controls.Count-1);

            //Borrar un control que nosotros queramos
            bool encontrado=false;
            byte i=0;

            //Recorrido con WHILE de todos los controles del Panel o cualquier
            //otro control contenedor donde queramos borrar y comprobar si es 
            // del tipo deseado y es el deseado
            
            while ( i < pnlBotones.Controls.Count && !encontrado)
            {

                if (pnlBotones.Controls[i] is Button)
                {
                    if (pnlBotones.Controls[i].ID == "BtnGoogle")
                    {
                        encontrado = true;
                        //Borrado con RemoveAt: Borra por posición (la posición i)
                        pnlBotones.Controls.RemoveAt(i);
                        //Borrado con Remove: Borra el objeto (el objeto pnlBotones.Controls[i])
                        //pnlBotones.Controls.Remove(pnlBotones.Controls[i]);
                    }

                }
                i += 1;
            }


            //Recorrido con FOR de todos los controles del Panel o cualquier
            //otro control contenedor donde queramos borrar y comprobar si es 
            // del tipo deseado y es el deseado

            //for (int i = 0; i < pnlBotones.Controls.Count; i++)
            //{

            //    if (pnlBotones.Controls[i] is Button)
            //    {
            //        if (pnlBotones.Controls[i].ID == "BtnGoogle")
            //        {
            //            //Borrado con RemoveAt: Borra por posición (la posición i)
            //            pnlBotones.Controls.RemoveAt(i);
            //            //Borrado con Remove: Borra el objeto (el objeto pnlBotones.Controls[i])
            //            //pnlBotones.Controls.Remove(pnlBotones.Controls[i]);
            //        }

            //    }
            //}
        }
    }
}