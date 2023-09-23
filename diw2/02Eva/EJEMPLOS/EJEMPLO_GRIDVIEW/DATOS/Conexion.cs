using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Configuration;
using System.Data.SqlClient;

namespace DATOS
{
    public class Conexion
    {
        protected SqlConnection cnn;
        public Conexion()
        {
            cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Pubs"].ConnectionString);
        }
        public void abrir()
        {
            if (cnn.State== System.Data.ConnectionState.Closed || cnn.State == System.Data.ConnectionState.Broken)
            {
                cnn.Open();
            }
            
        }
        public void cerrar()
        {
            if (cnn.State == System.Data.ConnectionState.Open) {
            cnn.Close();
            }
        }
    }
}
