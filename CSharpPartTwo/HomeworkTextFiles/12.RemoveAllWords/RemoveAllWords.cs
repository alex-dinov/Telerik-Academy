/*Write a program that removes from a text file all words listed in given another text file. 
 * Handle all possible exceptions in your methods.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class RemoveAllWords
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader(@"..\..\text.txt");
            StreamWriter writer = new StreamWriter(@"..\..\textNew.txt");

            StreamReader words = new StreamReader(@"..\..\words.txt");
            List<string> word = new List<string>();
            using (words)
            {
                string line = words.ReadLine();
                while (line != null)
                {
                    word.Add((Regex.Match(line, @"\b\w*\b")).Value);

                    line = words.ReadLine();
                }
            }
            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        for (int i = 0; i < word.Count; i++)
                        {
                            line = Regex.Replace(line, @"\b(" + word[i] + @")\b", string.Empty).Trim();
                        }
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

