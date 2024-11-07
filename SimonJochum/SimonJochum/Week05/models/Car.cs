using System;

namespace SimonJochum.Week05
{
    public class Car
    {
        string _Brand;
        string _Model;
        int _Horsepower;
        double _Price;
        int _DistanceToWork;
        int _Kilometerstand;

        public Car(string brand, string model, int horsepower, double price, int kilometerstand)
        {
            _Brand = brand;
            _Model = model;
            _Horsepower = horsepower;
            _Price = price;
            _Kilometerstand = kilometerstand;
        }
        public Car (int distanceToWork, int kilometerstand)
        {
            _Kilometerstand = kilometerstand;
            _DistanceToWork = distanceToWork;
        }

        public string Kilometerstand(int distanceToWork)
        {
            _DistanceToWork = distanceToWork;
            _Kilometerstand += distanceToWork;
            return string.Format("Marke: {0}, Modell: {1}, Fahrdistanz: {2}, Kilometerstand: {3}", _Brand, _Model, _DistanceToWork, _Kilometerstand);
        }

        public override string ToString()
        {
            return string.Format("Marke: {0}, Modell: {1}, PS: {2}, Preis: {3}, Kilometerstand: {4}", _Brand, _Model, _Horsepower, _Price, _Kilometerstand);
        }
    }
}