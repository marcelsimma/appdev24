using System;



namespace AlessioGaudio.Week02 
{
    class TicTacToee
    {
        static int[,] feld = new int[3, 3]; 
        static int spieler = 1;

        public static void Start()
        {
            while (true)
            {
                Console.Clear();
                ZeigeFeld();
                if (SpielZug() || Unentschieden()) break;
                spieler = 3 - spieler; // Spieler wechseln
            }
        }

       public static void ZeigeFeld()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Console.Write((feld[i, j] == 0 ? "." : (feld[i, j] == 1 ? "X" : "O")) + (j == 2 ? "\n" : ""));
        }

       public static bool SpielZug()
        {
            Console.WriteLine($"Spieler {spieler}, Zeile und Spalte (0-2): ");
            int x = int.Parse(Console.ReadLine()), y = int.Parse(Console.ReadLine());
            if (feld[x, y] != 0) return SpielZug();
            feld[x, y] = spieler;

            return Gewinner();
        }

      public  static bool Gewinner()
        {
            for (int i = 0; i < 3; i++)
                if ((feld[i, 0] == spieler && feld[i, 1] == spieler && feld[i, 2] == spieler) || 
                    (feld[0, i] == spieler && feld[1, i] == spieler && feld[2, i] == spieler)) 
                    return ZeigeEnde($"Spieler {spieler} gewinnt!");

            if ((feld[0, 0] == spieler && feld[1, 1] == spieler && feld[2, 2] == spieler) || 
                (feld[0, 2] == spieler && feld[1, 1] == spieler && feld[2, 0] == spieler)) 
                return ZeigeEnde($"Spieler {spieler} gewinnt!");

            return false;
        }

     public   static bool Unentschieden()
        {
            foreach (var feldWert in feld) if (feldWert == 0) return false;
            return ZeigeEnde("Unentschieden!");
        }

      public  static bool ZeigeEnde(string message)
        {
            Console.Clear();
            ZeigeFeld();
            Console.WriteLine(message);
            return true;
        }
    }
}
