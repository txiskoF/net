using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;
using ENTITY;

namespace EJEMPLO_BASE_DATOS
{
    public partial class Inicio : System.Web.UI.Page
    {
        DAL_Libros nlibro = new DAL_Libros();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<string> listado = nlibro.mostrarTitulos();
                foreach (string titulo in listado)
                {
                    ddlLibros.Items.Add(titulo);
                }
                Lblnumlibros.Text = " Total Libros: " + nlibro.contarlibros().ToString() ;
            }
        }

        protected void ddlLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            Libro Lbuscado = nlibro.mostrarDatosLibro(ddlLibros.SelectedItem.Text);
            TxtIdLibro.Text = Lbuscado.Pub_id;
            TxtTitulo.Text = Lbuscado.Title;
            TxtTipo.Text = Lbuscado.Type;
            TxtEditor.Text = Lbuscado.Pub_id;
            TxtPrecio.Text = Lbuscado.Price.ToString();
            TxtFechaEdicion.Text = Lbuscado.Pubdate.ToLongDateString();
           
        }

        protected void TxtBuscaTitulo_TextChanged(object sender, EventArgs e)
        {
            ddlLibros.Items.Clear();
            List<string> LBuscaLibros=nlibro.buscarTitulos(TxtBuscaTitulo.Text);
            foreach (string item in LBuscaLibros)
            {
                ddlLibros.Items.Add(item);
            }
        }
    }
}