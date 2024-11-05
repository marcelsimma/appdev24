using System;


namespace JonasWehinger.Week01
{
    class PrintA
    {
        static void Print(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Console.WriteLine();
            
            Console.WriteLine("\\");
            Console.WriteLine(@" \");
            Console.WriteLine(@"  \");
            
            Console.WriteLine();
            
            Console.Write(@"
            \
             \
              \");

            Console.WriteLine();

            Console.Write("\t\\\n\t \\\n\t  \\\n");

        }
    }
}
