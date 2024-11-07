using System.IO;

namespace BarbaraMarte.Week05;

class Quadrieren
{
    public static void Print()
    {
        string numbers;
        using (StreamReader streamReader = new StreamReader("C:/AttendingList1/QuadrierenInput.txt"))
        {
            using (StreamWriter streamWriter = new StreamWriter("C:/AttendingList1/QuadrierenOutput.txt"))
            {
                while ((numbers = streamReader.ReadLine()) != null)
                {
                    if (int.TryParse(numbers, out int result))
                    {
                        result = result * result;
                        streamWriter.WriteLine(result);
                        Console.WriteLine(result);
                    }
                }
            }
        }
    }
}