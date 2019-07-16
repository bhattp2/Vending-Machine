using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    //This checks if sufficient amount of the ingredients needed for the drink are available. 
    public class CheckSuppliesStocks : IBeverageState
    {
          SupplyStock supplyStock =  new SupplyStock() ;
        
        // If the machine has suffienct stock to make the drink
        // move to next stage
        // otherwise move to failure stage
        public void ChangeMachineState(States state, Beverage beverage)
        { 
            List<Supply>  supplies = new Supply().getSupplies(beverage.Name);//Keeps the ingredients with quantity required to supplies

            if (state == States.PROCESS && IsStockSufficient(supplies))
            {
                View.DisplayMessgae("Collecting Ingredients...", "PROCESSING");             
                new DispenseBeverage().ChangeMachineState(States.SUCCESS, beverage);
            }
            else
                new NotDispensing().ChangeMachineState(States.FAILURE, beverage);
            
        }

        //compare ingredients quantity required for the drink with the stock available
        //if Yes return true, else false
        public bool IsStockSufficient(List<Supply> supplies)
        {           
            foreach (var ingredient in supplies)
            {
                if (supplyStock.GetStock(ingredient.Name) < ingredient.Quantity)
                    return false;
            }
            return true;
        }

    }
}
