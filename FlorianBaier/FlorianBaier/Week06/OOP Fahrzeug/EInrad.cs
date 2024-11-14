using System;

namespace FlorianBaier.Week06
{
public class Einrad : Fahrzeug
{
    public Einrad() : base(1) // Ein Einrad hat 1 Rad
    {
    }

    public void Fahren()
    {
        Console.WriteLine("Das Einrad fährt.");
    }
}
}