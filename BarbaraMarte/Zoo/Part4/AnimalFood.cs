namespace BarbaraMarte.Zoo.Part4
{
    class AnimalFood
    {
        public string _FoodUnit { get; set; }
        public string _NameOfFood { get; set; }
        public double _FoodPrice { get; set; }
        public double _AmountOfFood { get; set; }

        public AnimalFood(string nameOfFood, string foodUnit, double foodPrice, double amountOfFood)
        {
            _FoodUnit = foodUnit;
            _NameOfFood = nameOfFood;
            _FoodPrice = foodPrice;
            _AmountOfFood = amountOfFood;
        }
        public double CalculateCost(double quantity)
        {
            return _FoodPrice * quantity;
        }
    }
}