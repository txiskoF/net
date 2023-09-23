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

        public List<String> getTitleIds(String ord_num)
        {
            return DSale.getTitleIds(ord_num);
        }

        public int cantidadLibros(String stor_id, String ord_num, String title_id)
        {
            return DSale.cantidadLibros(stor_id, ord_num, title_id);
        }

        public void insertarNuevoLibro(String stor_id, String ord_num, String title_id, int qty)
        {
            DSale.insertarNuevoLibro(stor_id, ord_num, title_id, qty);
        }
        public void borrarLibro(String stor_id, String ord_num, String title_id)
        {
            DSale.borrarLibro(stor_id, ord_num, title_id);
        }

        public List<Sale> getSalesGrid(String stor_id)
        {
            return DSale.getSalesGrid(stor_id);
        }

        public List<Sale> getLibrosGrid(stor_id)
        {
            return DSale.getLibrosGrid(stor_id)
        };
    }
}
