/*

Name: Raghav Krishna Ranganathan
Date: 11/30/2023

C# Final Test

This C# program checks if a user is old enough to drive based on their age.

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter their age
        int userAge = GetAge();

        // Check if the user can drive based on their age
        bool canTheUserDrive = CheckDrivingAge(userAge);

        // Print a message based on whether the user can drive or not
        PrintMessage(canTheUserDrive);
    }

    // Get the age from the user
    static int GetAge()
    {
        Console.Write("What is your age? Enter: ");
        int age = Convert.ToInt32(Console.ReadLine());
        return age;
    }

    // Check if the age is greater than or equal to 16
    static bool CheckDrivingAge(int age)
    {
        if (age >= 16)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Print a message based on whether the user can drive or not
    static void PrintMessage(bool canDrive)
    {
        if (canDrive)
        {
            Console.WriteLine("\nThanks for using the driving age check program.");
            Console.WriteLine("You are allowed to drive.");
            Console.WriteLine("Have a great day!");
            Console.WriteLine("\nPress any key to continue...");
        }
        else
        {
            Console.WriteLine("\nThanks for using the driving age check program.");
            Console.WriteLine("You are NOT allowed to drive.");
            Console.WriteLine("Have a great day!");
            Console.WriteLine("\nPress any key to continue...");
        }
    }
}
