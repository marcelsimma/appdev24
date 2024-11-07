namespace BarbaraMarte.Week03;

class AtendingList
{
    public static void Print()
    {
        Console.WriteLine("Please enter the amount ofthe atending students:");
        int amm = Convert.ToInt32(Console.ReadLine());      // define how many people are going to be in the list
        string[,] AtendingList = new string[amm + 1, 6];    // new string: for the i (lines) you take the amm (ammount) of people and add one
        string? again;
        AtendingList[0, 0] = "  ";
        AtendingList[0, 1] = "Mo";
        AtendingList[0, 2] = "Tu";
        AtendingList[0, 3] = "We"; // the 0 is for the line 0. The number is for the column Monday, Tuesday,...
        AtendingList[0, 4] = "Th";
        AtendingList[0, 5] = "Fr";

        for (int i = 0; i < amm; i++)
        {
            Console.WriteLine($"First name from the {i + 1}. student: ");
            string? name = Console.ReadLine();
            if (name != null)
            {
                AtendingList[i + 1, 0] = name;
            }
        }
        do
        {
            IsHere(AtendingList, amm);
            for (int i = 0; i < amm + 1; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(AtendingList[i, j] + "\t");
                    if (j == 0)
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n---------------------------------------------------------------------------");
            }
            Console.WriteLine("Do you want to add an other student? (j/n)");
            again = Console.ReadLine();
        } while (again == "j");

        static void IsHere(string[,] AtendingList, int amm)
        {
            Console.WriteLine("Sick students:");
            string? name = Console.ReadLine();
            bool foundName = false;
            for (int i = 0; i < amm + 1; i++)
            {
                if (AtendingList[i, 0] == name)
                {
                    foundName = true;
                    Console.WriteLine("Day? (Mo, Tue, Wed, Thur, Frid)?");
                    string? day = Console.ReadLine();

                    switch (day)
                    {
                        case "Mo": AtendingList[i, 1] = "X"; break;
                        case "Tue": AtendingList[i, 2] = "X"; break;
                        case "Wed": AtendingList[i, 3] = "X"; break;
                        case "Thur": AtendingList[i, 4] = "X"; break;
                        case "Frid": AtendingList[i, 5] = "X"; break;
                    }
                }
            }
            if (foundName == false)
            {
                Console.WriteLine("Name not found!");
            }

        }
    }
}