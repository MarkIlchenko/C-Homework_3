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


