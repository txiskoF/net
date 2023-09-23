
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTIDADES;
using NEGOCIO;


public partial class PRINCIPAL : System.Web.UI.Page
{
    N_LIBROS pLibros = new N_LIBROS();
    N_Editor pEditor = new N_Editor();
    protected void Page_Load(object sender, EventArgs e)
    {
        //si es la 1ª vez cargo la lista de editores
        if (!IsPostBack)
        {
            //llamo al DAOEditor
            List<Editor> editores=pEditor.getEditor();
            //los cargo en el GridView de Editores
            gvEditores.DataSource = editores;
            gvEditores.DataBind();
            //cargo los libros
            CargarLibros();
            //para ordendar ascendente o descendente
            ViewState["orden"] = "asc";
            ViewState["campo"] = "title_id";
        }
    }

    private void CargarLibros()
    {
        //obtengo los libros para cargarlos en el GridView de Libros
        gvLibros.DataSource = pLibros.getLibros();
        gvLibros.DataBind();
    }

    protected void gvLibros_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //para modificar
        gvLibros.EditIndex = e.NewEditIndex;
        CargarLibros();
    }

    protected void gvLibros_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        //para cancelar la modificacion
        gvLibros.EditIndex = -1;
        CargarLibros();
    }

    protected void gvLibros_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        TextBox TxtTitle_Id = (TextBox)gvLibros.Rows[e.RowIndex].FindControl("txtTitle_Id");
        TextBox TxtTitle = (TextBox)gvLibros.Rows[e.RowIndex].FindControl("txtTitle");
        TextBox TxtType = (TextBox)gvLibros.Rows[e.RowIndex].FindControl("txtType");
        TextBox TxtPrice = (TextBox)gvLibros.Rows[e.RowIndex].FindControl("txtPrice");
        TextBox TxtPub_Id = (TextBox)gvLibros.Rows[e.RowIndex].FindControl("txtPub_Id");
        TextBox TxtPubdate = (TextBox)gvLibros.Rows[e.RowIndex].FindControl("txtPubdate");

        Libros lactualizar = new Libros(TxtTitle_Id.Text, TxtTitle.Text, TxtType.Text, Convert.ToDecimal(TxtPrice.Text), TxtPub_Id.Text, Convert.ToDateTime(TxtPubdate.Text));
        pLibros.actualizarLibro(lactualizar);
        gvLibros.EditIndex = -1;
        CargarLibros();
    }

    protected void gvLibros_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string Title_id = gvLibros.DataKeys[e.RowIndex].Value.ToString();
        pLibros.eliminarLibro(Title_id);
        CargarLibros();
    }

    protected void gvLibros_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName=="addnew")
        {
            TextBox TxtTitle_Id = (TextBox)gvLibros.FooterRow.FindControl("txtTitle_IdFooter");
            TextBox TxtTitle = (TextBox)gvLibros.FooterRow.FindControl("txtTitleFooter");
            TextBox TxtType = (TextBox)gvLibros.FooterRow.FindControl("txtTypeFooter");
            TextBox TxtPrice = (TextBox)gvLibros.FooterRow.FindControl("txtPriceFooter");
            TextBox TxtPub_Id = (TextBox)gvLibros.FooterRow.FindControl("txtPub_IdFooter");
            TextBox TxtPubdate = (TextBox)gvLibros.FooterRow.FindControl("txtPubdateFooter");

            Libros linsertar= new Libros(TxtTitle_Id.Text, TxtTitle.Text, TxtType.Text, Convert.ToDecimal(TxtPrice.Text), TxtPub_Id.Text, Convert.ToDateTime(TxtPubdate.Text));
            pLibros.insertarLibro(linsertar);
            CargarLibros();
        }
    }

    protected void gvLibros_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvLibros.PageIndex = e.NewPageIndex;
        CargarLibros();
    }

    protected void gvLibros_Sorting(object sender, GridViewSortEventArgs e)
    {
        string campo = ViewState["campo"].ToString();
        string orden = ViewState["orden"].ToString();
        if (campo.ToLower()==e.SortExpression.ToLower())
            if (orden=="asc")
            {
                e.SortDirection = SortDirection.Descending;
                ViewState["orden"] = "desc";
            }else
        {
                e.SortDirection = SortDirection.Ascending;
                ViewState["orden"] = "asc";
            }
        else {
            e.SortDirection = SortDirection.Ascending;
            ViewState["orden"] = "asc";
            ViewState["campo"] = e.SortExpression;
        }
    
//        if (orden=="asc")
//        {
//            e.SortDirection = SortDirection.Descending;
//            ViewState["orden"] = "desc";
//        }else
//{
//}  

        gvLibros.DataSource = pLibros.getLibros(e.SortExpression + " " + ViewState["orden"]);
        gvLibros.DataBind();
    }

    protected void gvEditores_SelectedIndexChanged(object sender, EventArgs e)
    {
        string editor=(gvEditores.DataKeys[gvEditores.SelectedIndex].Value).ToString();

        gvLibros.DataSource= pLibros.getLibrosEditor(editor);
        gvLibros.DataBind();
    }

  
}