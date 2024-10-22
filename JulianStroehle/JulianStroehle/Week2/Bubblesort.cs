using System;
namespace JulianStroehle.Week2
{
    public class BubbleSort
    {
        public static void Start()
        {
            Console.WriteLine("Wie viele Zahlen sollen sortiert werden?");
            int numCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aufsteigend oder Absteigend? (Auf/Ab)");
            string? s = Console.ReadLine();
            if (s == "Auf")
            {
                Asc(numCount);
            }
            else if (s == "Ab")
            {
                Desc(numCount);
            }
            else{
                Console.WriteLine("Error");
            }
        }
        public static void Asc(int numCount)
        {
            int[] nums = new int[numCount];
            for (int l = 0; l < numCount; l++)
            {
                Console.WriteLine(l + 1 + ". Nummer");
                nums[l] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j+1];
                        nums[j+1] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            foreach (int k in nums)
            {
                Console.Write($"{k} ");
            }
        }
        public static void Desc(int numCount)
        {
            Console.WriteLine("hallo");
            int[] nums2 = new int[numCount];
            for (int l = 0; l < numCount; l++)
            {
                Console.WriteLine(l + 1 + ". Nummer");
                nums2[l] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < nums2.Length - 1; i++)
            {
                for (int j = 0; j < nums2.Length - 1; j++)
                {
                    if (nums2[j] < nums2[j+1])
                    {
                        int temp = nums2[j+1];
                        nums2[j+1] = nums2[j];
                        nums2[j] = temp;
                    }
                }
            }
            foreach (int k in nums2)
            {
                Console.Write($"{k} ");
            }
        }
    }
}