using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Cliente
    {
        string idCliente;
        string nombreCiente;

        public Cliente(string idCliente, string nombreCiente)
        {
            this.IdCliente = idCliente;
            this.NombreCiente = nombreCiente;
        }

        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCiente { get => nombreCiente; set => nombreCiente = value; }
    }
}
