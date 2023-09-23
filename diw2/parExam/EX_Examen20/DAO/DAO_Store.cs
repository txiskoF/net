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

        public List<Store> getStores(string nombre)
        {
            //Obtengo la lista de almacenes coincidentes con el texto introducido
            SqlCommand cmdStore = new SqlCommand("Select stor_id, stor_name From stores Where stor_name like '%' + @stor_name + '%'", cnn);
            cmdStore.Parameters.AddWithValue("@stor_name", nombre);
            abrir();
            SqlDataReader drStore = cmdStore.ExecuteReader();
            //Creo un nuevo list
            List<Store> lStore = new List<Store>();
            //lo recorro
            while (drStore.Read())
            {
                //por cada fila la guardo con los datos
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
