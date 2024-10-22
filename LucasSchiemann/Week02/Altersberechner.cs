using System;
using System.Security.Cryptography.X509Certificates;

namespace LucasSchiemann.Week02;

public class AgeCalc
{
    public static void Calc()
    {
        int counter = 0;
        while (counter < 5)
        {
            counter ++;
            Console.WriteLine("Typ"+ counter +" gib deinen Namen an: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Typ "+counter+" Gib Jetzt dein alter an: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Moped(Name,age);
            

        }
    }
        public static void Moped(string Name,int age)
        {
            if (age < 15)
            {
                Console.WriteLine(Name + "ist nicht alt genug für den Moped oder Auto Führerschein");
            }
            else 
            {   
                Console.WriteLine(Name+"Alt genug für denn Moped Führerschein");
                Car(Name,age);
            }
        }
        public static void Car(string Name,int age)
        {
            if (age < 18)
            {
                Console.WriteLine(Name+" ist zwar alt genug für denn Moped führerschein aber nicht alt genug für denn Autoführerschein");

            }
            else
            {
                Console.WriteLine(Name+" ist über 18 also kannst du denn moped und Autoführerschein machen");
            }
        }
}




