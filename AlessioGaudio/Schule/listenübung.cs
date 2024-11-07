using System;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace AlessioGaudio.Week04
{
    public class liste
    {
        public static void Start()

        {
            List<string> food = new List<string>();

Console.WriteLine("geb hier die zutaten ein");
            food.Add(Console.ReadLine());

            foreach ( string item in food );
            {
                Console.WriteLine(food);
            }

            Console.ReadKey();
        }

    }
}
