using Homework_3.classes;
using System;

User user1 = new User();

Console.WriteLine("Please enter the gender (Male/Female):");
string genderInput = Console.ReadLine();

if (Enum.TryParse(typeof(GetMyGender), genderInput, out object genderObject))
{
    if (genderObject is GetMyGender validGender)
    {
        user1.Gender = validGender;
    }
    else
    {
        Console.WriteLine("Invalid gender input.");
    }
}
else
{
    Console.WriteLine("Invalid gender input.");
}

Console.WriteLine("Please enter your year of birth:");
int birthYear;

if (int.TryParse(Console.ReadLine(), out birthYear))
{
    user1.BirthYear = birthYear;
}
else
{
    Console.WriteLine("The year of birth entered is invalid.");
}

Console.WriteLine("Please enter the first name:");
string firstName = Console.ReadLine();

try
{
    user1.FirstName = firstName;
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Please enter the last name:");
user1.LastName = Console.ReadLine();

Console.WriteLine(user1.ToString());
