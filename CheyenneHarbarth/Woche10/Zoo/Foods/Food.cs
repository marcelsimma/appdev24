using System;

namespace CheyenneHarbarth.Zoo.Zoostructure.Foods
{
    internal class Food
    {
        private string _foodName;
        internal string FoodName
        {
            get => _foodName;
            set => _foodName = value;
        }
        private string _measurement;
        internal string Measurement
        {
            get => _measurement;
            set => _measurement = value;
        }
        private double _pricePerMeasurement;
        internal double PricePerMeasurement
        {
            get => _pricePerMeasurement;
            set => _pricePerMeasurement = value;
        }
        private int _foodNr;
        internal int FoodNr
        {
            get => _foodNr;
            set => _foodNr = value;
        }
        internal Food(string foodname, double pricepermeas, string measurement, int foodnr)
        {
            _foodName = foodname;
            _measurement = measurement;
            _pricePerMeasurement = pricepermeas;
            _foodNr = foodnr;
        }
    }
}