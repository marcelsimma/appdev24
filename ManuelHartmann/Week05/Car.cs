using System;

namespace ManuelHartmann.Week05
{
    // Klasse
    public class Car
    {
        // Attribute
        string _Brand;
        string _Model;
        int _YearOfConstruction;
        string _Color;
        int _Mileage;

        public string Name
        {
            get => "\"" + _Brand + "\"";
        }

        public string Height
        {
            get => _Model;
        }

        // Konstruktor
        public Car(string brand, string model, int yearOfConstruction, string color, int mileage)
        {
            _Brand = brand;
            _Model = model;
            _YearOfConstruction = yearOfConstruction;
            _Color = color;
            _Mileage = mileage;
        }

        // Methode

        // Besprochene Beispiel-Methoden für ein Auto:
        public void drive()
        {
            _Mileage++;
        }

        public void drivenDistance(int mileage)
        {
            _Mileage += mileage;
        }

        public void driveDistanceWorkplace()
        {
            _Mileage += 40;
        }

        public override string ToString()
        {
            return string.Format("Brand: {0}, Model: {1}, YearOfConstruction: {2}", _Brand, _Model, _YearOfConstruction);
        }
    }
}