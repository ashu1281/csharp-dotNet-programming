namespace csharp_programming {
    class Point {
        public int X { get; set; }

        public int Y { get; set; }

        public double DistanceFrom(Point other) => Math.Sqrt((other.X - X) * (other.X - X) + (other.Y - Y) * (other.Y - Y)); //we can write one line code in that manner. 
    }
    internal class Program {
        public static void Main(string[] args) {
            Point point = new Point() { X = 3, Y = 2 };
            Point other = new Point() { X = 9, Y = 7 };
            double dist = point.DistanceFrom(other);
        }
    }
}

/*
 * Expression bodied member feature was introduced in C# 6.0.
 * It's a shorthand syntax for writing methods, properties, and indexers in C# that only contain a single expression.
 * The => symbol separates the input parameters (if any) from the expression that is being returned.
 * Expression-bodied members can also include conditional expressions (for ex Max, Min etc), null checks,
 * and other operations that can be used within a single expression.
 */