using System;

namespace MarcelSimma.Week04
{

    public class StringMethods
    {

        public static void Start()
        {

            string example = "Hallo, hallo liebes Publikum!";
            
            int stringLength = example.Length;
            Console.WriteLine(stringLength);

            string substring = example.Substring(3, 5);
            Console.WriteLine(substring);

            int index = example.IndexOf("lo");
            Console.WriteLine(index);

            bool enthalten = example.Contains("Leib");
            Console.WriteLine(enthalten);

            example.StartsWith("Halo");

            example.EndsWith("kum!");

            string[] splitted = example.Split("l");

            foreach (string elem in splitted) {
                Console.Write(elem);
            }

            Console.WriteLine();

            string zusammengebaut = string.Join("&&", splitted);

            Console.WriteLine(zusammengebaut);


            double kommazahl = 12.345678;

            double formatiert = Math.Round(kommazahl, 2);

            string result = string.Format("Distanz: {0, 20:F2}", formatiert);

            Console.WriteLine(result);


            string input = "Hallo, lieber !";
            string person = "Nico";

            string concated = input.Insert(14, person);
            Console.WriteLine(concated);

            string salutation = concated.Remove(7, 6);
            Console.WriteLine(salutation);

            string textToTrim = "     jkldöasdölkf      ";

            Console.WriteLine(textToTrim.Trim());
        }



    }
}