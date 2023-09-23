using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTIDADES;
using DAL;

namespace PRESENTACION_EJEMPLO1
{
    public partial class Principal : System.Web.UI.Page
    {
        DAL_Libro NLibro = new DAL_Libro();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                mostrarLibros();
        }

        private void mostrarLibros()
        {
            List<string> Libros = NLibro.getLibros();
            foreach (string item in Libros)
            {
                ddlLibros.Items.Add(item);
            }
            LblTotalLibros.Text = "Total de Libros: " + NLibro.totalLibros().ToString();
        }

        protected void ddlLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            Libro L=NLibro.getLibro(ddlLibros.SelectedItem.Text);
            txtIdLibro.Text = L.Title_id;
            txtTitulo.Text = L.Title;
            txtTipo.Text = L.Type;
            txtPrecio.Text = L.Price.ToString();
            txtFechaEdicion.Text = L.Pubdate.ToString();


         
        }

        protected void BtnInsertar_Click(object sender, EventArgs e)
        {
            Libro linsertar = new Libro(txtIdLibro.Text, 
                                        txtTitulo.Text,
                                        txtTipo.Text,
                                        Convert.ToDecimal(txtPrecio.Text), 
                                        Convert.ToDateTime(txtFechaEdicion.Text));
            NLibro.insertarLibro(linsertar);
            ddlLibros.Items.Clear();
            mostrarLibros();
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            Libro lmodificar = new Libro(txtIdLibro.Text,
                                      txtTitulo.Text,
                                      txtTipo.Text,
                                      Convert.ToDecimal(txtPrecio.Text),
                                      Convert.ToDateTime(txtFechaEdicion.Text));
            NLibro.modificarLibro(lmodificar);
            ddlLibros.Items.Clear();
            mostrarLibros();

        }

        protected void BtnBorrar_Click(object sender, EventArgs e)
        {
            NLibro.eliminarLibro(txtIdLibro.Text);
            ddlLibros.Items.Clear();
            mostrarLibros();
        }
    }
}