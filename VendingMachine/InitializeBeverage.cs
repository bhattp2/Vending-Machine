using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
   //This is the first transaction state. This implements IBeverageState interface.
   //This class checks if a drink is selected and state is READY. 
   //The state is set to Process and request is then moved to another transaction class.
   //If any problem occured then the request goes to Failure stage
    public class InitializeBeverage : IBeverageState
    {         
        public void ChangeMachineState(States state, Beverage beverage)
        {
         
            if (state == States.START && (IsBeverageSelected(state)))
            {
                View.DisplayMessgae(beverage.Name + " is Selected", "STARTED");
                 new CheckSuppliesStocks().ChangeMachineState(States.PROCESS,  beverage); // The state changed to Process and next transaction class is called
            }
            else
                new NotDispensing().ChangeMachineState(States.FAILURE, beverage);// If any error occurs during process. If drink is already processing and user clicks again
        }

        //When button is pressed, State is changed to START and this returns true;
        public bool IsBeverageSelected(States state)
        {
            return (state == States.START) ? true : false;
        }
     

    }

}
