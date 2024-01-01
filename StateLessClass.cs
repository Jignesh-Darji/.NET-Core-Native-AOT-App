using Stateless;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Core_Console_App
{
    internal class StateLessClass
    {
        // Define your state and trigger enums
        enum DoorState { Closed, Open }
        enum DoorTrigger { ButtonPressed, MotionDetected }

        internal void DoWorkExample()
        {
            // Instantiate the state machine with the specific types
            StateMachine<DoorState, DoorTrigger> doorMachine = new StateMachine<DoorState, DoorTrigger>(DoorState.Closed);

            // Configure the state machine 
            doorMachine.Configure(DoorState.Closed)
        .OnEntry(() => Console.WriteLine("Door is closed"))
        .Permit(DoorTrigger.ButtonPressed, DoorState.Open)
        .OnEntry(() => Console.WriteLine("Door is open"))
        .Permit(DoorTrigger.ButtonPressed, DoorState.Closed);

            // ...rest of your code...

            //doorMachine.Fire(DoorTrigger.MotionDetected);
            
        }

    }
}
