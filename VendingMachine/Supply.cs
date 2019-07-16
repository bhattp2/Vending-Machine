using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    //Supply class represents the ingredients used for the drink. The constructor initializes the name
    public class Supply
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Supply()
        {

        }
        //sets name of the ingredients
        public Supply(string name)
        {
            Name = name;
        }

        //Initializes name and drink
        public Supply(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        //This method get the list of ingredients for the  given beverage. 
        //This shows returns list of ingredients from database based on beverageName  
        //I have sent some default values for testing.
        internal List<Supply> getSupplies(string beverageName)
        {            
           return new List<Supply>() { new Supply("Milk",4), new Supply("Sugar", 4), new Supply("Coffee", 5), new Supply("Water", 5) };
        }
    }
}
