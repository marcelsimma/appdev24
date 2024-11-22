using System;

namespace BarbaraMarte.Week06.Vererbung;

public class Car : MotorizedVehicle
{
    int _Doors;

    public int Doors
    {
        get => _Doors;
        set => _Doors = value;
    }

    public Car(int doors, string name, string producer, string color, int age, double km, double leftInTheGasTank, double gasUsagePer100KM) : base(name, producer, color, age, km, leftInTheGasTank, gasUsagePer100KM)
    {
        _Doors = doors;
    }
    public override string ToString()
    {
        return string.Format(@$"
        Producer:   {_Producer}
        Car name:   {_Name}
        Color:      {_Color}
        Age:        {_Age}
        Car doors:  {_Doors}.
        Driven Km:  {KM}
        Tank level  {LeftInTheGasTank}");
    }
}