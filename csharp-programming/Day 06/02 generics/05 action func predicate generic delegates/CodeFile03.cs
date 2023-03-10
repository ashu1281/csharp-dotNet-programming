using System;
using System.Threading;

namespace csharp_programming {
    class Server {
        public event Action<bool> ServiceComplete;

        public void DoService() {
            Thread.Sleep(2000);
            if (ServiceComplete != null)
                ServiceComplete(true);
        }
    }

    class Client {
        public void InvokeService(Server server) {
            server.DoService();
        }

        public void NotifyServiceComplete(bool success) {
            Console.WriteLine("Service Complete");
        }
    }

    class Program {
        static void Main() {
            Server server = new Server();
            Client client = new Client();

            server.ServiceComplete += client.NotifyServiceComplete;

            client.InvokeService(server);
        }
    }
}

/*
 * - Using 'Action' with parameter delegate.
 */