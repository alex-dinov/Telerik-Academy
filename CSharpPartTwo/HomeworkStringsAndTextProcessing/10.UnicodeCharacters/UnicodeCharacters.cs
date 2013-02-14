/*Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input:
*/
using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string str = "Hi!";
        StringBuilder sb = new StringBuilder();

        foreach (var symbol in str)
        {
            sb.AppendFormat("\\u{0:X4}", (int)symbol);
        }
        Console.WriteLine(sb.ToString());
    }
}

