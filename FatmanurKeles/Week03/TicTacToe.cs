using System;

namespace FatmanurKeles.Week03
{
    public class TicTacToe
    {
        public static void Start()
        {
            string[,] playground = new string[3, 3];

            int size = 3;
            string c = ".";

            for (int spalte1 = 0; spalte1 < size; spalte1++)
            {
                for (int zeile1 = 0; zeile1 < size; zeile1++)
                {
                    playground[spalte1, zeile1] = c;
                }
            }

            string input1 = "1";
            string input2 = "2";

            Boolean player1Won = false;
            Boolean player2Won = false;

            TicTacToe.FeldAusgabe(size, playground);

            do
            {
                //PLayer 1 ist dran

                Console.WriteLine("P1 bitte die Zeile festlegen: ");
                int zeile = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("P1 bitte die Spalte festlegen: ");
                int spalte = Convert.ToInt32(Console.ReadLine());

                playground[zeile, spalte] = input1;

                TicTacToe.FeldAusgabe(size, playground);



                //Player 2 ist dran

                Console.WriteLine("P2 bitte die Zeile festlegen: ");
                int zeilee = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("P2 bitte die Spalte festlegen: ");
                int spaltee = Convert.ToInt32(Console.ReadLine());

                playground[zeilee, spaltee] = input2;

                TicTacToe.FeldAusgabe(size, playground);



                //Hat jemand gewonnen?
                for (spalte = 0; spalte < size; spalte++)
                {
                    if (playground[spalte, 0] == input1 && playground[spalte, 1] == input1 && playground[spalte, 2] == input1)
                    {
                        Console.WriteLine("player1 hat gewonnen!");
                        player1Won = true;
                    }
                }

                if (player1Won = false)
                {
                    //PLayer 2 ist dran
                    Console.WriteLine("P2 bitte die Zeile festlegen: ");
                    zeile = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("P2 bitte die Spalte festlegen: ");
                    spalte = Convert.ToInt32(Console.ReadLine());


                    playground[zeile, spalte] = input2;

                    TicTacToe.FeldAusgabe(size, playground);
                }
                else if (player2Won = false)
                {
                    //PLayer 1 ist dran
                    Console.WriteLine("P1 bitte die Zeile festlegen: ");
                    zeile = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("P1 bitte die Spalte festlegen: ");
                    spalte = Convert.ToInt32(Console.ReadLine());


                    playground[zeile, spalte] = input1;

                    TicTacToe.FeldAusgabe(size, playground);
                }

            } while (player1Won == false && player2Won == false);
        }
        public static void FeldAusgabe(int size, string[,] playground)
        {
            for (int spalte = 0; spalte < size; spalte++)
            {
                for (int zeile = 0; zeile < size; zeile++)
                {
                    Console.Write(playground[spalte, zeile]);
                }
                Console.Write("\n");

            }
            Console.Write("--------------------------------------");
        }
    }
}