/*Write a program that reads a string, reverses it and prints the result at the console.
Example: "sample"  "elpmas".
*/
using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string text = Console.ReadLine();
        Console.WriteLine(Reverse(text));
    }

    static string Reverse(string text)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = text.Length-1; i >=0 ; i--)
        {
            sb.Append(text[i]);
        }
        return sb.ToString();
    }
}

