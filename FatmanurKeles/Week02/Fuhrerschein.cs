using System;

namespace FatmanurKeles.Week02
{
    public class Fuhrerschein
    {
        public static void FuhrerscheinBerechtigung()
        {
            Console.WriteLine("Bitte geben Sie Ihr Alter ein: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 16 && age < 18)
            {
                Console.WriteLine("Moped Ja, Auto Nein, für beide Fahrzeuge: Nein");
            }

            else if (age >= 18)
            {
                Console.WriteLine("Moped Ja, Auto Ja, für beide Fahrzeuge: Ja");
            }

            else
            {
                Console.WriteLine("Moped Nein, Auto Nein, für beide Fahrzeuge: Nein");
            }
        }
    }
}
