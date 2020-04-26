using System;
using System.Collections.Generic;
using System.Text;

namespace interfacesInCSharp8
{
    interface ICommand
    {
        void exec();

       void sendNotification(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
