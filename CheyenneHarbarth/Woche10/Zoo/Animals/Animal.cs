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

        internal Dictionary<Food, double> Requirement = new Dictionary<Food, double>();

        internal Animal(string animalname, string animalrace)
        {
            Animalname = animalname;
            Animalrace = animalrace;
        }

        internal void AddFood(Food food, double foodamount)
        {
            Requirement.Add(food, foodamount);
        }

        public override string ToString()
        {
            return $"{Animalname}, {Animalrace}";
        }

        public void PrintAnimalAndFood()
        {
            Console.WriteLine($"{Animalname}, {Animalrace}\nFutter: ");
            foreach (KeyValuePair<Food, double> food in Requirement)
            {
                Console.WriteLine($"   {food.Key._Foodname,-18}{food.Value,6:F1} {food.Key._Measurement,-3}");
            }
        }
    }
}