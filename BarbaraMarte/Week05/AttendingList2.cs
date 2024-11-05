using System.IO;

namespace BarbaraMarte.Week05;

class AttendingList2
{
    //string line;
    public static string Print()
    {
        using (StreamReader stream = new StreamReader("C:/AttendingList1/Input.txt"))
        {
            string line;
            line = stream.ReadToEnd();
            Console.WriteLine(line);
            return line;
        }

        /*
            using (StreamWriter streamWriter = new StreamWriter("C:/AttendingList1/Output.txt"))
            {

                streamWriter.WriteLine();
                //Console.WriteLine(ReadFile);
            }

            */
    }

    public static void PrintFile(string line)
    {
        using (StreamWriter streamWriter = new StreamWriter("C:/AttendingList1/Output.txt"))
        {

            streamWriter.WriteLine(line);
            //Console.WriteLine(ReadFile);
        }
    }
}