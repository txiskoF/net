using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using ENTIDADES;

namespace DAL
{
    public class DALCategoria
    {
        DAOCategoria DCategoria = new DAOCategoria();
        public List<Categoria> GetCategorias(string nombre)
        {
            return DCategoria.GetCategorias(nombre);
        }
        
    }
}
