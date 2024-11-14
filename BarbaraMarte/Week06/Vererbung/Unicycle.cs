using System;
using System.Security.Cryptography.X509Certificates;

namespace BarbaraMarte.Week06.Vererbung;

class Unicycle : Vehicle
{

    public new int Tire = 1;
    public Unicycle(int age, string color, string producer)
    {
        _Age = age;
        _Color = color;
        _Producer = producer;        
    }
    public override string ToString()
    {
        return string.Format(
            @$"
            
            
            ");
    }
}