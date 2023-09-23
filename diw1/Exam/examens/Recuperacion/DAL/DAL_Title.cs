using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using ENTIDADES;

namespace DAL
{
    public class DAL_Title
    {
        DAO_Title DTitle = new DAO_Title();

        public Title GetTitle(string title_id)
        {
            return DTitle.GetTitle(title_id);
        }
    }
}
