using System;

namespace BarbaraMarte.Week01

{
    public class Modulo
    {
        public static void PrintModulo()
        {
            for (int i = -10; i <= 10; i++){
                //Das == wie eine Wage: Modulo gibt den Restwert einer Division zurück. Wenn ein Rest zurückbleibt dann wird die Zahl nicht ausgegeben.
                if (i%2 == 0){
                    Console.WriteLine(i);
                }
                
            }

        }
       

    }
}
