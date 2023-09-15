﻿using Homework_3.classes;
using System;


try
{
    User user1 = new User();

    static GetMyGender GetGenderFromInput()
    {
        Console.WriteLine("Please enter the gender (Male/Female):");
        string genderInput = Console.ReadLine();

        if (Enum.TryParse(typeof(GetMyGender), genderInput, out object genderObject) && genderObject is GetMyGender validGender)
        {
            return validGender;
        }
        else
        {
            throw new ArgumentException("Invalid gender input.");
        }
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
        Console.WriteLine("Please enter your year of birth:");

        if (int.TryParse(Console.ReadLine(), out int birthYear))
        {
            return birthYear;
        }
        else
        {
            throw new ArgumentException("The year of birth entered is invalid.");
        }
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
        Console.WriteLine("Please enter the first name:");
        string firstName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(firstName) || !char.IsUpper(firstName[0]) || firstName.Length < 2)
        {
            throw new ArgumentException("Invalid first name.");
        }

        return firstName;
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
        Console.WriteLine("Please enter the last name:");
        return Console.ReadLine();
    }

    user1.LastName = GetValidLastName();

    Console.WriteLine(user1.ToString());
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

