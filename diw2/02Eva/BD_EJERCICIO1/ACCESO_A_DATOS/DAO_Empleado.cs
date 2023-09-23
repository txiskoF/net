using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ENTIDADES;

namespace ACCESO_A_DATOS
{
    public class DAO_Empleado : Conexion
    {
        public List<Empleado> mostrarEmpleados()
        {
            List<Empleado> LEmpleados = new List<Empleado>();
            SqlCommand cmdEmp = new SqlCommand("Select EmployeeId,FirstName,LastName From Employees", cnn);
            abrir();
            SqlDataReader drEmp = cmdEmp.ExecuteReader();
            while (drEmp.Read())
            {
                LEmpleados.Add(new Empleado(drEmp[0].ToString(), drEmp[1].ToString(),drEmp[2].ToString()));
            }
            drEmp.Close();
            cmdEmp.Dispose();
            cerrar();
            return LEmpleados;
        }

    }
}
