using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DAO_GRID
{
    public class CONEXION
    {
        protected SqlConnection cnn;

        public CONEXION()
        {
            cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Pubs"].ConnectionString);
        }

        public void abrir()
        {
            cnn.Open();

        }
        public void cerrar()
        {
            cnn.Close();
        }

    }
}
