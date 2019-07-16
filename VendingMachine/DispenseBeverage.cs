using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VendingMachine
{
    //At this stage all the ingredients are added and drink is dispensed.
    //The drink is dispensed for 20sec and after that the state will be changed to Ready again
    //The amount dispensed is removed from the SupplyStock for each ingredients.
     //The request is completed at this stage
    public class DispenseBeverage : IBeverageState
    {
       SupplyStock supplyStock = new SupplyStock();
        public void ChangeMachineState(States state, Beverage beverage)
        {
          
            List<Supply> supplies = new Supply().getSupplies(beverage.Name);

            if (state == States.SUCCESS)
            {   
                MakeBeverage(supplies);
                View.DisplayMessgae("Dispensing " + beverage.Name + "...", "PROCESSING");
                Thread.Sleep(2000);
                View.DisplayMessgae("The drink has been dispensed ", "COMPLETED");
                new View();
            }
        }

        public void MakeBeverage(List<Supply>supplies)
        {            
            foreach (var supply in supplies)
            {
                supplyStock.DecrementAmount(supply.Name, supply.Quantity);
            }
            //add all ingredients and remove the amount from supplyStock
        }
    }
}
