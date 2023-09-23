using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTITY;
using NEGOCIO;

namespace EJEMPLO_BASE_DATOS
{
    public partial class FormularioGrid : System.Web.UI.Page
    {
        DAL_Libros nlibro = new DAL_Libros();
        DAL_Editores nEditor = new DAL_Editores();
        protected void Page_Load(object sender, EventArgs e)
        {   
            //si es la 1ª vez cargo la lista de editores
            if (!IsPostBack)
            {
                //llamo a DAO_Editores
                gvEditores.DataSource = nEditor.getEditores();
                //ejecuto
                gvEditores.DataBind();
                //para ordendar ascendente o descendente
                ViewState["campo"] = "title_id";
               ViewState["direccion"] = "asc";
                //llamo a cargar libros
               CargarLibros();

            }
        }

        private void CargarLibros()
        {
            //llamo al dao asi para cargar libros
            List<Libro> LLibros = nlibro.getLibros();
            //asi para ordenar
            List<Libro> LLibros = nlibro.getLibros(ViewState["campo"].ToString() + " " + ViewState["direccion"].ToString());
            //cargo
            gvLibros.DataSource = LLibros;
            //ejecuto
            gvLibros.DataBind();
        }

        //para añadir nuevo libro
        protected void gvLibros_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //serea el commanname de la imagen
            switch (e.CommandName)
            {
                case "addnew":
                    string Title_Id = ((TextBox)gvLibros.FooterRow.FindControl("TxtFooterTitle_ID")).Text;
                    string Title = ((TextBox)gvLibros.FooterRow.FindControl("TxtFooterTitle")).Text;
                    string Type = ((TextBox)gvLibros.FooterRow.FindControl("TxtFooterType")).Text;
                    string Pub_Id = ((TextBox)gvLibros.FooterRow.FindControl("TxtFooterPub_ID")).Text;
                    decimal Price = Convert.ToDecimal(((TextBox)gvLibros.FooterRow.FindControl("TxtFooterPrice")).Text);
                    DateTime Pubdate= Convert.ToDateTime(((TextBox)gvLibros.FooterRow.FindControl("TxtFooterPubdate")).Text);
                    nlibro.InsertarLibro(new Libro(Title_Id,Title,Type,Pub_Id,Price,Pubdate));
                    CargarLibros();
                    break;
            }
        }

        protected void gvLibros_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //para editar una linea
            gvLibros.EditIndex = e.NewEditIndex;
            CargarLibros();

        }

        protected void gvLibros_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //para cancelar
            gvLibros.EditIndex = -1;
            CargarLibros();
        }

        protected void gvLibros_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //de la linea de edicion obtengo los datos de cada textbos
            TextBox txtTitle_Id = (TextBox)gvLibros.Rows[e.RowIndex].FindControl("TxtTitle_ID");
            TextBox txtTitle = (TextBox)gvLibros.Rows[e.RowIndex].FindControl("TxtTitle");
            TextBox txtType = (TextBox)gvLibros.Rows[e.RowIndex].FindControl("TxtType");
            TextBox txtPub_Id = (TextBox)gvLibros.Rows[e.RowIndex].FindControl("TxtPub_ID");
            TextBox txtPrice= (TextBox)gvLibros.Rows[e.RowIndex].FindControl("TxtPrice");
            TextBox txtPubdate = (TextBox)gvLibros.Rows[e.RowIndex].FindControl("TxtPubdate");
            //creo un libro con los datos obtenidos
            Libro lactualizar = new Libro(txtTitle_Id.Text, txtTitle.Text, txtType.Text, txtPub_Id.Text,
                Convert.ToDecimal(txtPrice.Text), Convert.ToDateTime(txtPubdate.Text));
            //llamo a este metodo para actualizar con lo que le paso
            nlibro.ActualizarLibro(lactualizar);
            //cancelo
            gvLibros.EditIndex = -1;
            //cargo los libros
            CargarLibros();
        }

        protected void gvLibros_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //coger el id del libro
            string title_id = gvLibros.DataKeys[0].Value.ToString();
            //llamo al metodo para borrar
            nlibro.EliminarLibro(title_id);
            CargarLibros();
        }


        //para paginar
        protected void gvLibros_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvLibros.PageIndex = e.NewPageIndex;
            CargarLibros();
        }

        //para ordenar por un campo
        protected void gvLibros_Sorting(object sender, GridViewSortEventArgs e)
        {
            if (e.SortExpression.ToLower() == ViewState["campo"].ToString().ToLower())
            {
                if (ViewState["direccion"].ToString() == "asc")
                {
                    e.SortDirection = SortDirection.Descending;
                    ViewState["direccion"] = "desc";
                }
                else
                {
                    e.SortDirection = SortDirection.Ascending;
                    ViewState["direccion"] = "asc";
                }

            }
            else
            {
                e.SortDirection = SortDirection.Ascending;
                ViewState["direccion"] = "asc";
                ViewState["campo"] = e.SortExpression;
            }
            CargarLibros();
        }

        protected void gvEditores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}