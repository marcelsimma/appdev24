using System;

namespace LucasSchiemann.Week02;

public class Randomiser
{

    public static void Randomise()
    {
        Console.WriteLine("Willkommen zum Zufallsshuffle Programm\nGib dein wort ein welches du shuffeln möchtest");
        string shuffelwort = Console.ReadLine();
        string FinsihedShuffel = Shuffler(shuffelwort);
        Console.WriteLine(FinsihedShuffel);

    }

    public static string Shuffler(string word)
    {
        char[] shuffelarray = word.ToCharArray();
        Random rnd = new Random();
        for (int i = shuffelarray.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                char temp = shuffelarray[i];
                shuffelarray[i] = shuffelarray[j];
                shuffelarray[j] = temp;
            }

         return new string(shuffelarray);
    }

    public static void Test()
    {
        float result = 16 / 3;


    }
}