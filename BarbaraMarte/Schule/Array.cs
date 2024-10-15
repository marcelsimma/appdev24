using System.ComponentModel.DataAnnotations;

namespace BarbaraMarte.Schule;

class ZahlenArray
{
    public static void PrintZahlenArray(string[] args)
    {
        int[] numbers = new int[10];
        Console.WriteLine("Enter 10 Numbers: ");

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        int max = numbers[0];
        int min = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }
        Console.WriteLine($"Smallest numger: {min} Biggest number: {max}");
    }





    public static void Schlange(Array[] arg)
    {
        Console.WriteLine("Enter 5 numbers");
        int[] number = new int[5];

        for (int i = 0; i < number.Length; i++) // the loop will continio as long as i is less than the length of the number array
        {
            number[i] = Convert.ToInt32(Console.ReadLine());
        }
        int min = number[0];
        int max = number[0];

        foreach (int num in number)
        {

            if (num < min)
            {
                min = num;
            }
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"Biggest Number {max} smallest Number: {min}");

    }


}