using System;
using System.Security.Cryptography.X509Certificates;

namespace MarcelSimma.Week01
{
    public class Methoden
    {
        public static void Start(string[] args)
        {
          
            for ( int i = 0; i < 5; i++) {
                DoSmth(i);
                //DoSmth();
            }
        

        }

        public static void DoSmth(int value) {
            Console.WriteLine(value);
        }

        public static void DoSmth() {
            Console.Write("Hello.");
        }
    }
}
