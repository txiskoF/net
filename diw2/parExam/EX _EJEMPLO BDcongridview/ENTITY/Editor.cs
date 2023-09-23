using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Editor
    {
        public string pub_id { get; set; }
        public string pubname { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }

        public Editor()
        {

        }

        public Editor(string pub_id, string pubname, string city, string state, string country)
        {
            this.pub_id = pub_id;
            this.pubname = pubname;
            this.city = city;
            this.state = state;
            this.country = country;
        }
    }
}
