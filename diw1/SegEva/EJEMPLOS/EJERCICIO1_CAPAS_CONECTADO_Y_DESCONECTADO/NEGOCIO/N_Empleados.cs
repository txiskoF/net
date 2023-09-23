using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DATOS;

namespace NEGOCIO
{
    public class N_Empleados
    {
        D_Empleados nempleado = new D_Empleados();
        public List<Empleados> mostrarEmpleados()
        {
            return nempleado.mostrarEmpleados();
        }
    }
}

