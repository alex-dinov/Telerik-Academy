/*Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d).
Example of incorrect expression: )(a+b)).
*/
using System;

class Brackets
{
    static void Main()
    {
        string text = Console.ReadLine();
        Console.WriteLine(CheckBrackets(text));
    }

    static bool CheckBrackets(string text)
    {
        int count=0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i]=='(')
            {
                count++;
            }
            if (text[i]==')')
            {
                count--;
            }
        }
        if (count==0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

