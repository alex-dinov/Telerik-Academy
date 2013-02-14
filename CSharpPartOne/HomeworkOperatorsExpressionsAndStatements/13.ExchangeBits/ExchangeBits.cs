//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
using System;

class ExchangeBits
{
    static void Main()
    {
        Console.WriteLine("Enter positive number:");
        uint number=uint.Parse(Console.ReadLine());
        Console.WriteLine("In binary code: {0}",Convert.ToString(number,2).PadLeft(32,'0'));
        uint mask = 7;
        uint firstThreeBits = number & (mask << 3);
        uint secondThreeBits = number & (mask << 24);
        uint firstThreeBitsMoved = firstThreeBits << 21;         
        uint secondThreeBitsMoved = secondThreeBits >> 21;   
        number = number & (~(mask << 3));
        number = number & (~(mask << 21));   
        number = number | firstThreeBitsMoved; 
        number = number | secondThreeBitsMoved;      
        Console.WriteLine("The new number after exchanging the bits is:\n{0}",number);
        Console.WriteLine("In binary code: {0}",Convert.ToString(number,2).PadLeft(32,'0'));                  
    }
}

