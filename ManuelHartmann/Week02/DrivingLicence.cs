
namespace ManuelHartmann.Week02
{

    public class DrivingLicence
    {
        static void Start(string[] args)
        {
            Console.WriteLine("Hey mate, what's your name?");
            string responseName = Console.ReadLine();
            Console.WriteLine(responseName + ", may you tell me your age?");
            string responseAge = Console.ReadLine();
            if(int.TryParse(responseAge, out int age) && age > 0)
            {
                if (age >= 18)
                {
                    Console.WriteLine($"{responseName} {responseAge}: Moped Yes, Car Yes -> both vehicles: Yes");
                }
                else if (age >= 15)
                {
                    Console.WriteLine($"{responseName} {responseAge}: Moped Yes, Car No -> both vehicles: No");
                }
                else
                {
                    Console.WriteLine($"{responseName} {responseAge}: You are NOT allowed to ride a moped NOR to drive a car.");
                }
            }
            else
            {
                Console.WriteLine("That's not a number!");
            }
        }
    }
}




