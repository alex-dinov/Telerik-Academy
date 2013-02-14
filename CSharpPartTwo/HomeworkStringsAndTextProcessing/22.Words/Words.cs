/*Write a program that reads a string from the console and lists all different words in 
 * the string along with information how many times each word is found.
*/
using System;
using System.Collections.Generic;
using System.Text;

class Words
{
    static void Main()
    {
        string str = "Neque ipsum ipsum est qui ,dolorem ipsum velit dolor sit amet, consectetur, adipisci velit...";
        FindWords(str);
    }

    static void FindWords(string str)
    {
        char[] separators = { ' ', '.', ',', '!' };
        string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> allWords = new Dictionary<string, int>();
        for (int i = 0; i < words.Length; i++)
        {
            if (allWords.ContainsKey(words[i]))
            {
                allWords[words[i]]++;
            }
            else
            {
                allWords.Add(words[i], 1);
            }
        }
        foreach (var item in allWords)
        {
            Console.WriteLine("{0}  - {1} times found", item.Key, item.Value);
        }
    }
}

