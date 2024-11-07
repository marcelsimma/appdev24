using System.Globalization;
using System.Security.Cryptography.X509Certificates;

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
            // gives you only the result back.                                        
            factorial = factorial * i;
        }
        Console.WriteLine($"Factorial of {number} is {factorial} ");
        {

            Console.WriteLine("Enter a number betwen 1 and 20: ");
            int number1 = Convert.ToInt16(Console.ReadLine());

            int Factorial2 = 1;           // the t below means Tabulator. "Einrückung" \n ist für den Zeilenumbruch
            Console.WriteLine(0 + "!\t" + Factorial2 + "\n");

            for (int i = 1; i < number; i++)
            {
                Console.Write(i + 1 + "!\t");       // shows you the whole calculation method.
                Factorial2 *= i + 1;
                Console.WriteLine(Factorial2 + "\n");
            }

        }
    }

    public static void Print(int faculty)
    {
        Console.WriteLine(Faculty(faculty).ToString());
        Console.WriteLine(FacultyUp(1, faculty).ToString());
    }
    static int Faculty(int i)
    {
        if (i == 0)
        {
            return 1;
        }
        else
        {
            return i * Faculty(i - 1);
        }
    }

    static int FacultyUp(int i, int end)  // Faculty from 5 => ((((1*2)*3)*4)*5)
    {
        if (i == end)
        {
            return i;
        }
        else
        {
            return i * FacultyUp(i + 1, end);
        }

        // Faculty(i + 1)
        // FacultyUp(1, 5) = 1*FacultyUp(2, 5)
        //FacultyUp(2, 5) = 2*FacultyUp(3, 5)
        //FacultyUp(3, 5) = 3*FacultyUp(4, 5)
        //FacultyUp(4, 5) = 4*FacultyUp(5, 5)
        //FacultyUp(5, 5) = 5
    }
}