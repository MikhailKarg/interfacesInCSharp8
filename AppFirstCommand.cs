using System;
using System.Collections.Generic;
using System.Text;

namespace interfacesInCSharp8
{
   public class AppFirstCommand : ICommand
    {
        public void exec()
        {
            // some action
            Console.WriteLine("Action complete!");
        }
    }
}
