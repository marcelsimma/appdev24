using System;
namespace JulianStroehle.Week2
{
    public class License
    {
        public static void Start()
        {
            string?[] names = new string[5];
            int[] ages = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Name eingeben");
                names[i] = Console.ReadLine();
                Console.WriteLine("Alter eingeben");
                ages[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < 5; j++)
            {
                if (ages[j] >= 15 && ages[j] < 18)
                {
                    Console.WriteLine(names[j] + ages[j] + " darf Moped, aber noch kein Auto fahren.");
                }
                else if (ages[j] >=18)
                {
                    Console.WriteLine(names[j] + ages[j] + " darf Moped und Auto fahren.");
                }
                else
                {
                    Console.WriteLine(names[j] + ages[j] + " darf noch gar nicht fahren.");
                }
            }
        }
    }
}