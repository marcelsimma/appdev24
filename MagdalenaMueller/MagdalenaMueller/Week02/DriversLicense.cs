using System;
using System.Reflection.Metadata.Ecma335;

namespace MagdalenaMueller.Week02
{
    public class DriversLicense
    {
        static  public void CheckLicenses()
        {
            string[] LicenseName = new string[4] {"Jakob", "Hubert", "Lara", "Johanna"};
            int[] Licenseage = new int[4] {16, 30, 17, 9};

            bool Moped = false;
            bool Car = false;
            for(int i = 0; i < LicenseName.Length; i++)
            {
                Console.WriteLine($"Name: {LicenseName[i]}");

                if (Licenseage[i] >= 16)
                {
                    Moped = true;
                    Console.WriteLine("Moped: Ja");
                }
                else 
                {
                    Moped = false;
                    Console.WriteLine("Moped: Nein");
                }

                if (Licenseage[i] >= 18)
                {
                    Car = true;
                    Console.WriteLine("Auto: Ja");
                }
                else
                {
                    Car = false;
                    Console.WriteLine("Auto: Nein");
                }

                if (Moped == true && Car == true)
                {
                    Console.WriteLine("Moped & Auto: Ja");
                }
                else 
                {
                    Console.WriteLine("Moped & Auto: Nein");
                }
                Console.WriteLine();
            }
            
        }
    }
}