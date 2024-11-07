using System;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace AlessioGaudio.Week04
{
    public class Datum
    {
        public static void Start()
        {
            // Console.WriteLine(d1);

            var d2 = DateTime.Now;
            // var d3 = DateTime.Today;
            //var d4 = DateTime.UtcNow;


            // Console.WriteLine(d2);
            //   Console.WriteLine(d3.ToShortDateString());
            //Console.WriteLine(d4);

            // var morgen = d2.AddDays(0);
            // Console.WriteLine(morgen.ToString("dd.M.yyyy"));
            // Console.WriteLine(morgen.ToString("HH:mm"));
            // Console.WriteLine(morgen.ToString("dd,M,yyyy HH:mm"));
            //  Console.WriteLine(morgen.ToString("dd,M,yyyy HH:mm K"));
            //  Console.WriteLine(morgen.ToString("ss:ff"));


            Console.WriteLine("bitte hier geburtstag eingeben:");

            Console.WriteLine("Tag:");
            int Tag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Monat:");
            int Monat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jahr:");
            int Jahr = Convert.ToInt32(Console.ReadLine());

            DateTime d1 = new DateTime(Jahr, Monat, Tag);

            Console.WriteLine($"du hast geburtstag am {Tag}.{Monat}.{Jahr}");

            Console.WriteLine("Dein geburtstag ist an einem: " + d1.ToString(":"));

        }
    }
}

