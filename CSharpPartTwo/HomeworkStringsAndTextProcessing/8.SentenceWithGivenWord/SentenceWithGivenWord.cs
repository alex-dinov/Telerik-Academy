/*Write a program that extracts from a given text all sentences containing given word.
*/
using System;

class SentenceWithGivenWord
{
    static void Main()
    {
        string text="We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";
        FindSentence(text, word);
    }

    static void FindSentence(string text, string word)
    {
        char[] separators = {'.'};
        string[] sentence = text.Split(separators);
      
        for (int j = 0; j < sentence.Length; j++)
        {
            int index = sentence[j].IndexOf(word);
            while (index!=-1)
            {
                if (index==0 && sentence[j].Substring(index+word.Length,1)==" ")
                {
                    Console.WriteLine(sentence[j].TrimStart());
                }
                else if (index==sentence[j].Length-word.Length && sentence[j].Substring(index-1,1)==" ")
                {
                    Console.WriteLine(sentence[j].TrimStart());
                }
                else if (sentence[j].Substring(index + word.Length, 1) == " " && sentence[j].Substring(index-1, 1) == " ")
                {
                    Console.WriteLine(sentence[j].TrimStart());
                }
                index = sentence[j].IndexOf(word,index+1);
            }
        }       
    }
}