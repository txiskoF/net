using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
   public class Editor
    {
        string pub_ID;
        string pubname;
        string city;
        string country;
        string state;

        public string Pub_ID
        {
            get
            {
                return pub_ID;
            }

            set
            {
                pub_ID = value;
            }
        }

        public string Pubname
        {
            get
            {
                return pubname;
            }

            set
            {
                pubname = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public Editor(string pub_ID, string pubname, string city, string country, string state)
        {
            this.Pub_ID = pub_ID;
            this.Pubname = pubname;
            this.City = city;
            this.Country = country;
            this.State = state;
        }
    }
}
