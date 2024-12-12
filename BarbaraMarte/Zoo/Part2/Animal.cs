namespace BarbaraMarte.Zoo.Part2
{
    class Animal
    {
        public string _AnimalName { get; set; }
        public string _AnimalSpecies { get; set; }

        public Animal(string animalSpecies, string animalName)
        {
            _AnimalName = animalName;
            _AnimalSpecies = animalSpecies;
        }

    }
}