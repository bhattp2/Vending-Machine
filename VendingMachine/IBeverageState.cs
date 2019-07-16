using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public interface IBeverageState
    {
        //void GetState(States state);
        void ChangeMachineState(States state, Beverage beverage);
    }
}
