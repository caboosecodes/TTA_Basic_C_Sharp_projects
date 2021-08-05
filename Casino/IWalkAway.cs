using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Interfaces
{
    // Naming convention for interface is to start with a capital I

    // the .NET framework supports multiple inheritance of interfaces
    // in addition to inheriting from ONE base class you can then inherit from multiple interaces
    // everything is public in an interface
    interface IWalkAway
    {
        // any class inheritting this interface has to implement this method and it has to return void and has to take in these parameters
        void WalkAway(Player player);
    }
}
