namespace ENTIDADES
{

    public class Title
    {
        string title_id;
        string titulo;
        string type;
        double price;

        public Title()
        {
        }

        public Title(string title_id, string titulo, string type, double price)
        {
            this.title_id = title_id;
            this.titulo = titulo;
            this.type = type;
            this.price = price;
        }

        public string Title_id { get => title_id; set => title_id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Type { get => type; set => type = value; }
        public double Price { get => price; set => price = value; }
    }
}

