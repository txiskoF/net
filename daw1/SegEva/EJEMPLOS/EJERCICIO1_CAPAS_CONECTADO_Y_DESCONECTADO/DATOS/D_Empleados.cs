using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data.SqlClient;

namespace DATOS
{
    public class D_Empleados:Conexion
    {
        public List<Empleados> mostrarEmpleados()
        {
            SqlCommand cmd = new SqlCommand("Select * FROM employees", cnn);
            abrir();
            SqlDataReader drEmpleados = cmd.ExecuteReader();
            List<Empleados> lempleados = new List<Empleados>();
            while (drEmpleados.Read())
            {
                Empleados emp = new Empleados(Convert.ToInt32(drEmpleados[0]), drEmpleados[1].ToString());
                lempleados.Add(emp);
            }
            drEmpleados.Close();
            cmd.Dispose();
            cerrar();
            return lempleados;
        }
    }
}
