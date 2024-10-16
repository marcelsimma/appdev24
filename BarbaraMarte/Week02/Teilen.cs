namespace BarbaraMarte.Week02;

class Teilen
{
    public static void PrintTeilen()
    {
        // i used two diffrent basics that they don't use the result from the first calculation in the string
        int basic1 = 0;
        int basic2 = 0;
        int a = 5;
        decimal b = 5.0m;

        for (int i = 0; i <= 10; i++)
        {

            Console.WriteLine($"{basic1} / {a} = {basic1 / a}");
            basic1 += 1;
            Console.WriteLine($"{basic2} / {b} = {basic2 / b}");
            basic2 += 1;
        }

    }
}