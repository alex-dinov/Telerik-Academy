/*Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. 
 * Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
*/
using System;
using System.Text;

class ReplaceIdenticalLetters
{
    static void Main()
    {
        string str = "aaaaabbbbbcdddeeeedssaa dura burra daaaa";

        StringBuilder sb = new StringBuilder();
        sb.Append(str[0]);
        for (int i = 0; i < str.Length; i++)
        {
            if (i>0 && str[i]!=str[i-1])
            {
                sb.Append(str[i]);
            }
        }
        Console.WriteLine(sb.ToString());
    }
}

