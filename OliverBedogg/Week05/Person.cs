using System;

namespace OliverBedogg.Week05
{
    // Klasse
    public class Person
	{
        // Attribute
        string _Name;
        int _Age;
		int _Height;
		int _Weight;

		public string Name
		{
			get => "\"" + _Name + "\"";
		}

		public int Height
		{
			get => _Height;
		}

        // Konstruktor
		public Person(string name, int age, int height, int weigth)
		{
			_Name = name;
			_Age = age;
			_Height = height;
			_Weight = weigth;
		}

        public override string ToString()
        {
            return string.Format("Person: {0}, age: {1}", _Name, _Age);
        }
    }
}