namespace cshar_programming
{
    internal class ParallelResistor:ResistorCollection
    {
        private double CalculateResistance()
        {
            double totalResistance = 0;

            foreach(var i in list)
            {
                double resistance = i.GetResistance();
                totalResistance += 1 / resistance ;
            }

            double parallelResistance = 1 / totalResistance;

            return parallelResistance;
        }
        public override double GetResistance()
        {
            return CalculateResistance();
        }

        
    }
}
