using System;
using LucasSchiemann.Week02;

public class Person
{
    public string _Name;
    public int _Age;
    int _Height;
    int _Weight;

    public string Name
    {
    get => "\"" + _Name + "\"";
    }

    public int Height
    {
        get => _Height;
        set => _Height = value;
    }

    public Person(string name, int age, int height, int weigth)
    {
        _Name = name;
        _Age = age;
        _Height = height;
        _Weight = weigth;
        }

    public void hasABirthday()
    {
        _Age++;
    }

    public override string ToString()
    {

    return string.Format("Person: {0}, age: {1}", _Name, _Age);
    
    }

    }
    