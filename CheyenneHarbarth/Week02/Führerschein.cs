using System;

namespace CheyenneHarbarth.Week02 {

    class Führerschein {

        public static void Check() {

            Console.WriteLine("Wie heißt du?");
            string name = Console.ReadLine();
            Console.WriteLine("Wie alt bist du?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >=15 && age <=17) {
                Console.WriteLine($"{name}, {age} Jahre: Moped Ja, Auto Nein, du darfst nur Moped fahren!");
            }
            else if (age >= 18) {
                Console.WriteLine($"{name}, {age} Jahre: Moped Ja, Auto Ja, du darfst Moped und Auto fahren!");
            }
            else {
                Console.WriteLine($"{name}, {age} Jahre: Moped Nein, Auto Nein, du darfst noch garnicht fahren!");
            }
        }
    }
}