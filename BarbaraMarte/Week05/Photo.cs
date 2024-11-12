using System;

namespace BarbaraMarte.Week05
{
    class Photo
    {
        string _ModelName;
        string _Producer;
        int _Amount;
        public string ModelName
        {
            get => "\"" + _ModelName + "\"";
        }
        public string Producer
        {
            get => "\"" + _Producer + "\"";
        }
        public int Amount
        {
            get => _Amount;
            set => _Amount = value;
        }
        public Photo(string modelName, string producer, int amount)
        {
            _ModelName = modelName;
            _Producer = producer;
            _Amount = amount;
        }
        public override string ToString()
        {
            return string.Format("Model name: {0}, Producer: {1}, Amount: {2}", _ModelName, _Producer, _Amount);
        }
    }
}