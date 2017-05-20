using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etud_20._05._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Product.AddProduct(new Product(id: 1, name: "acer", price: 1500, stock: 5));
            Product.AddProduct(new Product(id: 2, name: "acer", price: 1300, stock: 3));
            Product.AddProduct(new Product(id: 3, name: "acer", price: 1500, stock: 5));
            Product.AddProduct(new Product(id: 4, name: "acer", price: 1500, stock: 10));
            Product.AddProduct(new Product(id: 5, name: "acer", price: 1500, stock: 4));
            Product.Show();

            Client client=new Client("Seymur");
            client.start();
            Console.ReadKey();
        }
    }
}
