using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES_GRID
{
    public class LIBROS
    {
        string title_ID;
        string title;
        string type;
        decimal price;
        string pub_ID;
        DateTime pubdate;

        public LIBROS(string title_ID, string title, string type, decimal price, string pub_ID, DateTime pubdate)
        {
            this.Title_ID = title_ID;
            this.Title = title;
            this.Type = type;
            this.Price = price;
            this.Pub_ID = pub_ID;
            this.Pubdate = pubdate;
        }

        public string Title_ID { get => title_ID; set => title_ID = value; }
        public string Title { get => title; set => title = value; }
        public string Type { get => type; set => type = value; }
        public decimal Price { get => price; set => price = value; }
        public string Pub_ID { get => pub_ID; set => pub_ID = value; }
        public DateTime Pubdate { get => pubdate; set => pubdate = value; }
    }
}
