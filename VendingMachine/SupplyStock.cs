using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class SupplyStock
    {
        //This is the stock available in the machine for each ingredients. 
        //This will map the name of the ingredients with the stock Available
        public Dictionary<string, int> supplyStock;
        //I have defaulted the stock vallue for some of the ingredients
        //In real scenario this will come from database
        public SupplyStock()
        {
            supplyStock = new Dictionary<string, int>();
            supplyStock.Add("Milk", 20);
            supplyStock.Add("Water", 25);
            supplyStock.Add("Coffee", 30);
            supplyStock.Add("Cream", 40);
            supplyStock.Add("Chocolate", 45);
            supplyStock.Add("Sugar", 45);
        }

        //This will return the amount available for the given ingredients
        public int GetStock(String name)
        {
            return supplyStock[name];
        }

        //This will add the specified quantity for given name 
        public void AddStock(String name, int amount)
        {
            supplyStock[name] += amount;
        }

        //This will decrease the specified stock amount for the ingredients
        public void DecrementAmount(String name, int amount)
        {
            supplyStock[name] -= amount;
        }
    }
}
