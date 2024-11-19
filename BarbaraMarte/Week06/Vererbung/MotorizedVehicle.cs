namespace BarbaraMarte.Week06.Vererbung;

public class MotorizedVehicle : Vehicle
{
    double _GasUsagePer100KM;
    double _GasTankVolume;
    double _LeftInTheGasTank;
    double _KM;
    public double KM
    {
        get => _KM;
        set => _KM = value;
    }
    public double GasUsagePer100KM
    {
        get => _GasUsagePer100KM;
        set => _GasUsagePer100KM = value;
    }
    public double GasTankVolume
    {
        get => _GasTankVolume;
        set => _GasTankVolume = value;
    }
    public double LeftInTheGasTank
    {
        get => _LeftInTheGasTank;
        set => _LeftInTheGasTank = value;
    }
    public MotorizedVehicle(string name, string producer, string color, int age, double km, double leftInTheGasTank, double gasUsagePer100KM)
    {
        _Name = name;
        _Producer = producer;
        _Color = color;
        _Age = age;
        LeftInTheGasTank = leftInTheGasTank;
        GasUsagePer100KM = gasUsagePer100KM;
        KM = km;
    }
    public void Drive(double KM)
    {
        CalculateGasStand();
    }
    public string CalculateGasStand()
    {
        LeftInTheGasTank -= GasUsagePer100KM + (KM / 100);

        if (LeftInTheGasTank > 0)
        {
            return $@"{LeftInTheGasTank:F2} liter are left.
            Let's continue our adventure!";
        }
        else
        {
            return $@" {LeftInTheGasTank:F2} liter
            It's me. Your Vehicle. I would love to keep going on driving but I have no Gas left.
            That's the amount of Gas I would need to continue our ride: {-LeftInTheGasTank:F2} liter";
        }
    }
}