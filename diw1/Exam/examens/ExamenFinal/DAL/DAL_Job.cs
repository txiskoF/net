using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using ENTIDADES;

namespace DAL
{
    public class DAL_Job
    {
        DAO_Job Djob = new DAO_Job();
        public List<String> getJobDesc()
        {
            return Djob.getJobDesc();
        }
    }
}
