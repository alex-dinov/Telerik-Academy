using System;

class Anacci
{
    static void Main()
    {
        char letter=char.Parse(Console.ReadLine());
        char letter2 = char.Parse(Console.ReadLine());
        char newLetter;
        int num1 = letter - '@';
        int num2 = letter2 - '@';
        int sum = 0;
        string whitespace = " ";
        int L = int.Parse(Console.ReadLine());
        if (L==1)
        {
            Console.WriteLine(letter);
            return;
        }
        

        Console.WriteLine(letter);   
        
        sum = num1 + num2;
        if (sum>26)
        {
            sum = sum % 26;
        }
        num1 = num2;
        num2 = sum;
       
        Console.Write(letter2);
        newLetter = (char)(sum + 64);
        Console.WriteLine(newLetter);
              
        for (int i = 3; i <= L; i++)
        {
            sum = num1 + num2;
            if (sum > 26)
            {
                sum = sum % 26;
            }
            newLetter = (char)(sum + 64);
            Console.Write(newLetter);
            Console.Write(whitespace);
            num1 = num2;
            num2 = sum;
            whitespace += " ";
            sum = num1 + num2;
            if (sum > 26)
            {
                sum = sum % 26;
            }
            newLetter = (char)(sum + 64);
            Console.Write(newLetter);
            num1 = num2;
            num2 = sum;
            Console.WriteLine();
        }
    }
}

