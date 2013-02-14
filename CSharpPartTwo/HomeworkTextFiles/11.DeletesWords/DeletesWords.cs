/*Write a program that deletes from a text file all words that start with the prefix "test".
 * Words contain only the symbols 0...9, a...z, A…Z, _.
*/
using System;
using System.IO;
using System.Text.RegularExpressions;

class DeletesWords
{
    static void Main()
    {
        StreamReader reader=new StreamReader(@"..\..\text.txt");
        StreamWriter writer = new StreamWriter(@"..\..\textNew.txt");
        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(Regex.Replace(line, @"\btest\w*\b", string.Empty));
                    line = reader.ReadLine();
                }
            }
        }
    }
}

