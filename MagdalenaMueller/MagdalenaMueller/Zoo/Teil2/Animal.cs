using System;

namespace MagdalenaMueller.Zoo
{
    public class Animal
    {
        internal string AnimalName;
        internal string Genus;
        internal Food Food;
        internal double ValueFood;
        internal static Dictionary<Animal,double> animalFood;
        public static Dictionary<Food, double> foodZoo = new Dictionary<Food, double>(); 
        

        public Animal(string animalName, string genus, Food food, double valueFood)
        {
            AnimalName = animalName;
            Genus = genus;
            Food = food;
            ValueFood = valueFood;
            animalFood = new Dictionary<Animal, double>();
        }

        public static Animal CreateAnimal(string animalName, string genus, Food food, double valueFood)
        {
            Animal animal = new Animal(animalName, genus, food, valueFood);

            animalFood.Add(animal,valueFood);

            if (foodZoo.ContainsKey(food))
                {
                    foodZoo[food] += valueFood;
                }
                else
                {
                    foodZoo.Add(food, valueFood);
                }

            return animal;
        }
    }
}