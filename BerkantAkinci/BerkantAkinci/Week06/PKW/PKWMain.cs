using System;
using System.IO.Pipes;

namespace BerkantAkinci.Week06.PKW
{

    public class PKWMain
    {
        public static void Start()
        {
            Console.WriteLine("\nFahrzeug -------------");
            // Kann als abstrakte Klasse nicht instanziert werden.
            // Fahrzeug fahrzeug = new Fahrzeug(1000);
            // fahrzeug.fahren(40);

            Console.WriteLine("\nAuto -------------");
            Auto auto = new Auto(400, 7.5);
            auto.fahren();
            auto.verbrauchProKilometer();

            Console.WriteLine("\nEinrad -------------");
            Einrad einrad = new Einrad(4);
            einrad.fahren();

            Console.WriteLine("\nMotorrad -------------");
            Motorrad motorrad = new Motorrad(300);
            motorrad.fahren(10);

            Console.WriteLine($"Motorrad ist ein Fahrzeug: " + (motorrad is Fahrzeug));
            Console.WriteLine($"Motorrad ist ein Motorrad: " + (motorrad is Motorrad));

        }
    }
}