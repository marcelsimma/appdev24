using System;

namespace SimonJochum.Week05
{
    public class Person
    {
        string _Name;
        int _Age;
        int _Height;
        int _Weight;
        double _AccountBalance;

        public Person(string name, int age, int height, int weight, double accountBalance)
        {
            _Name = name;
            _Age = age;
            _Height = height;
            _Weight = weight;
            _AccountBalance = accountBalance;
        }

        public string HasABirthday(int age)
        {
            _Age = age;
            _Age++;
            return _Name + " ist nach ihrem Geburtstag " +_Age + " alt.";
        }

        public override string ToString()
        {
            return string.Format("Person: {0}, Alter: {1}", _Name, _Age);
        }
    }
}