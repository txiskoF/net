using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Configuration;
using System.Data.SqlClient;

namespace DATOS
{
    public class D_Clientes:Conexion
    {
        public List<Clientes> mostrarClientes()
        {
            SqlCommand cmd = new SqlCommand("Select * FROM customers", cnn);
            abrir();
            SqlDataReader drClientes=cmd.ExecuteReader();
            List<Clientes> lclientes = new List<Clientes>();
            while (drClientes.Read())
            {
               lclientes.Add(new Clientes(drClientes[0].ToString(), drClientes[1].ToString()));
            }
            drClientes.Close();
            cmd.Dispose();
            cerrar();
            return lclientes;
        }
    }
}
