using System;

namespace BarbaraMarte.Week06.Vererbung;

public class Motorcycle : MotorizedVehicle
{
    int _SittingSpots;
    public int SittingSpots
    {
        get => _SittingSpots;
        set => _SittingSpots = value;
    }
    public new int Tire = 2;

    public Motorcycle(int sittingSpots, string name, string producer, string color, int age, double km, double leftInTheGasTank, double gasUsagePer100KM) : base(name, producer, color, age, km, leftInTheGasTank, gasUsagePer100KM)
    {
        _SittingSpots = sittingSpots;
    }
    public override string ToString()
    {
        return string.Format($@"
        I have a {_Producer}, {_Name}. With his vibrant {_Color} it stand's out on the streets.
        I think it is pretty nice to have {_SittingSpots} sitting spot.
        If I would train a little bit more than i could drive {Tire} tires and I would not need the extra {Tire} safety tires that I don't fall over...
        {LeftInTheGasTank}");
    }
}