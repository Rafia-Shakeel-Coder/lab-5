using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class Product
    {
        public int ProductID;
        public string Name;
        public double price ;
        public Product(int productID, string name, double Price)
        {
            ProductID = productID;
            Name = name;
            price = Price;
        }
    }

}
