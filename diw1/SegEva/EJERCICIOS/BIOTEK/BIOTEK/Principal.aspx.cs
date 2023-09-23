using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTIDADES;
using DAL;

namespace BIOTEK
{
    public partial class Principal : System.Web.UI.Page
    {
        DAL_Usuario dalusuario = new DAL_Usuario();
        DAL_Ranking dalranking = new DAL_Ranking();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Ranking> lRanking = dalranking.obtenerRanking();
            GridRanking.DataSource = lRanking;
            GridRanking.DataBind();
        }

        protected void txtIngresar_Click(object sender, EventArgs e)
        {
            string email = txtUsuario.Text;
            string pasword = txtContraseña.Text;
            Usuario u = dalusuario.getUsuario(email);
            if (u.Email == null)
            {
                Label1.Text = "El usuario no existe";
            }
            else { 
                if (u.Password.Equals(pasword))
                {
                    Session["idUsuario"] = u.IdUsuario;
                    Context.Items.Add("Correo", u.Email);
                    Context.Items.Add("Contraseña", u.Password);
                    Server.Transfer("Formulario3.aspx");
                } else
                {
                    Label1.Text = "La contraseña es incorrecta";
                }
            }
        }

        protected void txtRegistar_Click(object sender, EventArgs e)
        {

            Server.Transfer("Registro.aspx");

        }
    }
}