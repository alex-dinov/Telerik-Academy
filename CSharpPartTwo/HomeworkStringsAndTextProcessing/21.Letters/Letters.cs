/*Write a program that reads a string from the console and prints all different letters in the string along with 
 * information how many times each letter is found. 
*/
using System;

class Letters
{
    static void Main()
    {
        string text = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...";
        FindLetters(text);
    }

    static void FindLetters(string text)
    {
        char[] letters = new char[65536];
        for (int i = 0; i < text.Length; i++)
        {
            int temp = text[i];
            letters[temp]++;
        }

        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i]!=0)
            {
                Console.WriteLine("{0} - {1} times", (char)i, (int)letters[i]);
            }
        }
    }
}

