/*Write a program that compares two text files line by line and prints the number of 
 * lines that are the same and the number of lines that are different.
 * Assume the files have equal number of lines.*/
using System;
using System.IO;

class CompareTwoFiles
{
    static void Main()
    {
        StreamReader fileOne = new StreamReader(@"..\..\firstOne.txt");
        StreamReader fileTwo = new StreamReader(@"..\..\secondOne.txt");
        int sameLines=0;
        int diffLines = 0;
        bool same = false;
        using (fileOne)
        {
            string lineOne = fileOne.ReadLine();
            using (fileTwo)
            {
                string lineTwo = fileTwo.ReadLine();
                while (lineOne!=null && lineTwo!=null)
                {
                    for (int i = 0; i < lineTwo.Length; i++)
                    {
                        if (lineOne.Length!=lineTwo.Length)
                        {
                            diffLines++;
                            break;
                        }
                        if (lineOne[i]==lineTwo[i])
                        {
                            same=true;
                        }
                        else
                        {
                            same=false;
                            diffLines++;
                            break;
                        }
                    }
                    if (same)
                    {
                        sameLines++;
                    }
                    
                    lineOne = fileOne.ReadLine();
                    lineTwo = fileTwo.ReadLine();
                    same = false;
                }
            }
        }
        Console.WriteLine("There is {0} different lines in two .txt files",diffLines);
        Console.WriteLine("There is {0} same lines in two .txt files",sameLines);
    }
}

