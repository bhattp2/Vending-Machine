using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VendingMachine
{ 
    // If any problems occurs during processing, then process would be directed to this class.
    //Function ChangeMachineState displays FAILURE message and then wait for 20sec before calling the new instance of machine.
    public class NotDispensing : IBeverageState
    {
        //If any error occured during any stage of processing, this class will be called. 
        //The machine stops for some time and again set the state to Ready.
        public void ChangeMachineState(States state, Beverage beverage)
        {
            if (state == States.FAILURE) { 
                View.DisplayMessgae("Some problems during processing: The request cannot be completed","FAILED");
                Thread.Sleep(2000);
            }

            new View();
        }

        
    }
}
