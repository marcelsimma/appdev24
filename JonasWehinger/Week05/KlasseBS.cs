using System;

namespace JonasWehinger.Week05
{
    public class Person
    {
        public string Name;
        public int Age;
        public string Address;

        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public string GName()
        {
            return Name;
        }
    }

    public class Car
    {
        public string Brand;
        public string Model;
        public int Year;

        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public string CarInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Year: {Year}";
        }
    }

    public class Bank
    {
        public string Name;
        public string Branch;
        public double Balance;

        public Bank(string name, string branch, double balance)
        {
            Name = name;
            Branch = branch;
            Balance = balance;
        }

        public double GBalance()
        {
            return Balance;
        }
    }
}
