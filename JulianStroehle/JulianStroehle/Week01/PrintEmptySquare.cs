using System;

namespace JulianStroehle.Week1{
    public class PrintEmptySquareA{
        public static void PrintEmptySquare(){
            Console.WriteLine("Reihen: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Spalten: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zeichen für Quadrat: ");
            char c1 = Convert.ToChar(Console.ReadLine());
            for (int i = 1; i <= n1; i++){
                for (int j = 1; j <= n2; j++){
                    if (i == 1 || i == n1 || j == 1 || j == n2){
                        Console.Write(c1);
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}