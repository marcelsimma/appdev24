
namespace ManuelHartmann.Week02
{

    public class _0_1_Counter_v02
    {
        static void Start(string[] args)
        {
            for (float i = 0.0f; i <= 100.0; i += 0.1f)
            {
                // Das "F1"-Format gibt an, dass der Wert als Fließkommazahl mit genau einer Nachkommastelle formatiert werden soll.
                string tryparseValue = i.ToString("F1");
                Console.WriteLine(tryparseValue);
            }
        }
    }
}




