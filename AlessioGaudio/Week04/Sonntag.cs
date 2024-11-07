using System;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace AlessioGaudio.Week04
{
    public class Sonntag
    {
        public static void Start()

        {   
            DateTime d2 = DateTime.Now;
            DateTime sonntag = d2.AddDays(4);

            Console.WriteLine($" Sonntag Diese Woche: {sonntag.ToString("dd.M.yyyy")}");

            DateTime sonntag2 = sonntag.AddDays(7);

            Console.WriteLine($" Sonntag Nächste Woche: {sonntag2.ToString("dd.M.yyyy")}");

            
            DateTime sonntag3 = sonntag2.AddDays(7);

            Console.WriteLine($" Sonntag Übernächste Woche: {sonntag3.ToString("dd.M.yyyy")}");



        }
    }
}