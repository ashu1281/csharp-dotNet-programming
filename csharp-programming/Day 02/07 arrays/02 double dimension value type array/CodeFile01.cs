using System;

namespace csharp_programming {
    class Program {
        static void Main() {
            /* Get the Number of Rows and Cols from the User */
            string input;
            Console.Write("How many rows? ");
            input = Console.ReadLine();
            int rows = Convert.ToInt32(input);

            Console.Write("How many cols? ");
            input = Console.ReadLine();
            int cols = Convert.ToInt32(input);

            /* Create Array */
            int[,] data = new int[rows, cols];

            /* Initialize all Elements of an Array with -1 */
            for (int row = 0; row < rows; row++) {
                for (int col = 0; col < cols; col++) {
                    data[row, col] = -1;
                }
            }

            /* Fill Array with Random Values */
            Random random = new Random();
            for (int i = 0; i < rows * cols; i++) {
                int row = random.Next(0, rows);
                int col = random.Next(0, cols);
                while (data[row, col] != -1) {
                    row = random.Next(0, rows);
                    col = random.Next(0, cols);
                }
                data[row, col] = i;
            }

            /* Display Array */
            foreach (int item in data) {
                Console.Write(item);
                Console.Write(", ");
            }
            Console.WriteLine();

            /* Get Lookup Number from User */
            Console.Write("Which Number to Look for? ");
            input = Console.ReadLine();
            int lookupNumber = Convert.ToInt32(input);

            /* Do Probability Search */
            Tuple<bool, int, int> location = Search(data, lookupNumber);

            /* Display Report */
            if (location.Item1) {
                Console.WriteLine("Given number is found at row number {0} and column number {0} .", location.Item1, location.Item2);
            }
            else {
                Console.WriteLine("Given number is missing in the array.");
            }

        }

        static Tuple<bool, int, int> Search(int[,] data, int lookupNumber) {
            for (int row = 0; row <= data.GetUpperBound(0); row++) {
                for (int col = 0; col <= data.GetUpperBound(1); col++) {
                    if (data[row, col] == lookupNumber) {
                        return new Tuple<bool, int, int>(true, row, col);
                    }
                }
            }
            return new Tuple<bool, int, int>(false, 0, 0);
        }
    }
}
