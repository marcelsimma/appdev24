using System;

namespace BarbaraMarte.Week06.Vererbung;

public class Vehicle
{
    public int wheels = 4;
    public int maxSpeed = 200;


    public string _Name;
    public string _Color;
    public string _Producer;
    public int _Age;


    public string Name
    {
        get => _Name;
        set => _Name = value;
    }
    public string Producer
    {
        get => _Producer;
        set => _Producer = value;
    }
    public int Age
    {
        get => _Age;
        set => _Age = value;
    }
    public string Color
    {
        get => _Color;
        set => _Color = value;
    }

    public override string ToString()
    {
        return string.Format("");
    }
}