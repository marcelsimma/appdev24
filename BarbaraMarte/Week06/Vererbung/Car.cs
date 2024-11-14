using System;

namespace BarbaraMarte.Week06.Vererbung;

public class Car : Vehicle
{
    int _Doors;

    public int Doors
    {
        get => _Doors;
        set => _Doors = value;
    }
    public Car(string name, string producer, string color, int age, int doors)
    {
        _Name = name;
        _Producer = producer;
        _Color = color;
        _Age = age;
        _Doors = doors;
    }
    public override string ToString()
    {
        return string.Format($"{_Producer} is the producer from the car {_Name}. It has the color {_Color}. For it's {_Age} it looks pretty good." + $"With it's {_Doors} it has a lovely size.");
    }
}