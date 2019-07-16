using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    // This is the main Interface that User will see . User will press a button for a drink. 
    // The machine dispenses drink for certain time
    public class View
    {
        public static string Details;
        public static string Status;
        public States state; 
        private IBeverageState iBeverage; 
        public Beverage drinkType; //Drinks button available for selection

        public View() // By default the machine is in READY state
        {
            DisplayMessgae("Please Select a drink", "READY");
            state = States.READY;        
        }

        //This is a static method that display status and details message at every stage of the transaction
        public static void DisplayMessgae(String details, String status)
        {
            Details = details;
            Status = status;
            Console.WriteLine( Details +"\n" + "Status: " + Status + "\n");
        }

        //This event is called after user presses a beverage button.
        //This takes the selected beverage as input and initializes the transaction by calling ChangeMachineState method of InitializeBeverage class
        //After completing one transaction it calls another transaction state. The process continues untill request is Completed or Failed. 
       

        public void PressButton(Beverage beverage )
        {
            if(state == States.READY)
            { 
                iBeverage = new InitializeBeverage();
                iBeverage.ChangeMachineState(States.START, beverage);
            }
          
        }

    }
}
