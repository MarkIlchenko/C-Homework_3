using Homework_3.classes;
using System;


try
{
    User user1 = new User();

    static GetMyGender GetGenderFromInput()
    {
        GetMyGender gender;
        do
        {
            Console.WriteLine("Please enter the gender (Male/Female):");
            string genderInput = Console.ReadLine();

            if (Enum.TryParse(typeof(GetMyGender), genderInput, out object genderObject) && genderObject is GetMyGender validGender)
            {
                return validGender;
            }
            else
            {
                Console.WriteLine("Invalid gender input. Please try again.");
            }
        } while (true);
    }

    try
    {
        user1.Gender = GetGenderFromInput();
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }

    static int GetValidBirthYear()
    {
        int birthYear;
        do
        {
            Console.WriteLine("Please enter your year of birth:");

            if (int.TryParse(Console.ReadLine(), out birthYear))
            {
                return birthYear;
            }
            else
            {
                Console.WriteLine("The year of birth entered is invalid. Please try again.");
            }
        } while (true);
    }

    try
    {
        user1.BirthYear = GetValidBirthYear();
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }

    static string GetValidFirstName()
    {
        string firstName;
        do
        {
            Console.WriteLine("Please enter the first name:");
            firstName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(firstName) || !char.IsUpper(firstName[0]) || firstName.Length < 2)
            {
                Console.WriteLine("Invalid first name. Please try again.");
            }
            else
            {
                return firstName;
            }
        } while (true);
    }

    try
    {
        user1.FirstName = GetValidFirstName();
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }

    static string GetValidLastName()
    {
        do
        {
            Console.WriteLine("Please enter the last name:");
            string lastName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(lastName))
            {
                return lastName;
            }
            Console.WriteLine("Invalid last name. Please try again.");
        } while (true);
    }

    user1.LastName = GetValidLastName();

    Console.WriteLine(user1.ToString());
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

