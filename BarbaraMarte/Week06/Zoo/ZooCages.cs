namespace BarbaraMarte.Week06.Zoo;

public class ZooCages
{
    public static void NameInput()
    {
        Console.WriteLine(
            @"
            Ocean = O
            Terrarium = T
            Amazon = A
            Print out the List = P
            Exit = E
            ");
        char input = Convert.ToChar(Console.ReadLine().ToLower());

    }

}