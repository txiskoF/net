using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_Sale : Conexion
    {
        //para obener un listado
        public List<Sale> getSales(int stor_id)
        {
            SqlCommand cmdSale = new SqlCommand("Select distinct ord_num from sales Where stor_id=@stor_id", cnn);
            cmdSale.Parameters.AddWithValue("@stor_id", stor_id);
            abrir();
            SqlDataReader drSale = cmdSale.ExecuteReader();
            List<Sale> lSale = new List<Sale>();
            while (drSale.Read())
            {
                Sale s = new Sale(drSale[0].ToString(), drSale[1].ToString(), Convert.ToDateTime(drSale[2]),
                    Convert.ToInt16(drSale[3]), drSale[4].ToString(),
                    drSale[5].ToString());
                lSale.Add(s);
            }
            drSale.Close();
            cmdSale.Dispose();
            cerrar();
            return lSale;
        }

        //para obtenr un dato concreto
        public Sale GetSale(string ord_num)
        {
            Sale s = new Sale();
            SqlCommand cmdSale = new SqlCommand("Select stor_id, qty, title_id From Sales Where ord_num=@ord_num", cnn);
            cmdSale.Parameters.AddWithValue("@ord_num", ord_num);
            abrir();
            SqlDataReader drSale = cmdSale.ExecuteReader();
            if (drSale.Read())
            {
                s = new Sale(drSale[0].ToString(), Convert.ToInt32(drSale[3]), drSale[5].ToString());
            }

            drSale.Close();
            cmdSale.Dispose();
            cerrar();
            return s;
        }

    }
}
