/*Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
*/
using System;
using System.Text;
using System.Text.RegularExpressions;

class Palindromes
{
    static void Main()
    {
        string str = "ABBA durabura arab dadadsas 9009 ,lamal sdadd exe";
        TakePalindromes(str);
    }

    static void TakePalindromes(string text)
    {
        char[] separators = { '.',',',' '};
        string[] words = text.Split(separators,StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            string temp = words[i];
            StringBuilder sb = new StringBuilder();
            for (int j = words[i].Length-1; j >=0; j--)
            {
                sb.Append(temp[j]);
            }
            if (sb.ToString()==words[i])
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}

