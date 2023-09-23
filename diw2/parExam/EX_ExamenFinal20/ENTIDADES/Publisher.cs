using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Publisher
    {
        string pub_id;
        string pub_name;
        string city;
        string state;
        string country;

        public Publisher()
        {
        }

        public Publisher(string pub_id, string pub_name)
        {
            this.pub_id = pub_id;
            this.pub_name = pub_name;
        }

        public string Pub_id { get => pub_id; set => pub_id = value; }
        public string Pub_name { get => pub_name; set => pub_name = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Country { get => country; set => country = value; }
    }
}
