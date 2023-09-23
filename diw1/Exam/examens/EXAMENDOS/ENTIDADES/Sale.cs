using System;

namespace ENTIDADES
{

    public class Sale
    {
        string stor_id;
        string ord_num;
        DateTime ord_date;
        int qty;
        string payterms;
        string title_id;

        public Sale()
        { }

        public Sale(string ord_num)
        {
            this.ord_num = ord_num;
        }

        public Sale(string stor_id, int qty, string title_id, DateTime ord_date, String ord_num)
        {
            this.Stor_id = stor_id;
            this.Qty = qty;
            this.Title_id = title_id;
            this.Ord_date = ord_date;
            this.Ord_num = ord_num;
        }

        public Sale(string stor_id, string ord_num, DateTime ord_date, int qty, string payterms, string title_id)
        {
            this.Stor_id = stor_id;
            this.Ord_num = ord_num;
            this.Ord_date = ord_date;
            this.Qty = qty;
            this.Payterms = payterms;
            this.Title_id = title_id;
        }

        public string Stor_id { get => stor_id; set => stor_id = value; }
        public string Ord_num { get => ord_num; set => ord_num = value; }
        public DateTime Ord_date { get => ord_date; set => ord_date = value; }
        public int Qty { get => qty; set => qty = value; }
        public string Payterms { get => payterms; set => payterms = value; }
        public string Title_id { get => title_id; set => title_id = value; }
    }
}

