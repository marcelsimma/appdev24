
namespace ManuelHartmann.Week02
{

    public class _0_1_Counter
    {
        static void Start(string[] args)
        {
            float count = 0f;
            for (int i = 0; i < 1000; i ++)
            {
                count += 0.1f;
                // Mit der Rechenoperation 'Math.Round' kann man einen 'float' auf eine bestimmte Nachkommastelle runden.
                float rounded = (float)Math.Round(count, 1); // Ergebnis enthält nur noch eine Kommastelle
                Console.WriteLine(rounded);
            }
        }
    }
}




