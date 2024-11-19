using System;
namespace JulianStroehle.Week5.models
{
    public class Car
    {
        string brand;
        int ps;
        string model;
        int maxSpeed;
        int kilometers;
        public int Kilometers
        {
            get => kilometers;
        }
        public Car(string brand, int ps, string model, int maxSpeed, int kilometers)
        {
            this.brand = brand;
            this.ps = ps;
            this.model = model;
            this.maxSpeed = maxSpeed;
            this.kilometers = kilometers;
        }
        public void driveToWork(int distanceToWork)
        {
            kilometers += distanceToWork;
        }
        public override string ToString()
        {
            return string.Format("Marke: {0}, PS: {1}", brand, ps);
        }
    }
}