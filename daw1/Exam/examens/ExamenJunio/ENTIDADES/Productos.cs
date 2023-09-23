using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Productos
    {
        int ProductID;
        string ProductName;
        int SupplierID;
        int CategoryID;
        string QuantityPerUnit;
        double UnitPrice;
        int UnitsInStock;
        int UnitsOnOrder;
        int ReorderLevel;
        int Discontinued;

        public Productos()
        {

        }

        public Productos(int productID, string productName, int supplierID, int categoryID, string quantityPerUnit, double unitPrice, int unitsInStock, int unitsOnOrder, int reorderLevel, int discontinued)
        {
            ProductID1 = productID;
            ProductName1 = productName;
            SupplierID1 = supplierID;
            CategoryID1 = categoryID;
            QuantityPerUnit1 = quantityPerUnit;
            UnitPrice1 = unitPrice;
            UnitsInStock1 = unitsInStock;
            UnitsOnOrder1 = unitsOnOrder;
            ReorderLevel1 = reorderLevel;
            Discontinued1 = discontinued;
        }

        public int ProductID1 { get => ProductID; set => ProductID = value; }
        public string ProductName1 { get => ProductName; set => ProductName = value; }
        public int SupplierID1 { get => SupplierID; set => SupplierID = value; }
        public int CategoryID1 { get => CategoryID; set => CategoryID = value; }
        public string QuantityPerUnit1 { get => QuantityPerUnit; set => QuantityPerUnit = value; }
        public double UnitPrice1 { get => UnitPrice; set => UnitPrice = value; }
        public int UnitsInStock1 { get => UnitsInStock; set => UnitsInStock = value; }
        public int UnitsOnOrder1 { get => UnitsOnOrder; set => UnitsOnOrder = value; }
        public int ReorderLevel1 { get => ReorderLevel; set => ReorderLevel = value; }
        public int Discontinued1 { get => Discontinued; set => Discontinued = value; }
    }
}
