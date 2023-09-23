using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using ACCESO_A_DATOS;

namespace NEGOCIO
{
    public class DAL_Cliente
    {
        DAO_Cliente adocliente = new DAO_Cliente();
        public List<Cliente> mostrarClientes()
        {
            return adocliente.mostrarClientes();
        }
    }
}
