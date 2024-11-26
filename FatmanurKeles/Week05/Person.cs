using System;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace FatmanurKeles.Week05
{
    public class Person
    {
        //Attribute werden bestimmt
        string _Name;
        string _Lastname;
        int _Age;

        //Konstruktor
        public Person(string name, string lastname, int age)
        {
            _Name = name;
            _Lastname = lastname;
            _Age = age;
        }

        public override string ToString()
        {
            return string.Format($"Person: {_Name},Nachname {_Lastname}, Alter: {_Age}");
        }
    }

    public class Auto
    {
        string _Brand;
        string _Colour;
        int _PS;

        public Auto(string brand, string colour, int ps)
        {
            _Brand = brand;
            _Colour = colour;
            _PS = ps;
        }

        public override string ToString()
        {
            return string.Format($"Auto: {_Brand}, Farbe: {_Colour}, PS: {_PS}");
        }

    }
    public class Schule
    {
        int _Students;
        string _Teacher;
        string _Subject;

        public Schule(int students, string teacher, string subject)
        {
            _Students = students;
            _Teacher = teacher;
            _Subject = subject;
        }

        public override string ToString()
        {
            return string.Format($"Schüler/innen: {_Students}, Lehrer/in: {_Teacher}, Fach: {_Subject}");
        }

    }

}