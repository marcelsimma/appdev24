using System;

namespace MagdalenaMueller.Week02
{
    public class WriteFromZeroToHundert()
    {
        public static void FromZeroToHundert1()
        {
            float i = 0;
            while(i<= 100)
            {
                Console.WriteLine($"{i:F1}");
                i += 0.1f;
            }
        }
        public static void FromZeroToHundert2()
        {
            for(float i = 0; i <= 100; i+= 0.1f)
            {
                Console.WriteLine($"{i:F1}");
            }
        }
    }
}