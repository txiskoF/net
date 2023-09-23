using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using ENTIDADES;

namespace DAL
{
    public class DAL_Publisher
    {
        DAO_Publisher DPublisher = new DAO_Publisher();
        public List<Publisher> getEditoriales()
        {
            return DPublisher.getEditoriales();
        }
    }
}
