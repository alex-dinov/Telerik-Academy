/*Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.stri
*/
using System;
using System.IO;
using System.Text.RegularExpressions;

class ExtractHTML
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"HTML.html");
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                var match = Regex.Matches(line,  @"(?<=^|>)[^><]+?(?=<|$)");
                foreach (var item in match)
                {
                    Console.WriteLine(item);
                }
                line = reader.ReadLine();
            }
        }
    }
}

