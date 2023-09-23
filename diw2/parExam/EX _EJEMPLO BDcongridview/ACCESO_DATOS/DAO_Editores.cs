using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.Data.SqlClient;

namespace ACCESO_DATOS
{
   public class DAO_Editores:Conexion
    {

        public List<Editor> getEditores()
        {
            List<Editor> LEditores = new List<Editor>();
            SqlCommand cmdEditor = new SqlCommand("Select * from publishers", cnn);
            abrir();
            SqlDataReader drEditor = cmdEditor.ExecuteReader();
            while (drEditor.Read())
            {
                LEditores.Add(new Editor(drEditor[0].ToString(), drEditor[1].ToString(),
                    drEditor[2].ToString(), drEditor[3].ToString(), drEditor[4].ToString()));
            }
            drEditor.Close();
            cerrar();
            cmdEditor.Dispose();
            return LEditores;
        }
    }
}
