using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ACCESO_A_DATOS
{
    public class Conexion
    {
        protected SqlConnection cnn;

        public Conexion()
        {
            cnn=new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindConnection"].ConnectionString);
        }

        public void abrir() {
            if (cnn.State== System.Data.ConnectionState.Closed || cnn.State == System.Data.ConnectionState.Broken)
            {
                cnn.Open();
            }
          
        }

        public void cerrar() {

            if (cnn.State == System.Data.ConnectionState.Open)
            {
                cnn.Close();
            }
            }



    }
}
