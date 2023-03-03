using System;
using csharp_programming.Phone.LandLine;

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
            Connection landLineconnection = new Connection();
            landLineconnection.Connect();

            Phone.Mobile.Connection mobileConnection = new Phone.Mobile.Connection();
            mobileConnection.Connect();
        }
    }
}