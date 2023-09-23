using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    [Serializable]
    public class Store
    {
        int stor_id;
        string stor_name;

        public Store()
        {
        }

        public Store(int stor_id, string stor_name)
        {
            this.Stor_id = stor_id;
            this.Stor_name = stor_name;
        }

        public int Stor_id { get => stor_id; set => stor_id = value; }
        public string Stor_name { get => stor_name; set => stor_name = value; }
    }
}
