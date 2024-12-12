using System.Threading.Tasks.Dataflow;

namespace BarbaraMarte.Week01

{
    class Probe
    {


        public static void PrintProbe() { }

        public static void ArrayWork()
        {
            Console.WriteLine("Please enter the size of the Array");
            int i = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[i];
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Please enter words or names until the array is full");
                arr[i] = Console.ReadLine() ?? "";
            }
            string[] arr2 = arr.Reverse().ToArray();
            foreach (string s in arr2)
            {
                Console.WriteLine($"{s}");
            }
        }


        public static void ArrayWork2()
        {
            Console.WriteLine("Please enter a Sentence");
            string input = Console.ReadLine() ?? "";
            string[] words = input.Split(' ', ',');
            foreach (string word in words)
            {
                Console.Write(word);
            }
        }

        /*{
            // Ansatz 1: + und - separat durchführen
            int loop = 1;
            int limit = 4;
            bool add = true;

            do
            {
                // modal
                if (loop % 2 != 0)
                {
                    Console.WriteLine("modal: plus");
                }
                else
                {
                    Console.WriteLine("modal: minus");
                }

                // bool
                if (add)
                {
                    Console.WriteLine("add: true");
                }
                else
                {
                    Console.WriteLine("add: false");
                }
                add = !add;

                loop++;
            } while (loop <= limit);
        }*/


    }
}
