using System;
using System.IO;

namespace BarbaraMarte.Week05;

class AttendingList1
{
    public static void Print()
    {
        using (StreamReader streamWriter = new StreamReader("C:/AttendingList1/Input.txt"))
        {
            string? line = streamWriter.ReadLine();
            Console.WriteLine(line);

            for (int i = 0; i < line.Length; i++)
            {
                string? newLine = streamWriter.ReadLine();
                Console.Write(i + 1 + " ");
                Console.WriteLine(newLine);
            }
        }
    }
}