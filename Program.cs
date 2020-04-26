using System;

namespace interfacesInCSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICommand appFirstCommand = new AppFirstCommand();

            //appFirstCommand.exec();
            //appFirstCommand.sendNotification("Default implementations");

            ICommand appSecondCommand = new AppSecondCommand();
            appSecondCommand.exec();
            appSecondCommand.sendNotification("Ovveride mrthod from AppSecondCommand");

            //IVirtualMembers virtualMembers = new AppThirdCommand();
            //virtualMembers.sendNotification();

            //IOverrideVirtualMembers overrideVirtualMembers = new AppFourthCommand();
            //overrideVirtualMembers.sendNotification();
        }
    }
}
