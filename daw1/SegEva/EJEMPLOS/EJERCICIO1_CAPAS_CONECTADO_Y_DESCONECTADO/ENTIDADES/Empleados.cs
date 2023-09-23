using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Empleados
    {
        int idEmpleado;
        string nombreEmpleado;

        public Empleados(int idEmpleado, string nombreEmpleado)
        {
            this.IdEmpleado = idEmpleado;
            this.NombreEmpleado = nombreEmpleado;
        }

        public int IdEmpleado
        {
            get
            {
                return idEmpleado;
            }

            set
            {
                idEmpleado = value;
            }
        }

        public string NombreEmpleado
        {
            get
            {
                return nombreEmpleado;
            }

            set
            {
                nombreEmpleado = value;
            }
        }
    }
}
