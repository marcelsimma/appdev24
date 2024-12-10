using System;
using System.Dynamic;

namespace LucasSchiemann.Week08.Bibliotheke;

public class Medium
{
    public string[] Bindung = ["Hardcover","Softcover"];
    public string Title{get;set;}
    public string Autor{get;set;}
    public string ReleaseDate{get;set;}
    public string ISBN{get;set;}

    public Medium (string title,string author, string releaseDate ,string iSBN)
    {
        Title = title;
        Autor = author;
        ReleaseDate = releaseDate;
        ISBN = iSBN;
    }
    public virtual void ShowBook()
    {
        System.Console.WriteLine($"Titel des Buches: {Title}\n Autor: {Autor}\n Veröffentlichungs Jahr: {ReleaseDate}\n ISBN: {ISBN}");


    }
    

}