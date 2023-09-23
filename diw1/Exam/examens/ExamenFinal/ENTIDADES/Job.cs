using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Job
    {
        int job_id;
        string job_desc;
        int min_lvl;
        int max_lvl;

        public Job()
        {
        }

        public int Job_id { get => job_id; set => job_id = value; }
        public string Job_desc { get => job_desc; set => job_desc = value; }
        public int Min_lvl { get => min_lvl; set => min_lvl = value; }
        public int Max_lvl { get => max_lvl; set => max_lvl = value; }
    }
}
