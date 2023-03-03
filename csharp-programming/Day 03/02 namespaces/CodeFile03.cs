using System;
using csharp_programming.Phone.LandLine;
using csharp_programming.Phone.Mobile;

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
            // Ambiguity Error
            Connection landLineconnection = new Connection();
            landLineconnection.Connect();

            Phone.Mobile.Connection mobileConnection = new Phone.Mobile.Connection();
            mobileConnection.Connect();
        }
    }
}