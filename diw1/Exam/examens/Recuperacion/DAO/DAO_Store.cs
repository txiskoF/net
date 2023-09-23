using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_Store : Conexion
    {
        //obtener listado
        public List<Store> getStores(string nombre)
        {
            SqlCommand cmdStore = new SqlCommand("Select stor_id, stor_name From stores Where stor_name=@stor_name", cnn);
            cmdStore.Parameters.AddWithValue("@stor_name", nombre);
            abrir();
            SqlDataReader drStore = cmdStore.ExecuteReader();
            List<Store> lStore = new List<Store>();
            while (drStore.Read())
            {
                Store s = new Store(Convert.ToInt32(drStore[0]), drStore[1].ToString());
                lStore.Add(s);
            }
            drStore.Close();
            cmdStore.Dispose();
            cerrar();
            return lStore;
        }

    }
}
