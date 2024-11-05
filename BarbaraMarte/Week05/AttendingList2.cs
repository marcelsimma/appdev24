using System.IO;

namespace BarbaraMarte.Week05;

class AttendingList2
{
    //string line;
    public static void Print()
    {
        string line;
        int count = 1;
        using (StreamReader stream = new StreamReader("C:/AttendingList1/Input.txt"))
        {
            using (StreamWriter streamWriter = new StreamWriter("C:/AttendingList1/Output.txt"))
            {
                do
                {
                    line = stream.ReadLine();
                    count++;
                } while (stream.ReadLine != null);

                streamWriter.Write(line);
                streamWriter.WriteLine(count + " Number");
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