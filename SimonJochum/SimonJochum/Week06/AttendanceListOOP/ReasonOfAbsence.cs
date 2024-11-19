using System;
using System.Globalization;

namespace SimonJochum.Week06.AttendanceListOOP
{
    public class ReasonOfAbsence
{
    public DateTime StartTime;
    public DateTime EndTime;
    public string AbsenceReason;
    public bool Excused;

    public ReasonOfAbsence(string absenceReason, DateTime startTime, DateTime endTime, bool excused)
    {
        AbsenceReason = absenceReason;
        StartTime = startTime;
        EndTime = endTime;
        Excused = excused;
    }

    public override string ToString()
    {
        return $"{AbsenceReason}, von {StartTime:dd.MM.yyyy HH:mm} bis {EndTime:dd.MM.yyyy HH:mm}, Entschuldigt: {Excused}";
    }
}
}