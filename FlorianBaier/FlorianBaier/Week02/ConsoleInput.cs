using System;

namespace FlorianBaier.Week02
{

    public class ConsoleInput
    {

        public static void CI()
        {
            // Console.WriteLine("Verrate mir deinen Namen.");
            //  string input;
            //input = Console.ReadLine();
            ReadNextInt();
            // Console.WriteLine(input);
        }

        public static int ReadNextInt()
        {
            do {
            string input = Console.ReadLine();
            int input2 = Convert.ToInt32(input);
            return input2;
            } while (true);

        }
        public static double ReadNextDouble(){
            do{
            string input = Console.ReadLine();
            double input2 = Convert.ToDouble(input);
            return input2;
            }while (true);
        }

        public static char ReadNextChar(){
            do{
            string input = Console.ReadLine();
            char input2 = Convert.ToChar(input);
            return input2;

            }while (true);
            
        }

    }
}