namespace cshar_programming
{
    internal class Resistor: IResister
    {
        private double ResistanceValue;

        public Resistor(int value)
        {
            ResistanceValue = value;
        }

        public double GetResistance()
        {
            return ResistanceValue;
        }
    }
}
