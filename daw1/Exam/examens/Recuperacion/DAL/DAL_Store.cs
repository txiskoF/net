using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using ENTIDADES;

namespace DAL
{
    public class DAL_Store
    {
        DAO_Store DStore = new DAO_Store();

        public List<Store> getStores(string nombre)
        {
            return DStore.getStores(nombre);
        }
    }
}
