using System;

namespace MagdalenaMueller.Week05
{
    public class Motorrad
    {
        int drivedKilometers; 
        
        public Motorrad(int drivedKilometers)
        {
            this.drivedKilometers = drivedKilometers;
        }

        public void Driving()
        {
            var r = new Random();
            int randomKilometer = r.Next(1,100);

            drivedKilometers += randomKilometer;


            Console.WriteLine("Motorrad ist in bewegung");
            Console.WriteLine($"Gefaherne Kilometer: {randomKilometer}");
            Console.WriteLine($"Gesamt Kilometer: {drivedKilometers}");
        }
        public void StopedDriving()
        {
            Console.WriteLine("Motorrad nicht in bewegung");
        }

        public override string ToString()
        {
            return $"Gefahrene Kilometer: {drivedKilometers}";
        }
        public void Write()
        {
            Console.WriteLine(this.ToString());
            var random = new Random();
            int randomr = random.Next(0,2);
            if(randomr == 0)
            {
                StopedDriving();
                Console.WriteLine($"Gefahrene Kilometer: {drivedKilometers}");
            }
            else
            {
                Driving();
            }
            
        }

    }
}