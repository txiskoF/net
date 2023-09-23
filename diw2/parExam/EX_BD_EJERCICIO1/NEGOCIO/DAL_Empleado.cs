using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using ACCESO_A_DATOS;


namespace NEGOCIO
{
    public class DAL_Empleado
    {
        DAO_Empleado adoEmpleado = new DAO_Empleado();
        public List<Empleado> mostrarEmpleados()
        {
            return adoEmpleado.mostrarEmpleados();
        }
    }
}
