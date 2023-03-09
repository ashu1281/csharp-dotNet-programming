namespace csharp_programming {
    class Point {
        public int X { get; set; }//property

        public int Y { get; set; }

        public double DistanceFrom(Point other) {
            return Math.Sqrt((other.X - X) * (other.X - X) + (other.Y - Y) * (other.Y - Y));
        }
    }

    internal class Program {
        public static void Main(string[] args) {
            Point point = new Point() { X = 3, Y = 2 };
            Point other = new Point() { X = 9, Y = 7 };
            double dist = point.DistanceFrom(other);
        }
    }
}
