using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
   public class Clientes
    {
        string idCliente;
        string nombreCliente;

        public Clientes(string idCliente, string nombreCliente)
        {
            this.IdCliente = idCliente;
            this.NombreCliente = nombreCliente;
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

        public string NombreCliente
        {
            get
            {
                return nombreCliente;
            }

            set
            {
                nombreCliente = value;
            }
        }
    }
}
