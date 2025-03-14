using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sopping_cart cart = new Sopping_cart(1);
            cart.customername = "Alice";

            Product p1 = new Product(1, "Laptop", 1200.50);
            Product p2 = new Product(2, "Mouse", 25.75);

            cart.Addproduct(p1);
            cart.Addproduct(p2);

            cart.DisplayCart();

            cart.RemoveProduct(2);
            cart.DisplayCart();
        }
    }
}
