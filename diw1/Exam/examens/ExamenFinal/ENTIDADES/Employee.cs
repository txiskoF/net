using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Employee
    {
        string emp_id;
        string fname;
        string minit;
        string lname;
        int job_id;
        int job_lvl;
        string pub_id;
        DateTime hire_date;

        public Employee()
        {
        }

        public Employee(string fname, string lname, int job_lvl)
        {
            this.fname = fname;
            this.lname = lname;
            this.job_lvl = job_lvl;
        }

        public Employee(string emp_id, string fname, string lname, int job_lvl)
        {
            this.emp_id = emp_id;
            this.fname = fname;
            this.lname = lname;
            this.job_lvl = job_lvl;
        }

        public string Emp_id { get => emp_id; set => emp_id = value; }
        public string Nombre { get => fname; set => fname = value; }
        public string Minit { get => minit; set => minit = value; }
        public string Apellido { get => lname; set => lname = value; }
        public int Job_id { get => job_id; set => job_id = value; }
        public int Job_lvl { get => job_lvl; set => job_lvl = value; }
        public string Pub_id { get => pub_id; set => pub_id = value; }
        public DateTime Hire_date { get => hire_date; set => hire_date = value; }
    }
}
