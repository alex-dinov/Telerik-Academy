/*Write a program that reads a text file and inserts line numbers in front of each of its lines. 
 * The result should be written to another text file.
*/
using System;
using System.IO;

class InsertLineNumbers
{
    static void Main()
    {
        string oldFilePath=@"..\..\text.txt";
        string newFilePath=@"..\..\newtext.txt";
        int count = 1;
        StreamReader reader = new StreamReader(oldFilePath);
        using (reader)
        {
            using (StreamWriter writer=new StreamWriter(newFilePath,false))
            {
                string line = reader.ReadLine();
                writer.Write(count + ".");
                writer.WriteLine(line);
                while (line != null)
                {
                    count++;
                    writer.Write(count+".");
                    writer.WriteLine(line = reader.ReadLine());
                }
            }
        }
    }
}

