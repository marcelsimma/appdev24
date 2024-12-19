using System;

namespace SimonJochum.Week10.Zoo.Zoo_Part1
{
    public class Food
    {
        private string _name;
        private string _unit;
        private double _unitPrice;
        private int _ean;

        public Food(string name, string unit, double unitPrice)
        {
            _name = name;
            _unit = unit;
            _unitPrice = unitPrice;
        }
        public Food(int ean, string name, string unit, double unitPrice)
        {
            _ean = ean;
            _name = name;
            _unit = unit;
            _unitPrice = unitPrice;
        }
        public string Name => _name;
        public string Unit => _unit;
        public int EAN => _ean;


        public double CalculateCost(double quantity)
        {
            return _unitPrice * quantity;
        }
    }
}