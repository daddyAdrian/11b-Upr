using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonApp
{
    class Product
    {
        private int id;
        private string name;
        private decimal price;
        private int stock;
        private DateTime expiry;
        
        public Product(int id, string name, decimal price, int stock, DateTime expiry)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
            this.Expiry = expiry;
        }
        public Product()
        { 
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime Expiry { get; set; }

    }
}
