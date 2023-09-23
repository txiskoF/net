using System;
using DAL;
using ENTIDADES;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;

namespace ExamenJunio
{
    public partial class Productos : System.Web.UI.Page
    {
        DALCategoria DCategoria = new DALCategoria();
        DALProductos DProductos = new DALProductos();
   
   
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            Categoria c  = rellenarCategoria(txtidcat.Text);


           
        }


        private Categoria rellenarCategoria(String textoCategoria)
        {
            List<Categoria> Categorias = DCategoria(textoCategoria)
                foreach (Categoria cat in Categoria)
            {
                ListItem item = new ListItem(Convert.ToInt32(cat.CategoryID1), (cat.CategoryName1).ToString(), (cat.Description1).ToString());
                
            }
        }

        





    }
}