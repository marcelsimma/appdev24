namespace BarbaraMarte.Zoo.Part4
{
    class Animal
    {
        public string _AnimalName { get; set; }
        public string _AnimalSpecies { get; set; }
        
        public Dictionary<AnimalFood, double> _AnimalFood { get; set; }

        public Animal(string animalSpecies, string animalName)
        {
            _AnimalName = animalName;
            _AnimalSpecies = animalSpecies;
            _AnimalFood = new Dictionary<AnimalFood, double>();
        }
        public void AddFood(AnimalFood nameOfFood, double foodQuantity)
        {
            _AnimalFood.Add(nameOfFood, foodQuantity);
        }
        public double CalculateFoodConsumption()
        {
            double totalCost = 0.0;
            foreach (var foodQuantity in _AnimalFood)
            {
                AnimalFood food = foodQuantity.Key;
                double quantity = foodQuantity.Value;
                totalCost += food.CalculateCost(quantity);
            }
            return totalCost;
        }
    }
}