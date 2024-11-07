using System;
using System.IO;

namespace FlorianBaier.Week05
{

    public static class Teilnehmerliste1
    {

        public static void Start()
        {
            ReadFile();
        }
        public static void ReadFile()
        {

            using (StreamReader str = new StreamReader("/Users/flori/Desktop/DigitalCampus/input.txt"))
            {
                string line;
                int index = 1;

                if ((line = str.ReadLine()) != null)
                {
                    line = line.Trim();
                    if (!string.IsNullOrEmpty(line))
                    {
                        Console.WriteLine(line);
                    }
                }

                while ((line = str.ReadLine()) != null)
                {

                    line = line.Trim();

                    if (!string.IsNullOrEmpty(line))
                    {
                        Console.WriteLine($"{index}.) {line}");
                        index++;
                    }
                }
            }
        }

    }
}