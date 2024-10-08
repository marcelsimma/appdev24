using System.Reflection;

namespace BarbaraMarte.Week02;

class Drivinglicence
{
    public static void PrintDrivinglicence()
    {
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("How old are you");
            int age = Convert.ToInt32(Console.ReadLine()); //int (local varible), in this case age = Convert.ToInt32 are uset to bring the Console.ReadLine in a usable string
            {
                if (age >= 18 && age <= 85) // if you want to add a second varible you ned the && !!
                {
                    Console.WriteLine("good, you can drive a car");
                }

                else
                {
                    Console.WriteLine("i am sorry, but you can't drive a car!");
                }
                if (age >= 16 && age <= 84)
                {
                    Console.WriteLine("good, you can drive a moped");
                }

                else
                {
                    Console.WriteLine("ask your mom");
                }

            }
        }

    }
}