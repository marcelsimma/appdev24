
using System.ComponentModel;

namespace MarcelSimma.Week04{

    class CountLetters {

        /*
        char c      ASCII-Code      counter[c]++
        H           72              1
        a           97              1
        l           108             1
        l           108             2





        */




        public static void Start() {
            string test = "Hallo, ich bin ein Text";

            char[] textArray = test.ToCharArray();

            int[] counter = new int[65536];

            foreach (char c in textArray) {
                // Zeichen 2 hat den Int-Wert von 50
                counter[c]++;
            }

            for (int i = 0; i < counter.Length; i++) {
                if (counter[i] > 0) {
                    Console.WriteLine("Der Buchstabe " + (char)i + ", repräsentiert durch den ASCII Code " + i + " kommt " + counter[i] + " Mal im Text vor.");
                }
            }


        }
    }
} 