namespace BarbaraMarte.Zoo.Part4
{
    class AnimalFood
    {
        public string _FoodUnit { get; set; }
        public string _NameOfFood { get; set; }
        public double _FoodPrice { get; set; }

        public AnimalFood(string foodUnit, string nameOfFood, double foodPrice)
        {
            _FoodUnit = foodUnit;
            _NameOfFood = nameOfFood;
            _FoodPrice = foodPrice;
        }
        public double CalculateCost(double quantity)
        {
            return _FoodPrice * quantity;
        }
    }
}