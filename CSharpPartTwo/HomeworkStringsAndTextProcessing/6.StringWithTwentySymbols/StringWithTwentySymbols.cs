/*Write a program that reads from the console a string of maximum 20 characters. 
 * If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
 * Print the result string into the console.
*/
using System;
using System.Text;

class StringWithTwentySymbols
{
    static void Main()
    {
        string text = Console.ReadLine();
        Console.WriteLine(FillWithAsterix(text));
    }

    static string FillWithAsterix(string text)
    {
        while (text.Length<20)
        {
            text+="*";
        }
        if (text.Length>20)
        {
            text = text.Substring(0, 20);
        }
        return text;
    }
}
