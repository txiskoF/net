using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Pedido
    {
        string idCliente;
        int idEmpleado;

        public Pedido(string idCliente, int idEmpleado)
        {
            this.IdCliente = idCliente;
            this.IdEmpleado = idEmpleado;
        }

        public string IdCliente { get => idCliente; set => idCliente = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
    }
}
