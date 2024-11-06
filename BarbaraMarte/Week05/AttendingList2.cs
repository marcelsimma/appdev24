using System.IO;

namespace BarbaraMarte.Week05;

class AttendingList2
{
    public static void Print()
    {
        string line;
        int count = 1;
        using (StreamReader stream = new StreamReader("C:/AttendingList1/Input.txt"))
        {
            using (StreamWriter streamWriter = new StreamWriter("C:/AttendingList1/Output.txt"))
            {
                while ((line = stream.ReadLine()) != null)
                {
                    streamWriter.WriteLine(count + ": " + line);
                    count++;
                }

            }

        }




    }
    /*
        public static void PrintFile(string line)
        {
            using (StreamWriter streamWriter = new StreamWriter("C:/AttendingList1/Output.txt"))
            {

                streamWriter.WriteLine(line);
                //Console.WriteLine(ReadFile);
            }
        }
    */
}