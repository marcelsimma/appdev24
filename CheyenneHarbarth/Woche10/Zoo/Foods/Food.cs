using System;

namespace CheyenneHarbarth.Zoo.Zoostructure.Foods
{
    internal class Food
    {
        private string Foodname;
        internal string _Foodname
        {
            get => Foodname;
            set => Foodname = value;
        }
        private string Measurement;
        internal string _Measurement
        {
            get => Measurement;
            set => Measurement = value;
        }
        private double PricePerMeasurement;
        internal double _PricePerMeasurement
        {
            get => PricePerMeasurement;
            set => PricePerMeasurement = value;
        }
        internal Food(string foodname, string measurement, double pricepermeas)
        {
            Foodname = foodname;
            Measurement = measurement;
            PricePerMeasurement = pricepermeas;
        }
    }
}