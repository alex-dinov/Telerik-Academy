/*Write a program that reads a list of words from a file words.txt and finds 
 * how many times each of the words is contained in another file test.txt.
 * The result should be written in the file result.txt and the words should be sorted 
 * by the number of their occurrences in descending order. Handle all possible exceptions in your methods.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

class FindWords
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader(@"..\..\test.txt");
            StreamWriter writer = new StreamWriter(@"..\..\result.txt");
            StreamReader words = new StreamReader(@"..\..\words.txt");
            Dictionary<string, int> word = new Dictionary<string, int>();
            using (words)
            {
                string line = words.ReadLine();
                while (line!=null)
                {
                    word.Add(((Regex.Match(line, @"\b\w*\b")).Value),0);
                    line = words.ReadLine();
                }
            }

            using (writer)
            {
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        var w = Regex.Matches(line, @"\b\w*\b");
                        foreach (var match in w)
                        {
                            
                            if (word.ContainsKey(match.ToString()))
                            {
                                word[match.ToString()]++;
                            }
                            
                        }
                        line = reader.ReadLine();
                    }
                    
                    foreach (KeyValuePair<string, int> item in word.OrderByDescending(key => key.Value))
                    {
                        writer.WriteLine("{0}-{1}",item.Key,item.Value);
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

