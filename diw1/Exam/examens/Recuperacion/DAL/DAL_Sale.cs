using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using ENTIDADES;

namespace DAL
{
    public class DAL_Sale
    {

        DAO_Sale DSale = new DAO_Sale();

        public List<Sale> getSales(int stor_id)
        {
            return DSale.getSales(stor_id);
        }

        public Sale GetSale(string ord_num)
        {
            return DSale.GetSale(ord_num);
        }

    }
}
