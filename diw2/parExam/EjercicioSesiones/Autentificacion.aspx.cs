using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<Usuario> l = new List<Usuario>();
            l.Add(new Usuario("Marta", "M1"));
            l.Add(new Usuario("Luis", "L1"));
            l.Add(new Usuario("Juan", "J1"));
            l.Add(new Usuario("Pedro", "P1"));
            l.Add(new Usuario("Tomas", "T1"));
            ViewState["Usuarios"] = l;
            ViewState["contador"] = 0;
            txtusuario.Focus();
        }
    }
    protected void btnaceptar_Click(object sender, EventArgs e)
    {

       
        bool encontrado = false;
        List<Usuario> lista = (List<Usuario>)ViewState["Usuarios"];
        
      
        //Usuario usu = new Usuario(txtpassword.Text, txtusuario.Text);
        foreach (Usuario item in lista)
        {
            if (item.Login==txtusuario.Text && item.Password==txtpassword.Text) { 
                encontrado = true;
            }

        }
    
       // bool encontrado=lista.Contains(usu);
        //int posicioncontra=lista.IndexOf (contras,txtpassword.Text);
        //  if (posicionnombre==posicioncontra && contador<=2 && posicionnombre!=-1)
        if (encontrado)
                   {
            Session["nombre"] = txtusuario.Text;
            Server.Transfer("compras.aspx");
            }
        else if ((int)ViewState["contador"] != 2)
            {
            txtusuario.Text = "";
            txtpassword.Text = "";
            txtusuario.Focus();
            ViewState["contador"] = (int)ViewState["contador"] + 1;
            }
        else
            {
            txtusuario.Enabled = false;
            txtpassword.Enabled = false;
             }
   
    }
  
}