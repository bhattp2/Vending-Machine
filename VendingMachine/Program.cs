using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mocha";
            Beverage beverage = new Beverage(name);// Selecting drink
            View view = new View();//Initializing state to ready
            view.PressButton(beverage);// User is ready to process drink
            Console.ReadLine();

        }
    }
}
