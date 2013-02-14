using System;

class StringQuotations
{
    static void Main()
    {
        string expression1 = "The \"use\" of quotations causes difficulties";
        string expression2 = @"The ""use"" of quotations causes difficulties";
        Console.WriteLine(expression1);
        Console.WriteLine(expression2);
    }
}

