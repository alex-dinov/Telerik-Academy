using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class CleanCode
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool lineComment = false;
        bool multilineComment = false;

        bool inString = false;
        StringBuilder code = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < line.Length; j++)
            {
                if (j < line.Length - 1 && line[j] == '/' && line[j + 1] == '/')
                {
                    break;
                }
                if (j < line.Length - 1 && line[j] == '/' && line[j + 1] == '*')
                {
                    multilineComment = true;
                    continue;
                }
                if (j > 0 && line[j - 1] == '*' && line[j] == '/')
                {
                    multilineComment = false;
                    continue;
                }

                if (!multilineComment)
                {
                    code.Append(line[j]);
                }
            }


            if (!multilineComment)
            {
                code.AppendLine();
            }
            lineComment = false;

        }
        StringReader sr = new StringReader(code.ToString());
        string lineToPrint = null;
        while ((lineToPrint = sr.ReadLine()) != null)
        {
            if (!string.IsNullOrWhiteSpace(lineToPrint))
            {
                Console.WriteLine(lineToPrint);
            }
        }
    }
}