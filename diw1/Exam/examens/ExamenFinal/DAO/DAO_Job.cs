using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_Job : Conexion
    {

        public List<String> getJobDesc()
        {
            List<String> jobDesc = new List<string>();
            SqlCommand cmd = new SqlCommand("Select job_desc From Jobs", cnn);
            abrir();
            SqlDataReader drJobs = cmd.ExecuteReader();
            while (drJobs.Read())
            {
                jobDesc.Add(drJobs[0].ToString());
            }
            drJobs.Close();
            cmd.Dispose(),
            cerrar();
            return jobDesc;
        }


        

    }
}
