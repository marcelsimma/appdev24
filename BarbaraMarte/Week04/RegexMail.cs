using System;
using System.Text.RegularExpressions;


namespace BarbaraMarte.Week04;

class RegexMail
{
    public static void Print()
    {
        Console.WriteLine("Please enter your Email adress:");
        string? email = Console.ReadLine();


        if (IsValidEmail(email)) 
        {
            Console.WriteLine("It's a valid email");
        }
        else
        {
            Console.WriteLine("This is not a valit email");
        }

    }

    public static bool IsValidEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

        //       1           2          3        7    4    1        2        3       5  7        6      7   8
        // string pattern = @"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z]{1,64})*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.{3,64})+[a-zA-Z]{2,9})$";
        /*  1 the first character of the email must be an alphabetic charachter(0-9a-zA-Z)
            2 after the first character it allows any number of alphanumeric characters, hypens, periods or underscores (denoted by \w) 
            3 ensures that the part before the @ symbol ends wirh an alphanumeric character
            4 matches the @ symbol in the email adress
            5 \. ensures there's a literal dot after the domain
            6 this part defines the top-level domain (TDL)
            7 it can not be shorter than the first number and not longer than the last number
            8 Anchors the match at the end of the string, ensuring that nothing follows the TLD.
        */
        return Regex.IsMatch(email, pattern);
    }
}