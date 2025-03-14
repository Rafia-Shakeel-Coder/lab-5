using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace lab_5
{
    internal class Sopping_cart
    {
        public int cartid;
        public string customername;
        public double price;
        public Product[] Products;
        public int Productcount;
        public Sopping_cart(int cartid)
        {
            this.cartid = cartid;
            customername = " ";
            Products = new Product[10];
            price = 0;
            Productcount = 0;
        }
        public void Addproduct(Product product)
        {
            if (Productcount < 10)
            {
                Products[Productcount] = product;
                Productcount++;
                price = price + product.price;
            }
            else
            {
                Console.WriteLine("CART IS FULL");
            }
        }
        public void RemoveProduct(int productid)
        {
            for (int i = 0; i < Productcount; i++)
            {
                if (Products[i] != null && Products[i].ProductID == productid) ;
                price = price - Products[i].price;
                Products[i] = null;
                Console.WriteLine("PRODUCT REMOVED");
                return;
            }
            Console.WriteLine("PRODUCT NOT FOUND");
        }
        public void DisplayCart()
        {
            Console.WriteLine("CART ID {0}", cartid);
            Console.WriteLine("CUSTOMER name {0}", customername);
            Console.WriteLine("PRODUCTS IN THE LIST ");
            for (int i = 0; i < Productcount; i++)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Price: {2:C}", Products[i].ProductID, Products[i].Name, Products[i].price);
                Console.WriteLine("TOTAL PRICE {0}", price);
            }


        }
    }
}
