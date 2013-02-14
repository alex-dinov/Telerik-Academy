/*Write a program that encodes and decodes a string using given encryption key (cipher). 
 * The key consists of a sequence of characters. The encoding/decoding is done by performing XOR 
 * (exclusive or) operation over the first letter of the string with the first of the key, 
 * the second – with the second, etc. When the last key character is reached, the next is the first.
*/
using System;
using System.Text;

class EncryptionKey
{
    static void Main()
    {
        string text = Console.ReadLine();
        string key = Console.ReadLine();
        Console.WriteLine(MakeCipher(text, key));
        
    }

    static string MakeCipher(string text, string key)
    {
        int counter=0;
        while (key.Length < text.Length)
        {
            key=key.Insert(key.Length, key.Substring(counter, 1));
            counter++;
        }
        int result = 0;
        string cipher = "";
        for (int i = 0; i < text.Length; i++)
        {
            result = text[i] ^ key[i];
            cipher += (char)result;
        }
        return cipher;
    }
}
