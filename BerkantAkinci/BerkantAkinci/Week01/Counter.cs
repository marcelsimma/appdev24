using System;


namespace BerkantAkinci.Week01
{


    class Counter
    {


        static void PrintCounter()
        {

            for (int i = 0; i < 5; i++)
            {
                DoSmth(i);


            }

            DoSmth();

        }

        public static void DoSmth(int value)
        {
            Console.WriteLine(value);

        }


        public static void DoSmth()
        {
            Console.WriteLine("Hello World");

        }
    }

}