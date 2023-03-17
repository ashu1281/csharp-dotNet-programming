using System.Diagnostics;

namespace csharp_programming
{
    enum TemperatureUnit
    {
        Celsius,
        Faherenheit
    }

    class Temperature
    {
        private double value;
        private TemperatureUnit unit;

        public double Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public TemperatureUnit Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public void ConvertTo(TemperatureUnit targetUnit)
        {
            if (unit == targetUnit)
                return;

            if (unit == TemperatureUnit.Celsius && targetUnit == TemperatureUnit.Faherenheit)
                value = (value * 9 / 5) + 32;
            else if (unit == TemperatureUnit.Faherenheit && targetUnit == TemperatureUnit.Celsius)
                value = (value - 32) * 5 / 9;

            unit = targetUnit;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Temperature t = new Temperature() { Value = 37.5, Unit = TemperatureUnit.Celsius };
            t.ConvertTo(TemperatureUnit.Faherenheit);
            Debug.Assert(t.Value == 99.5 && t.Unit == TemperatureUnit.Faherenheit);
        }
    }
}

