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
        private int FoodNr;
        internal int _FoodNr
        {
            get => FoodNr;
            set => FoodNr = value;
        }
        internal Food(string foodname, double pricepermeas, string measurement, int foodnr)
        {
            Foodname = foodname;
            Measurement = measurement;
            PricePerMeasurement = pricepermeas;
            FoodNr = foodnr;
        }
    }
}