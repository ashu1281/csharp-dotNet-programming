namespace csharp_programming {
    class Program {
        static bool Search(int[,] arr, int value) {
            bool found = false;
            int rows = arr.GetLength(0), cols = arr.GetLength(1);
            for (int row = 0; row < rows; row++) {
                for (int col = 0; col < cols; col++) {
                    if (arr[row, col] == value) {
                        found = true;
                        goto END;
                    }
                }
            }
            END:
            return found;
        }

        static void Main() {
            int[,] a = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 0, 0 } };
            bool found = Search(a, 4);
            found = Search(a, 5);
        }
    }
}