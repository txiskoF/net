using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Employee : Conexion
    {

        public List<String> getEmpIds(String pub_id)
        {
            List<String> EmpIds = new List<string>();
            SqlCommand cmd = new SqlCommand("Select emp_id From Employee Where pub_id=@pub_id", cnn);
            cmd.Parameters.AddWithValue("@pub_id", pub_id);
            abrir();
            SqlDataReader drEmpIds = cmd.ExecuteReader();
            while (drEmpIds.Read())
            {
                EmpIds.Add(drEmpIds[0].ToString());
            }
            drEmpIds.Close();
            cmd.Dispose();
            cerrar();
            return EmpIds;
        }



       
        public Employee getEmpId(string getEmpId)
        {
            Employee e = new Employee();
            SqlCommand cmd = new SqlCommand("Select fname, lname, job_lvl From emloyee " +
                "Where getEmpId=@getEmpId", cnn);
            cmd.Parameters.AddWithValue("@getEmpId", getEmpId);
            abrir();
            SqlDataReader drEmployee = cmd.ExecuteReader();
            if (drEmployee.Read())
            {
                e = new Employee(drEmployee[0].ToString(), drEmployee[1].ToString(), 
                    Convert.ToInt32(drEmployee[2]));
            }
            drEmployee.Close();
            cmd.Dispose();
            cerrar();
            return e;
        }

        //PARA CALCULAR LA CANTIDAD DE EMPLEADOS DE UNA EDITORIAL
        public int cantidadEmployee (String pub_id)
        {
            int Cantidad = 0;
            //hago la select
            SqlCommand cmd = new SqlCommand("Select count(*) emp_id From publishers Where pub_id=@pub_id", cnn);
            cmd.Parameters.AddWithValue("@pub_id", pub_id);
            abrir();
            //leo los datos
            SqlDataReader drCantidad = cmd.ExecuteReader();
            //guardo en Cantidad
            if (drCantidad.Read())
            {
                Cantidad = Convert.ToInt32(drCantidad[0]);
            }
            drCantidad.Close();
            cmd.Dispose();
            cerrar();
            return Cantidad;
        }



        public List<Employee> getEmployess(int job_lvl, string pub_id)
        {
            SqlCommand cmd = new SqlCommand("Select emp_id, fname, lname, job_lvl From Jobs Where job_lvl=@job_lvl and pub_id=@pub_id", cnn);
            cmd.Parameters.AddWithValue("@job_lvl", job_lvl);
            cmd.Parameters.AddWithValue("@pub_id", pub_id);
            abrir();
            SqlDataReader drEmployees = cmd.ExecuteReader();
            List<Employee> lEmployee = new List<Employee>();
            while (drEmployees.Read())
            {
                Employee e = new Employee(drEmployees[0].ToString(), drEmployees[1].ToString(),
                    drEmployees[2].ToString(), Convert.ToInt32(drEmployees[3]));
                lEmployee.Add(e);
            }
            drEmployees.Close();
            cmd.Dispose();
            cerrar();
            return lEmployee;
        }



    }
}
