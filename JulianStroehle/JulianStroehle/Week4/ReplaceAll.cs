using System;
namespace JulianStroehle.Week4
{
    public class ReplaceAll
    {
        public static void Start()
        {
            string text = "Heute wird ein guter Tag! Heute wird ein noch guterer Tag! Heute wird ein spitzen guter Tag!";
            string nums = "749813247132984712039487123049871204398712039487";
            ReplaceA(text);
            ReplaceB(text);
            ReplaceC(nums);
        }
        static void ReplaceA(string text)
        {
            Console.WriteLine("\n" + text);
            string newText = text.Replace("wird", "war");
            Console.WriteLine("\n" + newText + "\n");
        }
        static void ReplaceB(string text)
        {
            Console.WriteLine("\n" + text + "\n");
            string newText = new(text.Where(c => !char.IsLower(c)).ToArray());
            Console.WriteLine("\n" + newText);
            Console.WriteLine("\n" + text + "\n");
            string newerText = new(text.Where(c => !char.IsUpper(c)).ToArray());
            Console.WriteLine("\n" + newerText);
            Console.WriteLine("\n\n" + text + "\n");
            string[] textNew = text.Split(' ');
            foreach (string s in textNew)
            {
                Console.Write(s);
            }
            Console.WriteLine("\n\n" + text + "\n");
            string[] textNewer = text.Split('!');
            foreach (string s in textNewer)
            {
                Console.Write(s);
            }
            Console.WriteLine("\n");
        }
        static void ReplaceC(string nums)
        {
            Console.WriteLine("\n" + nums + "\n");
            string newNums = new(nums.Where(c => !(c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')).ToArray());
            Console.WriteLine("\n" + newNums);
            Console.WriteLine("\n\n" + nums + "\n");
            string[] newernums = nums.Split('1', '2', '3' , '4', '5', '6', '7', '8', '9');
            foreach (string s in newernums)
            {
                Console.Write(s);
            }
            Console.WriteLine("\n\n" + nums + "\n");
            string[] numsNew = nums.Split('2', '3', '4');
            foreach (string s in numsNew)
            {
                Console.Write(s);
            }
            Console.WriteLine("\n\n" + nums + "\n");
            string[] numsNewer = nums.Split('1', '2', '3', '6', '7', '8', '9');
            foreach (string s in numsNewer)
            {
                Console.Write(s);
            }
            Console.WriteLine("\n");
        }
    }
}