namespace BarbaraMarte.Week03;

class Anwesenheitsliste()
{
    public static void Print()
    {
        Console.WriteLine("Anzahl der Teilnehmer");
        int anz = Convert.ToInt32(Console.ReadLine());
        string[,] Anwesenheit = new string[anz + 1, 6];
        string? again;
        Anwesenheit[0, 0] = "  ";
        Anwesenheit[0, 1] = "Mo";
        Anwesenheit[0, 2] = "Di";
        Anwesenheit[0, 3] = "Mi";
        Anwesenheit[0, 4] = "Do";
        Anwesenheit[0, 5] = "Fr";

        for (int i = 0; i < anz; i++)
        {
            Console.WriteLine($"Vorname des {i + 1}. Teilnehmers:");
            string? name = Console.ReadLine();
            if (name != null)
            {
                Anwesenheit[i + 1, 0] = name;
            }
        }
        do
        {
            IsHere(Anwesenheit, anz);
            for (int i = 0; i < anz + 1; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(Anwesenheit[i, j] + "\t");
                    if (j == 0)
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n-------------------------------------------------------");
            }
            Console.WriteLine("Weitere Anwesenheit eintragen? (j/n)");
            again = Console.ReadLine();

        } while (again == "j");

        static void IsHere(string[,] Anwesenheit, int anz)
        {
            Console.WriteLine("Welcher Teilnehmer ist Abwesend?");
            string? name = Console.ReadLine();
            bool foundName = false;
            for (int i = 0; i < anz + 1; i++)
            {
                if (Anwesenheit[i, 0] == name)
                {
                    foundName = true;
                    Console.WriteLine("Tag? (Mo/Di/Mi/Do/Fr)");
                    string? day = Console.ReadLine();
                    switch (day)
                    {                                                   // Controle here which day the Computer has to set the X
                        case "Mo": Anwesenheit[i, 1] = "X"; break;
                        case "Di": Anwesenheit[i, 2] = "X"; break;
                        case "Mi": Anwesenheit[i, 3] = "X"; break;
                        case "Do": Anwesenheit[i, 4] = "X"; break;
                        case "Fr": Anwesenheit[i, 5] = "X"; break;
                    }
                }

            }
            if (foundName == false)
            {
                Console.WriteLine("Name not found");
            }
        }
    }
}


/* Try 1:
string output = "Your attendance list: ";
        char addNewPerson;
        int numOfPeople = 0;
        char presence;


        do
        {
            output += $"{name,6}";

            Console.WriteLine("Is there some one more who you want to add to the List? (j/n)");
            addNewPerson = ConsoleInput.ReadNextChar();
            numOfPeople++;

        } while (addNewPerson == 'j');

        Console.Write(output);
        Console.WriteLine();
        Console.WriteLine(@$"-------------------------
        People who atend your course: {numOfPeople}");

         string[,] atendingList = new string[5, 6]{
            {"Name", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" },    //0;0 0;1 0;2 0;3 0;4 0;5 0;6 
            {" ", " ", " ", " ", " ", " ", " "},    //1;0
            {" ", " ", " ", " ", " ", " ", " "},   //2;0
            {" ", " ", " ", " ", " ", " ", " "},    //3;0
            {" ", " ", " ", " ", " ", " ", " "},    //4;0                    
        };
        Console.WriteLine("Please enter the Name from your 4 Students");
        string name = Console.ReadLine();

        Console.WriteLine($"Is {name}? Press (Y/N)");
        char isHere = ConsoleInput.ReadNextChar();
        if (isHere == 'Y')
        {
            Console.Write("School");
        }
        else
        {
            Console.Write("Sick v");
        }

         while ()
        {
            PrintGrid();
            {
                if
            }
        }

Try 2:
 string[] grid = new string[36] { "Name:", "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Name1", "1;1", "1;2", "1;3", "1;4", "1;5", "Name2", "2;1", "2;2", "2;3", "2;4", "2;5", "Name3", "3;1", "3;2", "3;3", "3;4", "3;5", "Name4", "4;1", "4;2", "4;3", "4;4", "4;5", "Name5", "5;1", "5;2", "5;3", "5;4", "5;5" };
        char list;
        PrintGrid();

        do
        {
            string choice = Console.ReadLine();
            int grindIndex;
        } while (true);


        //Console.WriteLine("Enter the Name and Press the number for the day");

        void PrintGrid()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(grid[i * 6 + j] + "|");
                    //Console.Write(j + "|");
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
            }
        }

        Try 3:

        string[] teilnehmer = new string[4];
        teilnehmer[0] = $"{name} is sick on {day}";






        string? name1 = Console.ReadLine();
        string? name2 = Console.ReadLine();
        string? name3 = Console.ReadLine();
        string Monday = "Monday";
        string Tuesday = "Tuesday";
        string Wednesday = "Wednesday";
        string Thursday = "Thursday";
        string Friday = "Friday";

        teilnehmer[1] = $"{name1} \t";
        teilnehmer[2] = $"{name2} \t";
        teilnehmer[3] = $"{name3} \t";

        for (int i = 0; i <= teilnehmer.Length - 1; i++)
        {
            Console.WriteLine(teilnehmer[i]);
        }

        Console.WriteLine("Who is sick?");
        sick = Console.ReadLine();

        Console.WriteLine($"Whick day is {sick} sick?");
        day = Console.ReadLine();

        Console.WriteLine($"{sick} is on {day} sick");

        
        string sick;
        string day;
        char anotherPerson;
        int numOfSickPeople = 0;
        string name;
        string output;

        string[] teilnehmer = new string[4];
     
        string? name1 = Console.ReadLine();
        string? name2 = Console.ReadLine();
        string? name3 = Console.ReadLine();
        string Monday = "Monday";
        string Tuesday = "Tuesday";
        string Wednesday = "Wednesday";
        string Thursday = "Thursday";
        string Friday = "Friday";

        teilnehmer[0] =
        teilnehmer[1] = $"{name1} \t";
        teilnehmer[2] = $"{name2} \t";
        teilnehmer[3] = $"{name3} \t";

        for (int i = 0; i <= teilnehmer.Length - 1; i++)
        {
            Console.WriteLine(teilnehmer[i]);
        }

        Console.WriteLine("Who is sick?");
        sick = Console.ReadLine();

        Console.WriteLine($"Whick day is {sick} sick?");
        day = Console.ReadLine();

        Console.WriteLine($"{sick} is on {day} sick");

       // teilnehmer[0] = $"{name} is sick on {day}";

        Try 4:

        string sick;
        string day;
        char anotherPerson;
        int numOfSickPeople = 0;
        string name;
        string output;

        do
        {
            Console.WriteLine("Please enter the name from one sick person:");
            name = Console.ReadLine();
            output += $"{name,6}";

            Console.WriteLine($"When is {name} sick?");
            day = Console.ReadLine();
            output += $"{day,-5}";

            Console.WriteLine("Do you wand to add an other sick person to your list? (j/n)");
            anotherPerson = ConsoleInput.ReadNextChar();
            numOfSickPeople++;

        } while (anotherPerson == 'j');

        // Console.WriteLine($"\n{name} is on {day} sick.");
        Console.Write(output);
        Console.WriteLine(numOfSickPeople);



*/