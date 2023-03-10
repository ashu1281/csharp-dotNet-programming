namespace cshar_programming
{
    internal class Program
    {
      public static void Main()
        {
            Resistor r1 = new Resistor(2);
            Resistor r2 = new Resistor(2);
            Resistor r3 = new Resistor(2);
            Resistor r4 = new Resistor(2);
            Resistor r5 = new Resistor(2);
            Resistor r6 = new Resistor(2);
            Resistor r7 = new Resistor(2);

            ParallelResistor pr = new ParallelResistor();
            pr.Add(r1);
            pr.Add(r2);
            pr.Add(r3);
            Console.Write("Parallel Resistance is :");
            Console.WriteLine(pr.GetResistance());

            SeriesResistor sr = new SeriesResistor();
            sr.Add(r4);
            sr.Add(r5);
            sr.Add(r6);
            sr.Add(r7);
            sr.Add(pr);
            Console.Write("series Resistance is :");
            Console.WriteLine(sr.GetResistance());


        }
        
        
       

    }
}
