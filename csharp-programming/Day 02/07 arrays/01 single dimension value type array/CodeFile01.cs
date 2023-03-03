using System;

namespace csharp_programming {
    class Program {
        static void Main() {
            /* Get Rank of the Array from the User */
            string input;
            Console.Write("How many items? ");
            input = Console.ReadLine();
            int items = Convert.ToInt32(input);

            /* Create Array */
            int[] data = new int[items]; // it must step in c#

            /* Initialize all Elements of an Array with -1 */
            for (int i = 0; i < data.Length; i++) {
                data[i] = -1;
            }
            
            /* Fill Array with Values */
            Random random = new Random();
            for (int i = 0; i < items; i++) {
                int index = random.Next(0, items);
                while(data[index] != -1) {
                    index = random.Next(0, items);
                }
                data[index] = i;
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
            int location = DoPrbabilitySearch(data, lookupNumber);

            /* Display Report */
            if (location >= 0) {
                Console.WriteLine("Given number is found at the {0} position.", location);
            }
            else {
                Console.WriteLine("Given number is missing in the array.");
            }
        }

        static int DoPrbabilitySearch(int[] data, int lookupNumber) {
            for (int i = 0; i < data.Length; i++) {
                if (data[i] == lookupNumber) {
                    if (i > 0) {
                        int temp = data[i - 1];
                        data[i - 1] = data[i];
                        data[i] = temp;
                        i--;
                    }
                    return i;
                }
            }
            return -1;
        }
    }
}
