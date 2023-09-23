using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL_GRID;
using ENTIDADES_GRID;

namespace PRESENTACION_GRID
{
    public partial class Principal : System.Web.UI.Page
    {
        DAL_LIBROS nLibro = new DAL_LIBROS();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarLibros();
                ViewState["campo"] = "Title";
                ViewState["direccion"] = "asc";
                gvEditores.DataSource=nLibro.getEditores();
                gvEditores.DataBind();
            }
        }

        private void CargarLibros()
        {
            List<LIBROS> Llibros = nLibro.getLibros();
            gvLibros.DataSource = Llibros;
            gvLibros.DataBind();
        }

        protected void gvLibros_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvLibros.EditIndex = e.NewEditIndex;
            //ViewState["id"] = gvLibros.DataKeys[0].Value;
            CargarLibros();
        }

        protected void gvLibros_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvLibros.EditIndex = -1;
            CargarLibros();
        }

        protected void gvLibros_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = gvLibros.DataKeys[0].Value.ToString();
            nLibro.deleteLibro(id);
            CargarLibros();
        }

        protected void gvLibros_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            TextBox TxtID = (TextBox)gvLibros.Rows[e.RowIndex].FindControl("TxtTitleId");
            TextBox TxtTitulo = (TextBox)gvLibros.Rows[e.RowIndex].FindControl("TxtTitle");
            TextBox TxtTipo = (TextBox)gvLibros.Rows[e.RowIndex].FindControl("TxtType");
            TextBox TxtPrecio = (TextBox)gvLibros.Rows[e.RowIndex].FindControl("TxtPrice");
            TextBox TxtEditor = (TextBox)gvLibros.Rows[e.RowIndex].FindControl("TxtPubId");
            TextBox TxtFEdicion = (TextBox)gvLibros.Rows[e.RowIndex].FindControl("TxtPubdate");

            LIBROS libro = new LIBROS(TxtID.Text,
                                    TxtTitulo.Text,
                                    TxtTipo.Text,
                                    Convert.ToDecimal(TxtPrecio.Text),
                                    TxtEditor.Text,
                                    Convert.ToDateTime(TxtFEdicion.Text));
            nLibro.updateLibros(libro);
            gvLibros.EditIndex = -1;
            CargarLibros();

        }

        protected void gvLibros_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "addnew")
            {
                TextBox TxtID = (TextBox)gvLibros.FooterRow.FindControl("TxtFooterTitleId");
                TextBox TxtTitulo = (TextBox)gvLibros.FooterRow.FindControl("TxtFooterTitle");
                TextBox TxtTipo = (TextBox)gvLibros.FooterRow.FindControl("TxtFooterType");
                TextBox TxtPrecio = (TextBox)gvLibros.FooterRow.FindControl("TxtFooterPrice");
                TextBox TxtEditor = (TextBox)gvLibros.FooterRow.FindControl("TxtFooterPubId");
                TextBox TxtFEdicion = (TextBox)gvLibros.FooterRow.FindControl("TxtFooterPubdate");

                LIBROS libro = new LIBROS(TxtID.Text,
                                   TxtTitulo.Text,
                                   TxtTipo.Text,
                                   Convert.ToDecimal(TxtPrecio.Text),
                                   TxtEditor.Text,
                                   Convert.ToDateTime(TxtFEdicion.Text));

                nLibro.insertLibro(libro);
                CargarLibros();
            }
        }

        protected void gvLibros_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvLibros.PageIndex = e.NewPageIndex;
            CargarLibrosOrdenado(ViewState["orden"].ToString());
        }

        protected void gvLibros_Sorting(object sender, GridViewSortEventArgs e)
        {
            string direccion = ViewState["direccion"].ToString();
            string campo = ViewState["campo"].ToString();

            if (campo == e.SortExpression && direccion == "asc")
            {
                e.SortDirection = SortDirection.Descending;
                ViewState["direccion"] = "desc";
            }
            else
            {
                e.SortDirection = SortDirection.Ascending;
                ViewState["direccion"] = "asc";
            }

            ViewState["orden"] = e.SortExpression + " " + ViewState["direccion"];
            ViewState["campo"] = e.SortExpression;
            CargarLibrosOrdenado(e.SortExpression + " " + ViewState["direccion"]);

        }

        private void CargarLibrosOrdenado(string orden)
        {
            List<LIBROS> LLista = nLibro.seleccionLibros(orden);
            gvLibros.DataSource = LLista;
            gvLibros.DataBind();
        }

        protected void gvEditores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ed = gvEditores.Rows[gvEditores.SelectedIndex].Cells[1].Text;
            //string editor = gvEditores.DataKeys[0].Value.ToString();
            gvLibros.DataSource = nLibro.getLibrosEditor(ed);
            gvLibros.DataBind();
        }
    }
}