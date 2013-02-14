/*Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a>
 * with corresponding tags [URL=…]…/URL]. Sample HTML fragment:
*/
using System;
using System.Text.RegularExpressions;

class ReplaceHTML
{
    static void Main()
    {
        string html = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        ReplaceTags(html);
    }

    static void ReplaceTags(string html)
    {
        var newOne = Regex.Replace(html, "<a href=\"(.*?)\">(.*?)</a>","[URL=$1] $2[/URL]");
        Console.WriteLine(newOne);
    }
}

