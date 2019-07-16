using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Beverage
    {
        public string Name { get; set; }

        public Beverage(string name)
        {
            Name = name;
        }
    }
}
