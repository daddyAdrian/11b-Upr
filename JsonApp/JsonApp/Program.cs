using System;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace JsonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(1, "Test product", 100.01m, 100, new DateTime(2019, 06, 30));
            string json = JsonConvert.SerializeObject(product);
            Console.WriteLine("Single product object:");
            Console.WriteLine(json);
            Console.WriteLine(new string('-', 50));

            List<Product> products = new List<Product>();
            {
                new Product(1, "Milk", 2.59m, 100, new DateTime(2019, 06, 30));
                new Product(2, "Lyutenitsa", 2.39m, 100, new DateTime(2019, 08, 30));
                new Product(3, "Rice", 1.50m, 100, new DateTime(2019, 03, 30));
                new Product(4, "Salt", 100.01m, 100, new DateTime(2019, 10, 30));
            };
            string jsonList = JsonConvert.SerializeObject(products);
            Console.WriteLine("List of products:");
            Console.WriteLine(jsonList);
            Console.WriteLine(new string('-', 50));
            List<Product> list1 = new List<Product>();
            list1.Add(new Product()
            {
                Id = 1,
                Name = "Beer",
                Price = 1.2m,
                Stock = 5,
                Expiry = new DateTime(2020, 03, 31)
            });
            list1.Add(new Product()
            {
                Id = 2,
                Name = "Fries",
                Price = 2.4m,
                Stock = 10,
                Expiry = new DateTime(2020, 03, 31)
            });
            var json1 = JsonConvert.SerializeObject(list1);
            Console.WriteLine(json1);
            Console.WriteLine("---------------------------------");

            string jsonSizes = @"['Small','Medium','Large']";
            JArray a = JArray.Parse(jsonSizes);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            var json2 = @"[{'Id': 1, 'Name':'Beer', 'Price': 1.2,'Stock': 5,'Expiry':'2020-03-31T00:00:00'}, {'Id': 2, 'Name':'Fries', 'Price': 2.4,'Stock': 10,'Expiry':'2020-03-31T00:00:00'}]";
            var list2 = JsonConvert.DeserializeObject<List<Product>>(json2);
            foreach (var item in list2)
                Console.WriteLine(item.Name);
        }
    }
}
