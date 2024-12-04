using System;
 
namespace  NicoDobler.Week02{



public class Lizenz
{
    public static void Start()
    {
        int counter = 0;
        while (counter < 5)
        {
            counter ++;
            Console.WriteLine("Typ"+ counter +" gib deinen Namen an: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Typ "+counter+" Gib jetzt dein Alter an: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Moped(Name,age);
           
 
        }
    }
        public static void Moped(string Name,int age)
        {
            if (age < 15)
            {
                Console.WriteLine(Name + "ist nicht alt genug für den Moped- oder Auto Führerschein");
            }
            else
            {  
                Console.WriteLine("Du bist Alt genug für den Mopedführerschein");
                Car(Name,age);
 
            }
 
        }
        public static void Car(string Name,int age)
        {
            if (age < 18)
            {
                Console.WriteLine("Du bist zwar alt genug für den Mopedführerschein aber nicht alt genug für den Autoführerschein");
 
            }
            else
            {
                Console.WriteLine("Du bist über 18 also kannst du den Moped- und Autoführerschein machen");
            }
        }
}
}
 