/*Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.*/
using System;
using System.Collections.Generic;
using System.IO;

class SortStrings
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Names.txt");
        List<string> names = new List<string>();
        using (reader)
        {
            string line = reader.ReadLine();
            while (line!=null)
            {
                names.Add(line);
                line = reader.ReadLine();
            }
            names.Sort();
        }

        StreamWriter writer = new StreamWriter(@"..\..\NamesSorted.txt");
        using (writer)
        {
            foreach (var name in names)
            {
                writer.Write(name+"\r\n");
            }
        }
    }
}

