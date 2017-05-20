using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etud_20._05._2017
{
    class Product
    {
      public static List<Product> productList = new List<Product>();

        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int stock { get; set; }


        public Product(int id,string name,double price,int stock)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.stock = stock;
        }
        public static void AddProduct(Product product)
        {
            productList.Add(product);
        }

        public static void Show()
        {
            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}", "id", "name", "price", "stock");

            foreach (Product list in productList)
            {
                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}", list.id, list.name, list.price, list.stock);

            }
        }
        
    }
}
