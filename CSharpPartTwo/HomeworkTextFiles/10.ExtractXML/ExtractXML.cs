/*Write a program that extracts from given XML file all the text without the tags. */
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ExtractXML
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\XML.xml");
        StringBuilder xml = new StringBuilder();
        bool prefix = false;
        using (reader)
        {
            string line = reader.ReadLine();
            while (line!=null)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i]=='<')
                    {
                        prefix = true;
                        while (line[i]!='>')
                        {
                            i++;
                            prefix = false;
                        }
                    }
                    else
                    {
                        xml.Append(line[i].ToString().Trim());
                    }
                }
                line = reader.ReadLine();
            }
            Console.WriteLine(xml.ToString());
        }
    }
}

