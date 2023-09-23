namespace ENTIDADES
{

    public class Store
    {
        int stor_id;
        string stor_name;

        public Store()
        {
        }

        public Store(int stor_id, string stor_name)
        {
            this.stor_id = stor_id;
            this.stor_name = stor_name;
        }

        public int Stor_id { get => stor_id; set => stor_id = value; }
        public string Stor_name { get => stor_name; set => stor_name = value; }
    }


}

