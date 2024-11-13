using System;

namespace BarbaraMarte.Week06.Vererbung;

public class Motorcycle : Vehicle // Motorcycle erbt von Vehicle
{
    int _SittingSpots;
    public int SittingSpots
    {
        get => _SittingSpots;
        set => _SittingSpots = value;
    }
    public Motorcycle(string name, string producer, string color, int age, int sittingSpots)
    {
        _Name = name;
        _Producer = producer;
        _Color = color;
        _Age = age;
        _SittingSpots = sittingSpots;
    }
    public override string ToString()
    {
        return string.Format($"I have a {_Producer}, {_Name}. With his vibrant {_Color} it stand's out on the streets." + $" I think it is pretty nice to have {_SittingSpots} sitting spot.");
    }
}