using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Empleado
    {
        string idEmpleado;
        string nombreEmpleado;
        string apellidoEmpleado;

        public Empleado(string idEmpleado, string nombreEmpleado, string apellidoEmpleado)
        {
            this.IdEmpleado = idEmpleado;
            this.NombreEmpleado = nombreEmpleado;
            this.ApellidoEmpleado = apellidoEmpleado;
        }

        public string IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public string ApellidoEmpleado { get => apellidoEmpleado; set => apellidoEmpleado = value; }
    }
}
