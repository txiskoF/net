using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Libro
    {
        string title_id;
        string title;
        string type;
        string pub_id;
        decimal price;
        DateTime pubdate;

        public Libro(string title_id, string title, string type, string pub_id, decimal price, DateTime pubdate)
        {
            this.title_id = title_id;
            this.title = title;
            this.type = type;
            this.pub_id = pub_id;
            this.price = price;
            this.pubdate = pubdate;
        }

        public string Title_id { get => title_id; set => title_id = value; }
        public string Title { get => title; set => title = value; }
        public string Type { get => type; set => type = value; }
        public string Pub_id { get => pub_id; set => pub_id = value; }
        public decimal Price { get => price; set => price = value; }
        public DateTime Pubdate { get => pubdate; set => pubdate = value; }
    }
}
