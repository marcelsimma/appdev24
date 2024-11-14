using System;
using System.IO.Pipes;

namespace OliverBedogg.Week06
{

    public class FahrzeugMain
    {
        public static void Start()
        {
            Console.WriteLine("\nFahrzeug -------------");
            // Kann als abstrakte Klasse nicht instanziert werden.
            // Fahrzeug fahrzeug = new Fahrzeug(1000);
            // fahrzeug.fahren(40);

            Console.WriteLine("\nAuto -------------");
            Auto auto = new Auto(400);
            auto.fahren();

            Console.WriteLine("\nEinrad -------------");
            Einrad einrad = new Einrad(4);
            einrad.fahren();

            Console.WriteLine("\nMotorrad -------------");
            Motorrad motorrad = new Motorrad(300);
            motorrad.fahren(10);
        }
    }
}