using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAssignment2
{
    public class Product
    {
        // properties
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

        // constructor
        public Product(int productId, string productName, int price, int stock)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        // methods
        // method to increase stock
        public void IncreaseStock(int number)
        {
            Stock += number;
        }

        // method to decrease stock
        public void DecreaseStock(int number)
        {
            Stock -= number;
        }
    }
}
