namespace cshar_programming
{
    class program
    {
        public static void Main()
        {
            try
            {
                StreamReader sr = new StreamReader("a.txt");

                string line;
                line = sr.ReadLine();
                while(line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("An IO exception has been occured");
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
                return;

            }
        }
    }
}