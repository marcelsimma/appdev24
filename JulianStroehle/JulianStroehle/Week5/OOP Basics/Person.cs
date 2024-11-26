using System;
namespace JulianStroehle.Week5.models
{
    public class Person
    {
        string name;
        int age;
        double height;
        int weight;
        int distanceToWork;
        public int DistanceToWork
        {
            get => distanceToWork;
        }
        public Person(string name, int age, double height, int weight, int distanceToWork = 0)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.distanceToWork = distanceToWork;
        }
        public void HasBirthday()
        {
            age++;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}, Alter: {1}", name, age);
        }
    }
}