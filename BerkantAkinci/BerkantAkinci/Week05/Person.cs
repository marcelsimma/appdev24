using System;

namespace BerkantAkinci.Week05
{

    public class Person
    {
        //Attribute
        string _Name;
        int _Age;
        int _Height;
        int _Weight;

        //Konstruktor
        public Person(string name, int age, int height, int weight)
        {
            _Name = name;
            _Age = age;
            _Height = height;
            _Weight = weight;
        }

        public override string ToString()
        {
            return string.Format($"Person: {_Name,-6}, age: {_Age,-2}, height: {_Height,-3}cm, weight: {_Weight,-3}kg");
        }
    }
}