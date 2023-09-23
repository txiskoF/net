using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AccesoDatos;

namespace ACCESO_DATOS
{
    public class DAO_Libros:Conexion
    {
        public List<string> mostrarTitulos() {

            List<string> Llibros = new List<string>();
            SqlCommand cmdLibros = new SqlCommand("select title from titles", cnn);
            abrir();
            SqlDataReader drLibros=cmdLibros.ExecuteReader();
            while (drLibros.Read())
            {
                Llibros.Add(drLibros["title"].ToString());
            }
            cerrar();
            return Llibros;
        }

    }
}
