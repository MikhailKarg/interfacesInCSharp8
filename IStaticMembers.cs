using System;
using System.Collections.Generic;
using System.Text;

namespace interfacesInCSharp8
{
    interface IStaticMembers
    {
        private static string commandName = "Default command name";

        private void build(string name)
        {
            commandName = name;
        }

        public void setCommandName(string name)
        {
            build(name);
        }
    }
}
