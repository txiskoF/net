using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Libro
    {
        string title_id;
        string title;
        string type;
        decimal price;
        DateTime pubdate;

        public Libro()
        {
        }
        public Libro(string title_id, string title, string type, decimal price, DateTime pubdate)
        {
            this.Title_id = title_id;
            this.Title = title;
            this.Type = type;
            this.Price = price;
            this.Pubdate = pubdate;
        }

        public string Title_id { get => title_id; set => title_id = value; }
        public string Title { get => title; set => title = value; }
        public string Type { get => type; set => type = value; }
        public decimal Price { get => price; set => price = value; }
        public DateTime Pubdate { get => pubdate; set => pubdate = value; }
    }
}
