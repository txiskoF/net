using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES_GRID;
using System.Data.SqlClient;

namespace DAO_GRID
{
   public class DAO_Editores:CONEXION
    {
        public List<Editor> getEditores()
        {
            List<Editor> LEditores = new List<Editor>();
            SqlCommand cmd = new SqlCommand("Select * from Publishers", cnn);
            abrir();
            SqlDataReader drEditores = cmd.ExecuteReader();
            while (drEditores.Read())
            {
                LEditores.Add(new Editor(
                    drEditores[0].ToString(),
                    drEditores[1].ToString(),
                    drEditores[2].ToString(),
                   drEditores[3].ToString(),
                    drEditores[4].ToString()));

            }
            drEditores.Close();
            cmd.Dispose();
            cerrar();
            return LEditores;
        }
    }

    }

