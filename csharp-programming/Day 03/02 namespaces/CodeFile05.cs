using System;
using LandLineConnection = csharp_programming.Phone.LandLine.Connection;
using MobileConnection = csharp_programming.Phone.Mobile.Connection;

namespace csharp_programming {
    namespace Phone.LandLine {//instead of writing two namespace we can write in this way also.
        class Connection {
            public void Connect() { }
        }
    }

    namespace Phone.Mobile {
        class Connection {
            public void Connect() { }
        }
    }

    class Program {
        static void Main() {
            LandLineConnection landLineconnection = new LandLineConnection();
            landLineconnection.Connect();

            MobileConnection mobileConnection = new MobileConnection();
            mobileConnection.Connect();
        }
    }
}

/*
 * namespace alias
 */