using System;
 
namespace JonasWehinger.A3;
 
class StartNumber3
{
    public static void StartOfThree()
    {
        {
            var heu = new Futter("Heu", 0.50f);
            var wasser = new Futter("Wasser", 0.02f);
            var obst = new Futter("Obst", 2.00f);

            var zoo = new Zoo();
            zoo.AddFutter(heu);
            zoo.AddFutter(wasser);
            zoo.AddFutter(obst);

            var kuhFutterbedarf = new Dictionary<string, float> { { "Heu", 20.0f }, { "Wasser", 5.0f } };
            var storchFutterbedarf = new Dictionary<string, float> { { "Wasser", 10.0f }, { "Obst", 2.0f } };

            var kuh = new Tier("Rijska", kuhFutterbedarf);
            var storch = new Tier("Garmond", storchFutterbedarf);

            zoo.AddTier(kuh);
            zoo.AddTier(storch);

            zoo.BerechneUndGebeFutterbedarfAus();
        }
    }
}