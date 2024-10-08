using System.Globalization;

namespace BarbaraMarte.Week02;

class Factorial

{
    public static void PrintFactorial()
    {
        Console.WriteLine("Enter a number betwen 1 and 20: ");
        int number = Convert.ToInt16(Console.ReadLine());

        int factorial = 1;
        //means that you add always one more to the i
        for (int i = 1; i <= number; i++)
        {
            //  
            factorial = factorial * i;
        }
        Console.WriteLine($"Factorial of {number} is {factorial} ");


        {

            Console.WriteLine("Enter a number betwen 1 and 20: ");
            int number1 = Convert.ToInt16(Console.ReadLine());

            int Factorial2 = 1;           // the t below measn Tabulator. "Einrückung" \n ist für den Zeilenumbruch
            Console.WriteLine(0 + "!\t" + Factorial2 + "\n");

            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + 1 + "!\t");
                Factorial2 *= i + 1;
                Console.WriteLine(Factorial2 + "\n");
            }

        }


    }
}