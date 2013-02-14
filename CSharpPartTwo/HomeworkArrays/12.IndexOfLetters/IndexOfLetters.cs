/*Write a program that creates an array containing all letters from the alphabet (A-Z). 
 * Read a word from the console and print the index of each of its letters in the array.
*/
using System;

class IndexOfLetters
{
    static void Main()
    {
        string[] letters = { "A", "B" ,"C" ,"D" ,"E" ,"F" ,"G" ,"H" ,"I" ,"J" ,"K" ,"L" ,"M" ,
                         "N" ,"O" ,"P" ,"Q" ,"R" ,"S" ,"T" ,"U" ,"V" ,"W" ,"X" ,"Y" ,"Z" };
        Console.WriteLine("Enter word:");
        string word = Console.ReadLine();
        int index = 0;
        string letter=" ";

        for (int i = 0; i < word.Length; i++)
        {
            letter = word.Substring(i,1);
            for (int j = 0; j < letters.Length; j++)
            {
                if (letters[j]==letter)
                {
                    index=j;
                    break;
                }
            }
            Console.Write(letter+":"+" ");
            Console.Write(index);
            Console.WriteLine();
        }
    }
}

