namespace csharp_programming {
    class Auction {
        private double price;

        public delegate void NotifyDelegate(double price);

        private NotifyDelegate notify;

        public event NotifyDelegate Notify {//it is same as making private
            add { notify += value; }
            remove { notify -= value; }
        }

        public Auction(double initialprice) {
            price = initialprice;
        }

        public void Bid(double price) {
            if (price > this.price) {
                this.price = price;
                notify(price);
            }
        }
    }

    class Participant {
        public void Update(double price) {

        }
    }

    class Program {
        static void Main() {
            Auction auction = new Auction(1000);
            Participant a = new Participant();
            Participant b = new Participant();
            auction.Notify += a.Update;
            auction.Notify += b.Update;
            auction.Bid(1500);
            auction.Notify -= a.Update;
            auction.Bid(1700);
        }
    }
}
