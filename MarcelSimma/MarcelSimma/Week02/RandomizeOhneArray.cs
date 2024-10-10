using System;

namespace MarcelSimma.Week02
{

    class RandomizeOhneArray
    {

        public static void start(string input)
        {

            string currentText = input;

            Random random = new Random();

            while (currentText.Length > 0)
            {
                // generate random Number
                int rand = random.Next(0, currentText.Length - 1);

                // split the currentText into three parts
                string substringBefore = currentText.Substring(0, rand);
                string randomLetter = currentText.Substring(rand, 1);
                string substringAfter = currentText.Substring(rand + 1, currentText.Length - rand -1);
                
                // print the randomLetter to console
                Console.Write(randomLetter);

                // rebuild the currentText for the next loop without the randomLetter
                currentText = substringBefore + substringAfter;
            }
        }
    }
}