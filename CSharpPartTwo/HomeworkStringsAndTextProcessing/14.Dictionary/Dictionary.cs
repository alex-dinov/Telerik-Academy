/*A dictionary is stored as a sequence of text lines containing words and their explanations. 
 * Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
*/
using System;
using System.Text.RegularExpressions;

class Dictionary
{
    static void Main()
    {
        string[] dictionary ={
                            ".NET - platform for applications from Microsoft",
                            "CLR - managed execution environment for .NET",
                            "namespace - hierarchical organization of classes",
                            };
        string word = "CLR";
        TranslateWord(word,dictionary);
    }

    static void TranslateWord(string word,string[] dictionary)
    {
        for (int i = 0; i < dictionary.Length; i++)
		{
            var group = Regex.Match(dictionary[i], "(.*?) - (.*)").Groups;
            if (word==group[1].Value)
            {
                Console.WriteLine(group[0]);
            }
		}
    }
}
