//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company and its manager and prints them on the console.
//
using System;

class CompanyInfo
{
    static void Main()
    {
        Console.Write("Enter company name:");
        string companyName = Console.ReadLine();
        Console.Write("Enter company adress:");
        string companyAdress = Console.ReadLine();
        Console.Write("Enter company phone number:");
        ulong companyPhoneNumber = ulong.Parse(Console.ReadLine());
        Console.Write("Enter company fax:");
        long companyFaxNumber = long.Parse(Console.ReadLine());
        Console.Write("Enter company website:");
        string companyWebsite = Console.ReadLine();             

        Console.Write("Enter manager firstname:");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter manager lastname:");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter manager age:");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Enter manager phone number:");
        ulong managerPhoneNumber = ulong.Parse(Console.ReadLine());

        Console.WriteLine("The company name is {0} and it's located at {1}."+
            "The company phone and fax numbers are {2}  {3}."+
            "The website of the company is {4} ", companyName, companyAdress, companyPhoneNumber, companyFaxNumber, companyWebsite);
        Console.WriteLine("The company have a manager.His name is {0} {1}."+
            "He's {2} years old and his phone number is {3}",managerFirstName,managerLastName,managerAge,managerPhoneNumber);
    }
}
