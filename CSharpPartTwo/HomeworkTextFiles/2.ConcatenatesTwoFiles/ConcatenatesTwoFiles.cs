/*Write a program that concatenates two text files into another text file.
*/
using System;
using System.IO;

class ConcatenatesTwoFiles
{
    static void Main()
    {
        string fileOne = "some text";
        string fileTwo = " and some more text";
        string fileSum="SumFile.txt";
        
        using (StreamWriter overwrite=new StreamWriter(fileSum,false))
        {
            overwrite.Write(fileOne);
        }
        using (StreamWriter append = new StreamWriter(fileSum, true))
        {
            append.Write(fileTwo);
        }

        using (StreamReader reader=new StreamReader(fileSum))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
        }
    }
}

