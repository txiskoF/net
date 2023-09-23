using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Libros
    {
        string title_Id;
        string title;
        string type;
        decimal price;
        string pub_id;
        DateTime pubdate;

        public Libros(string title_Id, string title, string type, decimal price, string pub_id, DateTime pubdate)
        {
            this.title_Id = title_Id;
            this.title = title;
            this.type = type;
            this.price = price;
            this.pub_id = pub_id;
            this.pubdate = pubdate;
        }

        public string Title_Id
        {
            get
            {
                return title_Id;
            }

            set
            {
                title_Id = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string Pub_id
        {
            get
            {
                return pub_id;
            }

            set
            {
                pub_id = value;
            }
        }

        public DateTime Pubdate
        {
            get
            {
                return pubdate;
            }

            set
            {
                pubdate = value;
            }
        }
    }
}
