namespace BarbaraMarte.Work
{
    class PiDecember
    {
        private static Random xAxis = new Random(42);
        private static Random yAxis = new Random(42);
        public static void Print()
        {
            double xAxisNumber = xAxis.NextDouble();
            double yAxisNumber = yAxis.NextDouble();

            InOrOutRadius(10, 10);
        }
        private static double InOrOutRadius(double xAxisNumber, double yAxisNumber)
        {

            return 1;
        }

        /*
        public static void Start()
        {
            System.Console.WriteLine("Write in a number between 3 and 100");
            int input = Convert.ToInt32(Console.ReadLine());
            double count = 1;
            bool adding = true;
            double four = 4;
            double piAfterComma;
            double placeholder;
            // List<double> piAfterComma = new List<double>();

            for (int i = 0; i < input; i++)
            {
                if (adding == true)
                {
                    four /= count;
                    piAfterComma += four;
                    adding = false;
                }
                else
                {
                    piAfterComma = 4 / count;
                    adding = true;
                }
                count += 2;
            }
            System.Console.WriteLine($"3,{piAfterComma}");
        }
        */
    }
}