using System;
using LandLineConnection = csharp_programming.Phone.LandLine.Connection;
using MobileConnection = csharp_programming.Phone.Mobile.Connection;

namespace csharp_programming {
    namespace Phone {
        namespace LandLine {
            class Connection {
                public void Connect() { }
            }
        }

        namespace Mobile {
            class Connection {
                public void Connect() { }
            }
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
 * namespace alias.
 */