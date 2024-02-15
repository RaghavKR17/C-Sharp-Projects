/*
Name: Raghav Krishna Ranganathan
Date: 10/07/2023

Week 3 Chapter 3-4 HW

HW #2

This code demonstrates a simple C# program that interacts with user input and
performs different tasks on a preset birth year and the user's name. It starts
by initializing a birth year variable and then showcases basic arithmetic
operations like addition, subtraction, and multiplication on it.

Additionally,the program prompts the user to enter their name, displays it in
uppercase and lowercase formats, and removes any leading or trailing white-space
characters.

*Note - Since the instructions didn't specify, I wasn't sure on whether I was
meant to permanently change the variable for every modification, or if I was
only printing the modified version and not altering the variable itself, so I
decided to alter the original variable each time.

*/

using System;
namespace UserInfo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Initialize "birthYear" variable with the value 2007
            int birthYear = 2007;

            // Print the value of birthYear to the console
            Console.WriteLine(birthYear);

            // Add 10 to birthYear, and print the updated value
            birthYear += 10;
            Console.WriteLine(birthYear);

            // Subtract 100 from the updated birthYear, and print the updated value
            birthYear -= 100; 
            Console.WriteLine(birthYear);

            // Multiply the updated birthYear by 2, and print the updated value
            birthYear *= 2; 
            Console.WriteLine(birthYear);

            // Prompt the user to enter their name
            Console.WriteLine("Please enter your name:");

            // Read the user's input and store it in the "name" variable
            string name = Console.ReadLine();

            // Display the user's name
            Console.WriteLine("Your name is: " + name);

            // Set the user's name to all uppercase, and print the updated value
            name = name.ToUpper();
            Console.WriteLine("Your name in uppercase is: " + name);

            // Set the user's recently updated (uppercase) name to all lowercase, and print the updated value
            name = name.ToLower();
            Console.WriteLine("Your name in lowercase is: " + name);

            // Remove all leading/trailing white-space characters from user's updated (all lowercase) name
            name = name.Trim();

            //Display the updated value
            Console.WriteLine("Your name (in lowercase) without leading or trailing white-space characters is: '" + name + "'");
        }
    }
}