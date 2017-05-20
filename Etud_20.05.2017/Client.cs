using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etud_20._05._2017
{
    class Client
    {
       public Dictionary<Product, int> basketList = new Dictionary<Product, int>();
        public string name { get; set; }

        public Client(string name)
        {
            this.name = name;
        }

        public void AddBasket(Product pro,int count)
        {
            if (basketList.ContainsKey(pro))
            {
                basketList[pro] += count;
            }
            else
            {
                basketList.Add(pro, count);

            }
            pro.stock -= count;
        }

        public void ShowBasket()
        {
            Console.WriteLine("Sizin mehsullariniz:");
            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}", "id", "name", "price", "stock");

            foreach (KeyValuePair<Product,int> basket_item in basketList)
            {
                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}", basket_item.Key.id, basket_item.Key.name, basket_item.Key.price, basket_item.Value.ToString());

            }
        }
        public void start()
        {
            do
            {
                Console.WriteLine("Istediyiniz mehsulun id-sini secin");
                int id = Convert.ToUInt16(Console.ReadLine());
                bool result = Product.productList.Exists(x => x.id == id);
                if (result)
                {
                    Console.WriteLine("Istediyiniz mehsulun sayini daxil edin");
                    int count = Convert.ToUInt16(Console.ReadLine());

                    Product mehsul = Product.productList.Find(productList => productList.id == id);// yene adel dedi mehsul yazaq
                    if (count<mehsul.stock)
                    {
                        AddBasket(mehsul, count);
                        Console.WriteLine("Mehsullar gosterilsn:");
                        ShowBasket();
                        Console.WriteLine("\n");
                        Product.Show();
                    
                    }
                    else
                    {
                        Console.WriteLine("Istedyiz sayda mehsul yoxdur");
                    }
                }
                else
                {
                    Console.WriteLine("yox");

                }
            } while (true);
        }
    }
}
