using System;

class NullValues
{
    static void Main()
    {
        int? nullValue1 = null;
        double? nullValue2 = null;
        Console.WriteLine("_{0}_ _{1}_", nullValue1, nullValue2);
        Console.WriteLine(nullValue1 + 5);
        nullValue1 = 10;
        Console.WriteLine(nullValue1.GetValueOrDefault());       
    }
}

