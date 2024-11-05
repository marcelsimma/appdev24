using System;
using System.Security.Cryptography;

namespace JonasWehinger.Week03
{
    public class ArraySucheEindimensional
    {
        public static void Eindimensional()
        {
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Gib eine Zahl an:");
            int wert = Convert.ToInt32(Console.ReadLine());
            bool WertGefunden = false;


            

            for (int i = 0;i < array.Length; i++ )
            {
                if (wert == array[i])
                {
                    WertGefunden= true;
                    Console.WriteLine( $"Der eingegebene {wert} entspricht dem folgendem index {i}" );
                    

                }
            }

            if (WertGefunden == false)
            {

                Console.WriteLine("Der angegebene Wert konnte nicht gefunden werden");
                
            } 

            do {
                    if (WertGefunden == false)
                    {
                        Eindimensional();

                    }


                

                } while (wert > 10 || wert < 0);
                
            }
        }

    }

            


           