using System;

namespace FlorianBaier.Week05
{
    // Klasse
    public class Person
    {
        // Attribute
        string _Name;
        int _Age;
        int _Height;
        int _Weight;

        // Konstruktor
        public Person(string name, int age, int height, int weigth)
        {
            _Name = name;
            _Age = age;
            _Height = height;
            _Weight = weigth;
        }

        public void hasABirthDay()
        {
            _Age++;
        }
        public override string ToString()
        {
            return string.Format("Person: {0}, age: {1}, height: {2}cm, weight: {3}kg", _Name, _Age, _Height, _Weight);
        }
    }
    public class Car
    {
        //Attribute
        string _Name;
        string _Model;
        int _HorsePower;
        double _Price;
        double _Mileage;

        public Car(string name, string model, int horsePower, double price, double mileage)
        {
            _Name = name;
            _Model = model;
            _HorsePower = horsePower;
            _Price = price;
            _Mileage = mileage;
        }

        public void DriveDistance(){
            _Mileage += 15;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Model: {1}, Horsepower: {2}PS, Price: {3}$, Mileage: {4}km", _Name, _Model, _HorsePower, _Price, _Mileage);
        }
    }
    public class Bank
    {
        // Attribute
        string _Name;
        int _BankCode;
        int _Employees;

        // Konstruktor
        public Bank(string name, int bankCode, int employees)
        {
            _Name = name;
            _BankCode=bankCode;
            _Employees=employees;
        }

        public override string ToString()
        {
            return string.Format("Person: {0}, age: {1}, height: {2}cm, weight: {3}kg", _Name, _BankCode, _Employees);
        }
    }
}