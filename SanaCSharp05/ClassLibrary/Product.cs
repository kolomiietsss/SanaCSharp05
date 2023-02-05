using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Currency Cost { get; set; }
        public int Quantity { get; set; }
        public string Producer { get; set; }
        public double Weight { get; set; }
        public Product()
        {
        }

        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product(Product p) : this(p.Name, p.Price, p.Cost, p.Quantity, p.Producer, p.Weight)
        {
        }

        public double GetPriceInUAH()
        {
            return Price * Cost.ExRate;
        }

        public double GetTotalPriceInUAH()
        {
            return GetPriceInUAH() * Quantity;
        }

        public double GetTotalWeight()
        {
            return Weight * Quantity;
        }
    }
}
