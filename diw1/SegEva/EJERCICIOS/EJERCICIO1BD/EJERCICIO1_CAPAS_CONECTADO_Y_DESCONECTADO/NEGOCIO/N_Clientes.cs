using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DATOS;

namespace NEGOCIO
{
    public class N_Clientes
    {
        D_Clientes ncliente = new D_Clientes();
        public List<Clientes> mostrarClientes()
        {
            return ncliente.mostrarClientes();
        }
        }
}
