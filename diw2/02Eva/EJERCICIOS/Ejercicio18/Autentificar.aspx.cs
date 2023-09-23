using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio18
{
    public partial class Autentificar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Usuario> usuarios = new List<Usuario>();
                usuarios.Add(new Usuario("Marta", "marta"));
                usuarios.Add(new Usuario("Juan", "juan"));
                ViewState["Usuarios"] = usuarios;
                ViewState["intento"] = 0;
                txtUsuario.Focus();
            }
        }


        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            bool buscar = false;
            List<Usuario> listaUsuarios = (List<Usuario>)ViewState["Usuarios"];

            foreach (Usuario item in listaUsuarios)
            {
                if (item.Nombre1 == txtUsuario.Text && item.Contraseña1 == txtPassword.Text)
                {
                    buscar = true;
                }
            }
            if (buscar)
            {
                Session["nombre"] = txtUsuario.Text;
                Server.Transfer("Compras.aspx");
            }
            else if ((int)ViewState["intento"] != 2)
            {
                txtUsuario.Text = "";
                txtPassword.Text = "";
                txtUsuario.Focus();
                ViewState["intento"] = (int)ViewState["intento"] + 1;
            }
            else
            {
                txtUsuario.Enabled = false;
                txtPassword.Enabled = false;
            }

        }
    }
}