/*Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
*/
using System;

class Substring
{
    static void Main()
    {
        string text = Console.ReadLine();
        string substring = Console.ReadLine();

        Console.WriteLine(FindSubstring(text,substring));
    }

    static int FindSubstring(string text,string substring)
    {
        int index = text.IndexOf(substring,StringComparison.CurrentCultureIgnoreCase);
        int count = 0;
        while (index!=-1)
        {
            count++;
            index = text.IndexOf(substring, index + 1, StringComparison.CurrentCultureIgnoreCase);
        }
        return count;
    }
}

