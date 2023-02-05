using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Currency
    {

        public string Name { get; set; }
        public double ExRate { get; set; }

        public Currency()
        {
            Name = "Dollar";
            ExRate = 28.28;
        }

        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(string name)
        {
            Name = name;
        }

        public Currency(Currency c) : this(c.Name, c.ExRate) { }

    }
}
