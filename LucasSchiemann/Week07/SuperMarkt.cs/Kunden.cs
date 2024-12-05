using System;

namespace LucasSchiemann.Week07.SuperMarkt;

public class Customer
{
    public string FullName;
    public int Age;
    public string Gender;

    public Customer(string fullName,int age,string gender)
    {
        FullName = fullName;
        Age = age;
        Gender = gender;

    }


}