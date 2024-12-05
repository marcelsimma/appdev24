using System;
using System.Diagnostics.Metrics;
using System.IO;
namespace NicoDobler.Week05;

public class Teilnehmerliste1
{

    public static void ReadFile()
    {

        using (StreamReader str = new StreamReader(@"C:\Users\Nico.Dobler\Documents\Digital Campus\Teilnehmerliste1.txt"))
        {
            string wholeFile = str.ReadToEnd();
            string[] values = wholeFile.Split("\n");

            int Counter = 0;


        

            for (int i = 0; i < values.Length; i++) {
                System.Console.WriteLine($"{Counter}. {values[i]}");
                Counter++;
            }
        }
    }


    public static void WriteFile()
    {
        using (StreamWriter str = new StreamWriter(@"C:\Users\Nico.Dobler\Documents\Digital Campus\Teilnehmerliste1.txt"))
        {


        }




    }
}

