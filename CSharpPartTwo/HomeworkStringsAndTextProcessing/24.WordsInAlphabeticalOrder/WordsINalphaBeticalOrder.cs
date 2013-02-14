/*Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
*/
using System;

class WordsINalphaBeticalOrder
{
    static void Main()
    {
        string str = "Neque ipsum ipsum est qui ,dolorem ipsum velit dolor sit amet, consectetur, adipisci velit...";

        char[] separators = { ',', ' ', '.' };
        string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(words);
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}

