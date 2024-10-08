using System;

namespace SimonJochum.Week02
{
    public class SmallSteps
    {
        public static void FirstSmallSteps()
        {
            double currentStep = 0.0;
            double stepToAdd = 1.0 / 10.0;
            
            while (currentStep <= 100)
            {
                Console.WriteLine(Math.Round(currentStep, 1));
                currentStep += stepToAdd;
            }
        }
        public static void SecondSmallSteps()
        {
             double stepToAdd = 1.0 / 10.0;

            for (double currentStep = 0.0; currentStep <=100; currentStep += stepToAdd)
            {
            Console.WriteLine(Math.Round(currentStep, 1));

            }
        }
    }
}