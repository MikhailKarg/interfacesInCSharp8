using System;
using System.Collections.Generic;
using System.Text;

namespace interfacesInCSharp8
{
    interface IVirtualMembers
    {
        public virtual void sendNotification()
        {
            Console.WriteLine("IVirtualMembers's  sendNotification");
        }
    }

    interface IOverrideVirtualMembers : IVirtualMembers
    {
        void IVirtualMembers.sendNotification()
        {
            Console.WriteLine("IOverrideVirtualMembers's  sendNotification");
        }
    }
}
