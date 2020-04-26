using System;
using System.Collections.Generic;
using System.Text;

namespace interfacesInCSharp8
{
    public class AppSecondCommand : ICommand
    {
        public void exec()
        {
            // some action
            Console.WriteLine("Action complete!");
        }

        // ovveride sendNotification
        public void sendNotification()
        {
            Console.WriteLine("New implementation");
        }
    }
}
