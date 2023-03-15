namespace csharp_programming
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                StreamWriter sw = new StreamWriter("a.txt");
                sw.WriteLine("the quick brown fox jump over the lazy dog");
                sw.Close();
            }
            catch(IOException ex)
            {
                Console.WriteLine("an IO exception has been occured");
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
                return;
            }
        }
    }
}