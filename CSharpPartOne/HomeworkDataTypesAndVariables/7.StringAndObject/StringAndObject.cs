using System;

class StringAndObject
{
    static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "World";
        object fullWord = firstWord + " " + secondWord;
        string convert = (string)fullWord;
        Console.WriteLine(fullWord);
    }
}

