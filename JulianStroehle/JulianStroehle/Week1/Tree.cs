using System;

namespace JulianStroehle.Week1
{
    class Tree
    {
        public static void Start()
        {
            //Nutzeragfrage über Größe und Zeichen für Blätter, Kugeln und Stamm
            Console.WriteLine("Bitte größe des Baums eingeben: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zeichen für Blätter: ");
            string? a = Console.ReadLine();
            if (!string.IsNullOrEmpty(a))
            {
                char blatt = Convert.ToChar(a);

                Console.WriteLine("Zeichen für Kugeln: ");
                string? b = Console.ReadLine();
                if (!string.IsNullOrEmpty(b))
                {
                    char kugel = Convert.ToChar(b);

                    Console.WriteLine("Zeichen für Stamm: ");
                    string? c = Console.ReadLine();
                    if (!string.IsNullOrEmpty(c))
                    {
                        char stamm = Convert.ToChar(c);

                        // Zufallsgenerator
                        Random random = new(); 
                        for (int i = 0; i < height; i++)
                        {
                            Console.Write(new string(' ', height - i - 1));

                            // Kugeln werden zufällig in den Baum ein eingefügt
                            for (int j = 0; j < 2 * i + 1; j++)
                            {
                                // Kugeln werden mit 15% Wahrscheinlichkeit eingefügt
                                if (random.NextDouble() < 0.15)
                                {
                                    Console.Write(kugel);
                                }
                                else
                                {
                                    Console.Write(blatt);
                                }


                            }
                            // Weitere Initialisierungen
                            if (i == height - 1)
                            {
                                Console.WriteLine();
                                int k = 0;
                                int ungerade = 0;
                                double sizeRounded = height / 3 * 2;
                                int rounded = Convert.ToInt32(Math.Round(sizeRounded));

                                // Stamm berechnen
                                if (i%2!=0)
                                {
                                    ungerade++;
                                }
                                while (k < height / 4)
                                {
                                    Console.Write(new string(' ', (height*2-(height + 1)/2)/2-ungerade) + new string(stamm, (height + 1) / 2));
                                    Console.WriteLine();
                                    k++;
                                }

                            }

                            // Zeilenumbruch
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}