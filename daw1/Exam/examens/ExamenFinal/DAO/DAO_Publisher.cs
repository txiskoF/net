using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_Publisher : Conexion
    {
        public List<Publisher> getEditoriales()
        {
            List<Publisher> editoriales = new List<Publisher>();
            SqlCommand cmd = new SqlCommand("Select pub_id, pub_name From publishers", cnn);
            abrir();
            SqlDataReader drPublisher = cmd.ExecuteReader();
            List<Publisher> lPublisher = new List<Publisher>();
            while (drPublisher.Read())
            {
                Publisher p = new Publisher(drPublisher[0].ToString(), drPublisher[1].ToString());
                lPublisher.Add(p);
            }
            drPublisher.Close();
            cmd.Dispose();
            cerrar();
            return lPublisher;
        }
       
    }
}
