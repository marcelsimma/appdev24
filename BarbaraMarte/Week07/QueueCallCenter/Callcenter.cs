using System;

namespace BarbaraMarte.Week07.QueueCallCenter;

class CallCenter
{
    public string FullName;
    public string PhoneNumber;
    public DateTime CallTime;

    public CallCenter(string fullname, string phoneNumber, DateTime callTime)
    {
        FullName = fullname;
        PhoneNumber = phoneNumber;
        CallTime = callTime;
    }
    public override string ToString()
    {
        return $"Calling party: {FullName,-15} Phone number: {PhoneNumber,-15} Call Time: {CallTime,18}";
    }
}