using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ENTIDADES;

namespace DATOS
{
   public class D_Editor : Conexion
    {
        public List<Editor> getEditor()
        {
            List<Editor> lEditores = new List<Editor>();
            SqlCommand cmdEditor = new SqlCommand("Select * from publishers", cnn);
            abrir();
            SqlDataReader drEditor = cmdEditor.ExecuteReader();
            while (drEditor.Read())
            {
                Editor e = new Editor(drEditor[0].ToString(), drEditor[1].ToString(), drEditor[2].ToString(), drEditor[3].ToString(), drEditor[4].ToString());
                lEditores.Add(e);
            }
            drEditor.Close();
            cmdEditor.Dispose();
            return lEditores;
        } 
    }
}
