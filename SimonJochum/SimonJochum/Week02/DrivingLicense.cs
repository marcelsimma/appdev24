using System;

namespace SimonJochum.Week02
{
    public class DrivingLicense
    {
        private static string name; //hier werden die Klassen für CheckMoped und CheckCar zugänglich gemacht
        private static int age;
        private static bool check1;
        private static bool check2;

        
        public static void Start()
        {
            Console.WriteLine("Hallo, bitte gib deinen Namen ein.");
            name = Console.ReadLine();
            Console.WriteLine($"Hallo {name}, wie alt bist du?");
            age = Convert.ToInt32(Console.ReadLine());

            CheckMoped();
            CheckCar();

            if (check1 == true && check2 == true)
            {
                Console.WriteLine($"{name} du darfst Moped und Auto fahren");
            }
            else if (check1 == true && check2 == false)
            {
                Console.WriteLine($"{name} du darfst nur Moped fahren.");
            }
            else
            {
                Console.WriteLine($"{name} du darfst weder Moped noch Auto fahren.");
            }
        }

        public static void CheckMoped()
        {
            
            if (age >= 15)
            {
                check1 = true;
            }
            else
            {
                check1 = false;
            }

        }
        public static void CheckCar()
        {
            if (age >= 18)
            {
                check2 = true;
            }
                
            else
            {
                check2 = false;
            }
        }
    }
}