/*Write a program that, depending on the user's choice inputs int, double or string variable. 
If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
The program must show the value of that variable as a console output. Use switch statement.
*/
using System;

class ChoiceInput
{
    static void Main()
    {
        Console.WriteLine("Enter 1 for int, 2 for double, and 3 for string");
        byte choice = byte.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: int firstChoise = int.Parse(Console.ReadLine());
                Console.WriteLine(firstChoise + 1);
                break;
            case 2: double secondChoise = double.Parse(Console.ReadLine());
                Console.WriteLine(secondChoise + 1);
                break;
            case 3: string thirdChoise = Console.ReadLine();
                Console.WriteLine(thirdChoise + "*");
                break;
            default: Console.WriteLine("Invalid input");
                break;
        }
    }
}

