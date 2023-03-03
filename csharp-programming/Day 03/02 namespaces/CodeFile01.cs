using System;

namespace csharp_programming {//this represents our project name.
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
            Phone.LandLine.Connection landLineconnection = new Phone.LandLine.Connection();
            landLineconnection.Connect();

            Phone.Mobile.Connection mobileConnection = new Phone.Mobile.Connection();
            mobileConnection.Connect();
        }
    }
}