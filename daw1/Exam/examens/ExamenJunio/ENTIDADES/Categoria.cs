using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Categoria
    {

        int CategoryID;
        string CategoryName;
        string Description;

        public Categoria()
        {

        }

        public Categoria(int categoryID, string categoryName, string description)
        {
            CategoryID1 = categoryID;
            CategoryName1 = categoryName;
            Description1 = description;
        }

        public int CategoryID1 { get => CategoryID; set => CategoryID = value; }
        public string CategoryName1 { get => CategoryName; set => CategoryName = value; }
        public string Description1 { get => Description; set => Description = value; }
    }
}
