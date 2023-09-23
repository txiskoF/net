using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data.SqlClient;

namespace DAO
{
   
    public class DAOCategoria : Conexion
    {

        public List<Categoria> GetCategorias(string nombre)
        {
            SqlCommand cmdCategoria = new SqlCommand("Select CategoryID, CategoryName, Description From categories Where CategoryName  like '%' + @CategoryName + '%'", cnn);
            cmdCategoria.Parameters.AddWithValue("@CategoryName", nombre);
            abrir();
            SqlDataReader drCategoria = cmdCategoria.ExecuteReader();
            List<Categoria> lCategoria = new List<Categoria>();
            while (drCategoria.Read())
            {
                Categoria c = new Categoria(Convert.ToInt32(drCategoria[0]), drCategoria[1].ToString(), drCategoria[2].ToString()) ;
                lCategoria.Add(c);
            }
            drCategoria.Close();
            cmdCategoria.Dispose();
            cerrar();
            return lCategoria;
        }

       




    }
}
