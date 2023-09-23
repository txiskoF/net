using DAL;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIOTEK
{
    public partial class Registro : System.Web.UI.Page
    {
        DAL_Usuario dalusuario = new DAL_Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Nombre = txtNombre.Text;
            u.Email = txtEmail.Text;
            u.Password = txtPassword.Text;
            dalusuario.insertarUsuario(u);
            Server.Transfer("Principal.aspx");
        }
    }
}