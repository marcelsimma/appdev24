using System;
using System.Runtime.CompilerServices;
using CheyenneHarbarth.Zoo.Zoostructure.Foods;


namespace CheyenneHarbarth.Zoo.Zoostructure.Animals
{
    internal class Animal
    {
        private string _animalName;             //namenskonvention für private Instanzfelder mit _ und camelCase
        internal string AnimalName              //namenskonvention für öffentliche oder interne Attribute mit PascalCase
        {
            get => _animalName;
            set => _animalName = value;
        }

        private string _animalRace;
        internal string AnimalRace
        {
            get => _animalRace;
            set => _animalRace = value;
        }

        internal Dictionary<Food, double> requirement = new Dictionary<Food, double>();

        internal Animal(string animalName, string animalRace)
        {
            _animalName = animalName;
            _animalRace = animalRace;
        }

        internal void AddFood(Food food, double foodAmount)
        {
            requirement.Add(food, foodAmount);

            //Futter zur Liste und zur DB hinzufügen
            /* Console.WriteLine("Wie heißt der neue Zoowärter? Vorname eingeben, Enter, Nachname eingeben");
            zooKeepers.Add(new Zookeeper());

            int index = zooKeepers.Count();

            string addZookeeperQuery = @"INSERT INTO zookeeper (Firstname, Lastname, Workplace)
                VALUES (@Firstname, @Lastname, @Workplace);";

            MySqlCommand addZookeeperCommand = new MySqlCommand(addZookeeperQuery, connection);
            addZookeeperCommand.Parameters.AddWithValue("Firstname", zooKeepers.ElementAt(index - 1).KeeperFirstname);
            addZookeeperCommand.Parameters.AddWithValue("Lastname", zooKeepers.ElementAt(index - 1).KeeperLastname);
            addZookeeperCommand.Parameters.AddWithValue("Workplace", ZooName);

            int newRows = addZookeeperCommand.ExecuteNonQuery();

            if (newRows > 0)
            {
                Console.WriteLine("\nEin neuer Zoowärter wurde eingestellt und in der DB erstellt!");
            } */
        }

        public override string ToString()
        {
            return $"{AnimalName}, {AnimalRace}";
        }

        public void PrintAnimalAndFood()
        {
            Console.WriteLine($"{AnimalName}, {AnimalRace}\nFutter: ");
            foreach (KeyValuePair<Food, double> food in requirement)
            {
                Console.WriteLine($"   {food.Key.FoodName,-18}{food.Value,6:F1} {food.Key.Measurement,-3}");
            }
        }
    }
}