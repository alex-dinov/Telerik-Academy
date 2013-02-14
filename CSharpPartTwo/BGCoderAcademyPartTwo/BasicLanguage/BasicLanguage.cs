using System;
using System.Text;

class BasicLanguage
{
    static StringBuilder output = new StringBuilder();
    static void Main()
    {
        StringBuilder buffer = new StringBuilder();
        bool inBracket = false;
        while (true)
        {
            int chr = Console.Read();
            
            if (chr==-1)
            {
                break;
            }
            char nextChar = (char)chr;
            if (nextChar=='(')
            {
                inBracket = true;   
            }
            if (nextChar==')')
            {
                inBracket = false;
            }
            if (nextChar==';' && !inBracket)
            {
                string part = buffer.ToString();
                if (Process(part) == true)
                {
                    break;
                }
                buffer.Clear();
            }
            else
            {
                if (inBracket)
                {
                    buffer.Append(nextChar);
                }
                else if(!char.IsWhiteSpace(nextChar))
                {
                    buffer.Append(nextChar);
                }
            }
        }
        Console.WriteLine(output);
    }

    private static bool Process(string part)
    {
        long count = 1;
        string[] command = part.Split(')');
        for (int i = 0; i < command.Length; i++)
        {
            string cmd = command[i];
            cmd = cmd.TrimStart();
            if (cmd.StartsWith("EXIT"))
            {
                return true;
            }
            else if (cmd.StartsWith("PRINT"))
            {
                int start = cmd.IndexOf('(')+1;
                string content = cmd.Substring(start);
                if (content.Length > 0 && count > 0)
                {
                    for (int c = 0; c < count; c++)
                    {
                        output.Append(content);
                    }
                }
            }
            else if (cmd.StartsWith("FOR"))
            {
                int start = cmd.IndexOf('(') + 1;
                int commaIndex = cmd.IndexOf(',');
                if (commaIndex==-1)
                {
                    string a = cmd.Substring(start);
                    int parsedA = int.Parse(a);
                    count = count * parsedA;
                }
                else
                {
                    string a = cmd.Substring(start, commaIndex - start);
                    int parsedA = int.Parse(a);
                    string b = cmd.Substring(commaIndex + 1);
                    int parsedB = int.Parse(b);
                    count*= parsedB - parsedA + 1;
                }
            }
        }
    
        return false;
    }
}

