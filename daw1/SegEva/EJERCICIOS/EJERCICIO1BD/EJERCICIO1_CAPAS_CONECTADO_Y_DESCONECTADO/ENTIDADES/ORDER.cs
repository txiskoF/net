using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class ORDER
    {
        string idEmpleado;
        string idCliente;

        public string IdEmpleado
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

        public string IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
        }

        public ORDER(string idEmpleado, string idCliente)
        {
            this.IdEmpleado = idEmpleado;
            this.IdCliente = idCliente;
        }
    }
}
