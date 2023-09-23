using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using ENTIDADES;

namespace DAL
{
    public class DAL_Employee
    {
        DAO_Employee DEmployee = new DAO_Employee();
        public List<String> getEmpIds(String pub_id)
        {
            return DEmployee.getEmpIds(pub_id);
        }

        public Employee getEmpId(string getEmpId)
        {
            return DEmployee.getEmpId(getEmpId);
        }

        public int cantidadEmployee(String pub_id)
        {
            return DEmployee.cantidadEmployee(pub_id);
        }

        public List<Employee> getEmployess(int job_lvl, string pub_id)
        {
            return DEmployee.getEmployess(job_lvl, pub_id);
        }
    }
}
