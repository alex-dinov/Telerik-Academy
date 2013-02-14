/*Modify the solution of the previous problem to replace only whole words (not substrings).
*/
using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWords
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\text.txt");
        StreamWriter writer = new StreamWriter(@"..\..\newText.txt");
        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                    line = reader.ReadLine();
                }
            }
        }
    }
}

