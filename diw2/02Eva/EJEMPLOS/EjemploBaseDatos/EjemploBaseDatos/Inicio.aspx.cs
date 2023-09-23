using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;
using ENTITY;

namespace EjemploBaseDatos
{
    public partial class Inicio : System.Web.UI.Page
    {
        DAL_Libros nlibro = new DAL_Libros();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTitulos();
            }
        }

        private void CargarTitulos()
        {
            ddlLibros.Items.Clear();
            ddlLibros.Items.Add("Títulos de libros");
            List<string> listado = nlibro.mostrarTitulos();
            foreach (string titulo in listado)
            {
                ddlLibros.Items.Add(titulo);
            }
            Lblnumlibros.Text = " Total Libros: " + nlibro.contarLibros().ToString();
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
            ViewState["codigoLibro"] = Lbuscado.Title_id;

        }

        protected void TxtBuscaTitulo_TextChanged(object sender, EventArgs e)
        {
            ddlLibros.Items.Clear();
            List<string> LBuscaLibros = nlibro.buscarTitulos(TxtBuscaTitulo.Text);
            foreach (string item in LBuscaLibros)
            {
                ddlLibros.Items.Add(item);
            }
        }

        protected void BtnInsertar_Click(object sender, EventArgs e)
        {
            Libro linsertar = new Libro(TxtIdLibro.Text, TxtTitulo.Text, TxtTipo.Text, TxtEditor.Text, 
                Convert.ToDecimal(TxtPrecio.Text), Convert.ToDateTime(TxtFechaEdicion.Text));
            nlibro.InsertarLibro(linsertar);
            CargarTitulos();
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            nlibro.EliminarLibro(TxtIdLibro.Text);
            CargarTitulos();
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            Libro lmodificar = new Libro(TxtIdLibro.Text, TxtTitulo.Text, TxtTipo.Text, TxtEditor.Text,
                Convert.ToDecimal(TxtPrecio.Text), Convert.ToDateTime(TxtFechaEdicion.Text));
            nlibro.ModificarLibro(lmodificar, ViewState["codigoLibro"].ToString());
            CargarTitulos();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Lblnumlibros.Text =  nlibro.contarLibrosPorPrecio(Convert.ToDecimal(TxtPrecioCalcular.Text)).ToString();
        }
    }
}