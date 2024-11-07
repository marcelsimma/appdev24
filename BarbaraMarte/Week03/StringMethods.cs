using System.Security.Cryptography;

namespace BarbaraMarte.Week03;

class StringMethods
{

    public static void Print()
    {
        Console.WriteLine(string.Format("{0,-20}{1, -20}{2,-15}{3,-15}{4,-15}", "First Name", "Last Name", "Age", "Place", "Distance from Capital"));
        Console.WriteLine(string.Format("{0,-20}{1, -20}{2,-15}{3,-15}{4,-15}", "Alfons", "Klein", "40", "Wien", "0f"));
        Console.WriteLine(string.Format("{0,-20}{1, -20}{2,-15}{3,-15}{4,-15}", "Beatrix-Wlenor", "Kinderdorfer", "5", "Schwaryach", "654.4f"));
    }
}