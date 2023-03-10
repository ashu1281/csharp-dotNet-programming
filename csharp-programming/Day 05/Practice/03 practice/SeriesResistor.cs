namespace cshar_programming
{
    internal class SeriesResistor : ResistorCollection
    {

        private double CalculateSeriesResitor()
        {
            //return the Series resistance addition return
            double result = 0;

            foreach(var i in list)
            {
                result += i.GetResistance();
            }
            return result;
        }

        public override double GetResistance()
        {
            return CalculateSeriesResitor();
        }

       
    }
}
