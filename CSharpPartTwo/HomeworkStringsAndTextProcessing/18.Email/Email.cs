/*Write a program for extracting all email addresses from given text. 
 * All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
*/
using System;
using System.Text.RegularExpressions;

class Email
{
    static void Main()
    {
        string text = " dura bura @telerik.com a@a.b adadad@ pesho@btv.com" ;

        var emails = Regex.Matches(text, "(\\w+)(\\w+)@(\\w+)(\\w+)\\.(\\w+)(\\w+)");

        foreach (var email in emails)
        {
            Console.WriteLine(email);
        }
    }
}
