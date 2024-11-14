using System;

namespace MagdalenaMueller.Week05
{
    public class Car
    {
        string marke;
        int ps;
        int costs;

        public Car(string marke, int ps, int costs)
        {
            this.marke = marke;
            this.ps = ps;
            this.costs = costs;
        }

        public override string ToString()
        {
            return $"Marke: {marke}, PS: {ps}, Kosten: {costs}";
        }

        public void Write()
        {
            Console.WriteLine(this.ToString());
        }
    }
    public class Persons
    {
        string name;
        int age;
        int height;

        public Persons(string name, int age, int height)
        {
            this.name = name;
            this.age = age;
            this.height = height;;
        }
        public override string ToString()
        {
            return $"Name: {name}, Alter: {age}, Größe: {height}";
        }
        public void Write()
        {
            Console.WriteLine(this.ToString());
        }
    }

    public class Appartment
    {
        string adress;
        int valueApartments;
        string garage;
        string sold;

        public Appartment(string adress, int valueApartments, string garage)
        {
            this.adress = adress;
            this.valueApartments = valueApartments;
            this.garage = garage;
        }

        public void IsSold()
        {
            var r = new Random();
            int randomValue = r.Next(0, 2); 

            if (randomValue == 0)
            {
                sold = "Nein";
            }
            else if (randomValue == 1)
            {
                sold = "Ja";
            }
        }
        public override string ToString()
        {
            return $"Adresse: {adress}, Anzahl Wohnungen: {valueApartments}, Garage Vorhanden: {garage} Verkauft: {sold}";
        }
        public void Write()
        {
            IsSold();
            Console.WriteLine(this.ToString());
        }
    }
    public class Food
    {
        int calories;
        int sugar;
        int salt;
        string sweetOrPikant;

        public Food(int calories, int sugar, int salt)
        {
            this.calories = calories;
            this.sugar = sugar;
            this.salt = salt;
        }

        public void CalcSweetOrPikant()
        {
            if(sugar < salt)
            {
                sweetOrPikant = "Pikant";
            }
            if(sugar > salt)
            {
                sweetOrPikant = "Süß";
            }
            if(sugar == salt)
            {
                sweetOrPikant = "Neutral";
            }
        }
        public override string ToString()
        {
            return $"Kaloriern: {calories}, Zucker: {sugar}g, Salz: {salt}g Schmeckt: {sweetOrPikant}";
        }
        public void Write()
        {
            CalcSweetOrPikant();
            Console.WriteLine(this.ToString());
        }
    }

    public class Freezer
    {
        int temperatur;
        int currentTemperatur;
        string filled;

        public Freezer(int temperatur, string filled)
        {
            this.temperatur = temperatur;
            this.filled = filled;
        }

        public void CalcCurrentTemperatur()
        {
            var r = new Random();
            int randomTemperatur= r.Next(0, temperatur);

            currentTemperatur = randomTemperatur;
        }

        public override string ToString()
        {
            return $"Gewünschte Temparatur: {temperatur}, Temparatur Kühlschrank: {currentTemperatur}, Befüllt?: {filled}";
        }
        public void Write()
        {
            CalcCurrentTemperatur();
            Console.WriteLine(this.ToString());
        }

        
    }
    public class CalcFromArray 
    {
        int[] numbers; 
        int lowestNumber = 999999999;
        int highestNumber = 0;
        double average = 0;
        
        public CalcFromArray(int[] numbers) 
        {
            this.numbers = numbers;
        }

        public void Calc()
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] < lowestNumber)
                {
                    lowestNumber = numbers[i];
                }
                if(numbers[i] > highestNumber)
                {
                    highestNumber = numbers[i];
                }
                average += numbers[i];
            }
            average /= numbers.Length;
        }
        public override string ToString()
        {
            return $"Kleinste Zahl: {lowestNumber}, Größte Zahl: {highestNumber}, Durchschnitt: {Math.Round(average, 2)}";
        }
        public void Write()
        {
            Calc();
            Console.WriteLine(this.ToString());
        }
    }
}