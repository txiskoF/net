using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJEMPLO_VIEWSTATES
{
    public partial class Principal : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Button btnCrear = new Button();
            btnCrear.Text = "CREAR";
            btnCrear.Font.Name = "Arial";
            btnCrear.Click += BtnCrear_Click;
            form1.Controls.Add(btnCrear);
            if (!IsPostBack)
            {
                ViewState["numero"] = 0;
            }
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            float numero = 0.5F;
            decimal numero2 = 0.75m;
            TxtNumero.Text = "HOLAAAAA";
        }

        protected void BtnIncremento_Click(object sender, EventArgs e)
        {
            //Alumno a1 = new Alumno(1,"Marta",DateTime.Now);
            //ViewState["alumno1"] = a1;
            ////numero = Int32.Parse(ViewState["numero"]);
            ////numero = numero + 1;
            ////TxtNumero.Text = numero.ToString();
            ///
           


        }

        protected void BtnDecremento_Click(object sender, EventArgs e)
        {
            Alumno a2 = (Alumno)ViewState["alumno1"];
            TxtNumero.Text = a2.Nombre;
            //numero = int.Parse(TxtNumero.Text);
            //numero = numero - 1;
            //TxtNumero.Text = numero.ToString();

        }
    }
}