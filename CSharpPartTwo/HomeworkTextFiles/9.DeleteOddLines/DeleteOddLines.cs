/*Write a program that deletes from given text file all odd lines. The result should be in the same file.
*/
using System;
using System.Collections.Generic;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\text.txt");
        List<string> rows=new List<string>();
        using (reader)
        {
            int lineNumber = 1;
            string line = reader.ReadLine();
            while (line!=null)
            {
                lineNumber++;
                if (lineNumber%2!=0)
                {
                    rows.Add(line);
                }
                line = reader.ReadLine();
            }           
        }
        StreamWriter writer = new StreamWriter(@"..\..\text.txt");
        using (writer)
        {
            foreach (var row in rows)
            {
                writer.WriteLine(row);
            }
        }
    }
}

