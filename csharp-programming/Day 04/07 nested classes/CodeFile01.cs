namespace csharp_programming {
    public class ShoppingCart {
        private List<Item> items = new List<Item>();

        public void AddItem(string name, decimal price) {
            Item item = new Item(name, price);
            items.Add(item);
        }

        public decimal CalculateTotal() {
            decimal total = 0;
            foreach (Item item in items) {
                total += item.Price;
            }
            return total;
        }

        private class Item {
            public string Name { get; set; }
            public decimal Price { get; set; }

            public Item(string name, decimal price) {
                Name = name;
                Price = price;
            }
        }
    }

    class Program {
        static void Main(string[] args) {
            ShoppingCart cart = new ShoppingCart();
            cart.AddItem("Shirt", 20.99m);
            cart.AddItem("Pants", 35.50m);
            decimal total = cart.CalculateTotal();
            Console.WriteLine($"Total: {total}");
        }
    }
}
