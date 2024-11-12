using System;

namespace BarbaraMarte.Week05
{
    class Person
    {
        string _Name;
        int _Age;
        int _Height;

        public string Name
        {
            get => "\"" + _Name + "\"";
        }
        public int Height
        {
            get => _Height;
        }
        public int Age 
        {
            get => _Age;
        }
        public Person(string name, int height, int age)
        {
            _Name = name;
            _Height = height;
            _Age = age;
        }
        public override string ToString()
        {
            return string.Format("Person: {0}, age: {1}, height: {2}", _Name, _Age, _Height);
        }
    }

    class Car
    {
        string _ModelName;
        int _Size;
        int _Price;

        public string ModelName
        {
            get => "\"" + _ModelName + "\"";
        }
        public int Size
        {
            get => _Size;
        }
        public int Price
        {
            get => _Price;
        }
        public Car(string modelName, int size, int price)
        {
            _ModelName = modelName;
            _Size = size;
            _Price = price;
        }
        public override string ToString()
        {
            return string.Format("Car name: {0}, Price: {1} Euro, Sitting spaces: {2} ", _ModelName, _Price, _Size);
        }
    }
    class Bank
    {
        string _Material;
        string _Color;
        string _Location;
        int _Price;

        public string Material
        {
            get => "\"" + _Material + "\"";
        }
        public string Colour
        {
            get => "\"" + _Color + "\"";
        }
        public string Location
        {
            get => "\"" + _Location + "\"";
        }
        public int Price
        {
            get => _Price;
        }
        public Bank(string material, string color, string location, int price)
        {
            _Material = material;
            _Color = color;
            _Location = location;
            _Price = price;
        }
        public override string ToString()
        {
            return string.Format("Material: {0}, Color: {1}, Inside or outside: {2}, Price: {3} Euro", _Material, _Color, _Location, _Price);
        }
    }
}