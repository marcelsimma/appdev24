using System;
using System.Runtime.CompilerServices;
using CheyenneHarbarth.Zoo.Zoostructure.Foods;


namespace CheyenneHarbarth.Zoo.Zoostructure.Animals
{
    internal class Animal
    {
        private string Animalname;
        internal string _Animalname
        {
            get => Animalname;
            set => Animalname = value;
        }

        private string Animalrace;
        internal string _Animalrace
        {
            get => Animalrace;
            set => Animalrace = value;
        }

        internal Dictionary<Food, int> Requirement = new Dictionary<Food, int>();

        internal Animal(string animalname, string animalrace, Food food, int foodamount)
        {
            Animalname = animalname;
            Animalrace = animalrace;
            Requirement.Add(food, foodamount);
        }

        internal void AddFood(Food food, int foodamount)
        {
            Requirement.Add(food, foodamount);
        }

        public override string ToString()
        {
            return String.Format(Animalrace + ", " + Animalname);
        }
    }
}