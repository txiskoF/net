using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class ORDERDETAILS
    {
        int orderID;
        int productID;
        decimal unitprice;
        short quantity;
        double discount;

        public ORDERDETAILS() { }
        public int OrderID
        {
            get
            {
                return orderID;
            }

            set
            {
                orderID = value;
            }
        }

        public int ProductID
        {
            get
            {
                return productID;
            }

            set
            {
                productID = value;
            }
        }

        public decimal Unitprice
        {
            get
            {
                return unitprice;
            }

            set
            {
                unitprice = value;
            }
        }

        public short Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public double Discount
        {
            get
            {
                return discount;
            }

            set
            {
                discount = value;
            }
        }

        public ORDERDETAILS(int orderID, int productID, decimal unitprice, short quantity, double discount)
        {
            this.OrderID = orderID;
            this.ProductID = productID;
            this.Unitprice = unitprice;
            this.Quantity = quantity;
            this.Discount = discount;
        }
    }
}
