using System;

namespace CheyenneHarbarth.Week05.Streams
{
    class Quadrieren
    {
        public static void Aufgabe3()           //Quadrieren
        {
            using (StreamReader str = new StreamReader("/Users/BAU28365/Documents/numbers.txt"))
            {
                int a = Convert.ToInt32(str.ReadLine());
                int b = Convert.ToInt32(str.ReadLine());
                int c = Convert.ToInt32(str.ReadLine());
                int d = Convert.ToInt32(str.ReadLine());
                int e = Convert.ToInt32(str.ReadLine());



                using (StreamWriter stro = new StreamWriter("/Users/BAU28365/Documents/results.txt"))
                {
                    int f = a * a;
                    int g = b * b;
                    int h = c * c;
                    int i = d * d;
                    int j = e * e;

                    stro.WriteLine(f + " = " + a + " * " + a);
                    stro.WriteLine($"{g} = {b} * {b}");
                    stro.WriteLine($"{h} = {c} * {c}");
                    stro.WriteLine(i + " = " + d + " * " + d);
                    stro.WriteLine(j + " = " + e + " * " + e);
                }
            }
            Console.WriteLine("fertig");
        }
    }
}