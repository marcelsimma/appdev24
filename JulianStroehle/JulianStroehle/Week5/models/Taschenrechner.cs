using System;
namespace JulianStroehle.Week5.models
{
    public class Taschenrechner
    {
        int[] numbers;
        public int hightestValue;
        int lowestValue;
        double averageValue;
        public Taschenrechner(int[] numbers)
        {
            this.numbers = numbers;
        }
        public void Highest()
        {
            hightestValue = numbers.Max();
        }
        public void Lowest()
        {
            lowestValue = numbers.Min();
        }
        public void Average()
        {
            averageValue = numbers.Average();
        }
        public override string ToString()
        {
            return string.Format("Größte Zahl: {0}\nKleinste Zahl: {1}\nDurchschnitt: {2}", hightestValue, lowestValue, averageValue);
        }
    }
}