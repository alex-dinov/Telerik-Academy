/*Write a program that reverses the words in given sentence.
	Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".
*/
using System;
using System.Text;

class ReversedWordsInSentence
{
    static void Main()
    {
        string text="C# is not C++, not PHP and not Delphi!";
        ReverseText(text);
    }

    static void ReverseText(string text)
    {
        StringBuilder reversed = new StringBuilder();
        for (int i = text.Length-1; i >=0 ; i--)
        {
            reversed.Append(text[i]);
        }
       
        string[] reversedWords = reversed.ToString().Split();
        reversed.Clear();
        for (int i = 0; i < reversedWords.Length; i++)
        {
            string word = reversedWords[i]; 
            for (int j = reversedWords[i].Length-1; j >=0 ; j--)
            {
                reversed.Append(word[j]);
            }
            reversed.Append(" "); 
        }
        Console.WriteLine(reversed);
    }
}
