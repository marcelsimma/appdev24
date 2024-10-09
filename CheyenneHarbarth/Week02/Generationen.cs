using System;

namespace CheyenneHarbarth.Week02 {

    class Generationen {

        
        public static void CheckGeneration() {

            Console.WriteLine("Wie alt bist du?");
            int age = Convert.ToInt32(Console.ReadLine());          //da ReadLine einen string übergibt, müssen wir diesen zum Int konvertieren, um damit rechnen zu können
            int gen = 2024 - age;
            if (gen >= 2011) {
                Console.WriteLine($"{age} Jahre: Generation Alpha");
            }
            else if (gen <= 2010 && gen >= 1997) {
                Console.WriteLine($"{age} Jahre: Generation Z");
            }
            else if (gen <=1996 && gen >=1981) {
                Console.WriteLine($"{age} Jahre: Generation Y");
            }
            else if (gen <= 1980 && gen >= 1965) {
                Console.WriteLine($"{age} Jahre: Generation X");
            }
            else if(gen <= 1964 && gen >= 1946) {
                Console.WriteLine($"{age} Jahre: Generation fBoomer");
            }
            else if (gen <=1945 && gen >= 1928) {
                Console.WriteLine($"{age} Jahre: Generation Silent");
            }
        }
    }
}