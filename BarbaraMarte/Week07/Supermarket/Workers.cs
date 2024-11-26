namespace BarbaraMarte.Week07.Supermarket;

class Workers
{
    private string NameOfWorker { get; set; }
    private double StartTimeAccordingToSchedule { get; set; }
    private double EndAccordingToSchedule { get; set; }
    private double Overtime { get; set; }
    private bool IsWorkingNow { get; set; }
    private bool IsSick { get; set; }

    public Workers(string nameOfWorker, double startTimeAccordingToSchedule, double endAccordingToSchedule, double overtime, bool isWorkingNow, bool isSick)
    {
        NameOfWorker = nameOfWorker;
        StartTimeAccordingToSchedule = startTimeAccordingToSchedule;
        EndAccordingToSchedule = endAccordingToSchedule;
        Overtime = overtime;
        IsWorkingNow = isWorkingNow;
        IsSick = isSick;
    }
    public override string ToString()
    {
        return string.Format(
            $@"
            Name: {NameOfWorker,20}
            Schedule Start: {StartTimeAccordingToSchedule,10:F2}
            Schedule End: {EndAccordingToSchedule,12:F2}
            Overtime: {Overtime,16:F2}
            Is at Work: {IsWorkingNow,14}
            Is sick: {IsSick,17}            
            ");
    }
}