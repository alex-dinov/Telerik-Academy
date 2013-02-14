/*You are given a text. Write a program that changes the text in all regions surrounded by the 
 * tags <upcase> and </upcase> to uppercase. The tags cannot be nested.
*/using System;
using System.Text;

class TagsUpcase
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine(ChangeToUppercase(text));
    }

    static string ChangeToUppercase(string text)
    {
        int openTag = text.IndexOf("<upcase>");
        int closeTag = text.IndexOf("</upcase>");
        while(openTag!=-1)
        {        
            int lenght=closeTag-openTag;
            string upper=text.Substring(openTag + 8, lenght-8).ToUpper();
            text = text.Insert(openTag, upper.ToUpper());
            text = text.Remove(openTag+upper.Length, lenght + 9);
            openTag = text.IndexOf("<upcase>",+1);
            closeTag = text.IndexOf("</upcase>",+1);
        }
        return text;
    }
}

