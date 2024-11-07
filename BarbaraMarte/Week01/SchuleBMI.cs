namespace BarbaraMarte.Week01;

class Methode
{
    public static void Print()
    /* optionale Parameter Aufgabe: Schreibe ein Programm, welches eine Methode implementiert, die zweite Zahl als Parameter
    entgegennimmt und diese multipliziert und das Ergebnis zurueck gibt. Der zweite Paramete ist
    optional und hat standartmaesig den wert 1
    */
    {
        Console.WriteLine(Multiply(3, 4));
        Console.WriteLine(Multiply(3));
    }

    static int Multiply(int a, int b = 1)
    {
        return a * b;
    }

    public static void BMI()
    {
        double hight;
        double weight;
        //double hight2;

        Console.WriteLine("Please enter your hight: Example 1,74");
        hight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter your weight:");
        weight = Convert.ToDouble(Console.ReadLine());

        // hight2 = hight * hight;
        Console.WriteLine($"Your BMI is: {weight / Math.Pow(hight, 2)}");  //Math.Pow(height, Zahl wo man zum Quadrat nehmen will)
    }

    public static void Binary(int[] array)
    {
        int[] numbers = new int[4] { 0, 0, 0, 0 };
        int i;
        Console.WriteLine("Pleas enter a number between 0 and 7 in binary:");
        i = Convert.ToInt32(Console.ReadLine());

    }


}