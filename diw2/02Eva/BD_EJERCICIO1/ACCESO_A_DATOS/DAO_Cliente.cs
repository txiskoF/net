using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ENTIDADES;

namespace ACCESO_A_DATOS
{
    public class DAO_Cliente:Conexion
    {
        public List<Cliente> mostrarClientes()
        {
            List<Cliente> LClientes = new List<Cliente>();
            SqlCommand cmdCliente = new SqlCommand("Select CustomerId,CompanyName From Customers", cnn);
            abrir();
            SqlDataReader drCliente = cmdCliente.ExecuteReader();
            while (drCliente.Read())
            {
                LClientes.Add(new Cliente(drCliente[0].ToString(),drCliente[1].ToString()));
            }
            drCliente.Close();
            cmdCliente.Dispose();
            cerrar();
            return LClientes;
        }


    }
}
