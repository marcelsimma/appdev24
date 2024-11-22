using System;

namespace SimonJochum.Week06.Vehicles
{
    public class StartVehicle
    {
        public static void StartNowVehicle()
        {
            Car mustang = new Car("Mustang","4", 15.5);
            Console.WriteLine(mustang.Drive());
            Monocycle mono = new Monocycle("Einrad", "1", "2");
            Console.WriteLine(mono.Drive());
            Bicycle cycle = new Bicycle("Fahrrad", "2", "2");
            Console.WriteLine(cycle.Drive());
        }
    }
}